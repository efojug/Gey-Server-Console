using Panuon.UI.Silver;

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
            if (!string.IsNullOrWhiteSpace(username.Text) && !string.IsNullOrWhiteSpace(password.Password))
            {
                username.Visibility = System.Windows.Visibility.Hidden;
                password.Visibility = System.Windows.Visibility.Hidden;
                login.Visibility = System.Windows.Visibility.Hidden;
                un.Visibility = System.Windows.Visibility.Hidden;
                pw.Visibility = System.Windows.Visibility.Hidden;
                SelectGameVersion.Visibility = System.Windows.Visibility.Visible;
                launch.Visibility = System.Windows.Visibility.Visible;
                MessageBoxX.Show("本程序还在测试阶段\n 请勿用于生产环境\n 请勿泄露给任何人", "警告");
            } 
            else
            {
                MessageBoxX.Show("请输入用户名和密码");
            }
        }
    }
}
