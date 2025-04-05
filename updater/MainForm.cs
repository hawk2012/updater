using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Renci.SshNet;

namespace updater
{
    public partial class MainForm : Form
    {
        private bool _isCancelled = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void cancelupdate_Click(object sender, EventArgs e)
        {
            _isCancelled = true;
            UpdateStatus.Text = "Обновление отменено";
            ProgressPercent.Value = 0;
        }

        private async void TestConnect_Click(object sender, EventArgs e)
        {
            string serverAddress = ServerAddress.Text;
            string sshLogin = sshlog.Text;
            string sshPassword = sshp.Text;

            // Проверка на пустые строки
            if (string.IsNullOrWhiteSpace(serverAddress))
            {
                UpdateUI(() =>
                {
                    UpdateStatus.Text = "Ошибка: IP-адрес не указан.";
                    OverallStatus.AppendText("Ошибка: IP-адрес не указан.\n");
                });
                return;
            }

            if (string.IsNullOrWhiteSpace(sshLogin))
            {
                UpdateUI(() =>
                {
                    UpdateStatus.Text = "Ошибка: Логин SSH не указан.";
                    OverallStatus.AppendText("Ошибка: Логин SSH не указан.\n");
                });
                return;
            }

            if (string.IsNullOrWhiteSpace(sshPassword))
            {
                UpdateUI(() =>
                {
                    UpdateStatus.Text = "Ошибка: Пароль SSH не указан.";
                    OverallStatus.AppendText("Ошибка: Пароль SSH не указан.\n");
                });
                return;
            }

            try
            {
                // Обновляем статус подключения
                UpdateUI(() => UpdateStatus.Text = "Подключаюсь...");
                OverallStatus.AppendText($"Пытаюсь подключиться к {serverAddress}...\n");

                var connectionTask = Task.Run(() =>
                {
                    using (var client = new SshClient(serverAddress, sshLogin, sshPassword))
                    {
                        client.Connect();
                        if (client.IsConnected)
                        {
                            var unameResult = client.RunCommand("uname -a");
                            return unameResult.Result;
                        }
                        else
                        {
                            throw new Exception("Не удалось подключиться к серверу.");
                        }
                    }
                });

                string result = await connectionTask;

                // Обновляем интерфейс после успешного подключения
                UpdateUI(() =>
                {
                    OverallStatus.AppendText($"Результат: {result}\n");
                    UpdateStatus.Text = "Коннект прошел!";
                });
            }
            catch (Exception ex)
            {
                // Обновляем интерфейс в случае ошибки
                UpdateUI(() =>
                {
                    UpdateStatus.Text = "Ой, я не соединился";
                    OverallStatus.AppendText($"Ошибка: {ex.Message}\n");
                });
            }
        }

        // Метод для безопасного обновления интерфейса
        private void UpdateUI(Action action)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private async void startupdate_Click(object sender, EventArgs e)
        {
            _isCancelled = false;
            ProgressPercent.Value = 0;
            UpdateStatus.Text = "Начинаю обновление";

            string serverAddress = ServerAddress.Text;
            string sshLogin = sshlog.Text;
            string sshPassword = sshp.Text;
            string serverArchive = ServerArchive.Text;
            string webArchive = WebArchive.Text;

            try
            {
                using (var client = new SshClient(serverAddress, sshLogin, sshPassword))
                {
                    client.Connect();
                    if (!client.IsConnected)
                    {
                        throw new Exception("Не удалось подключиться к серверу.");
                    }

                    // Шаг 1: Создание директорий
                    await ExecuteCommandAsync(client, "mkdir -p /home/ms_gubin/update/server_p");
                    await ExecuteCommandAsync(client, "mkdir -p /home/ms_gubin/update/web_p");

                    // Шаг 2: Распаковка архива серверной части
                    await ExecuteCommandAsync(client, $"tar -xzf {serverArchive}.tar.gz -C /home/ms_gubin/update/server_p");

                    // Шаг 3: Удаление appsettings.json и копирование файлов
                    await ExecuteCommandAsync(client, "cd /home/ms_gubin/update/server_p && sudo find . -type f -name 'appsettings.json' -delete");
                    await ExecuteCommandAsync(client, "sudo cp -r /home/ms_gubin/update/server_p/* /f3tailweb");

                    // Шаг 4: Распаковка архива веб-части
                    await ExecuteCommandAsync(client, $"unzip {webArchive}.zip -d /home/ms_gubin/update/web_p");

                    // Шаг 5: Удаление env.js и копирование файлов
                    await ExecuteCommandAsync(client, "cd /home/ms_gubin/update/web_p/web/build && sudo find . -type f -name 'env.js' -delete");
                    await ExecuteCommandAsync(client, "sudo rm -rf /var/www/html/*");
                    await ExecuteCommandAsync(client, "sudo cp -r /home/ms_gubin/update/web_p/web/build/* /var/www/html");

                    // Обновление прогресса
                    UpdateProgress(100);

                    UpdateStatus.Text = "Обновление завершено успешно!";
                }
            }
            catch (OperationCanceledException)
            {
                UpdateStatus.Text = "Обновление отменено пользователем.";
            }
            catch (Exception ex)
            {
                UpdateStatus.Text = "Ошибка. Отменяю обновление";
                OverallStatus.AppendText($"Ошибка: {ex.Message}\n");
            }
            finally
            {
                ProgressPercent.Value = 0;
            }
        }

        // Асинхронное выполнение команды SSH
        private async Task ExecuteCommandAsync(SshClient client, string command)
        {
            if (_isCancelled) throw new OperationCanceledException("Обновление отменено пользователем.");

            // Выполняем команду в фоновом потоке
            var result = await Task.Run(() =>
            {
                var cmdResult = client.RunCommand(command);
                return new { Output = cmdResult.Result, Error = cmdResult.Error };
            });

            // Выводим результат в интерфейс
            OverallStatus.AppendText($"Выполняю: {command}\n");
            OverallStatus.AppendText($"Результат: {result.Output}\n");

            if (!string.IsNullOrEmpty(result.Error))
            {
                OverallStatus.AppendText($"Ошибка: {result.Error}\n");
                throw new Exception(result.Error);
            }
        }

        private void UpdateProgress(int percent)
        {
            if (percent > ProgressPercent.Maximum) percent = ProgressPercent.Maximum;
            ProgressPercent.Value = percent;
        }
    }
}
