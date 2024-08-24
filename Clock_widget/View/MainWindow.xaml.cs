using System.Windows;

namespace Clock_widget.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int PADDING = 5;

        DateTime localDate = DateTime.Now;

        public MainWindow()
        {
            InitializeComponent();

            this.ShowInTaskbar = false;
            this.Left = SystemParameters.PrimaryScreenWidth - this.Width - PADDING;
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer(new TimeSpan(0, 0, 1), System.Windows.Threading.DispatcherPriority.Normal, delegate
            {
                this.digitalClock.Text = DateTime.Now.ToString("HH:mm");
            }, this.Dispatcher);
            System.Windows.Threading.DispatcherTimer date = new System.Windows.Threading.DispatcherTimer(new TimeSpan(0, 0, 1), System.Windows.Threading.DispatcherPriority.Normal, delegate
            {
                this.dateClock.Text = DateTime.Now.ToString("dd. MMMMM");
            }, this.Dispatcher);
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
