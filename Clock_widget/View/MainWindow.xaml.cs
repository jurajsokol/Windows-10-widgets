using System.Windows;
using System.Windows.Input;

namespace Clock_widget.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int PADDING = 10;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            { 
                this.DragMove();
            }
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            while (true)
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
                this.digitalClock.Text = DateTime.Now.ToString("HH:mm:ss");
                this.dateClock.Text = DateTime.Now.ToString("dd. MMMMM");
            }
        }
    }
}
