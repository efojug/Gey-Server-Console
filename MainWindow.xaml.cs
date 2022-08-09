using Panuon.UI.Silver;
using System.Collections.Generic;
using System;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;

namespace GeyServerConsole
{
    public partial class MainWindow : WindowX
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void login_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            List<string> versionList = new List<string>
            {
                "1.16.5",
                "1.18.2",
                "1.19",
                "1.20.2 (Internal Test)"
            };
            if (!string.IsNullOrWhiteSpace(username.Text) && !string.IsNullOrWhiteSpace(password.Password))
            {
                username.Visibility = System.Windows.Visibility.Collapsed;
                password.Visibility = System.Windows.Visibility.Collapsed;
                login.Visibility = System.Windows.Visibility.Collapsed;
                un.Visibility = System.Windows.Visibility.Collapsed;
                pw.Visibility = System.Windows.Visibility.Collapsed;
                ver.Visibility = System.Windows.Visibility.Collapsed;
                welcome.Visibility = System.Windows.Visibility.Collapsed;
                SelectGameVersion.Visibility = System.Windows.Visibility.Visible;
                launch.Visibility = System.Windows.Visibility.Visible;
                SelectGameVersion.ItemsSource = versionList;
                log.Visibility = System.Windows.Visibility.Visible;
                MessageBoxX.Show("本程序还在测试阶段\n 请勿用于生产环境\n 请勿泄露给任何人", "警告");
            } 
            else
            {
                MessageBoxX.Show("请输入用户名和密码");
            }
        }
        public void Llog()
        {
            string error = "";
            while (true)
            {
                try
                {
                    error += new NullReferenceException().Message + "\n ";
                    error += Math.Pow(new Random().Next(int.MinValue, int.MaxValue), new Random().Next(int.MinValue, int.MaxValue)).ToString() + "\n ";
                    log.Text = error;
                } catch (Exception sb)
                {
                    error += sb.Message + "\n ";
                }
            }
        }
        private void launch_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (SelectGameVersion.SelectedItem != null)
            {
                for (int i = 0; i <= 20; i++)
                {
                    new Thread(new ThreadStart(Llog)).Start();
                }
            } else
                MessageBoxX.Show("请选择游戏版本");
            }
        }
    }
}
