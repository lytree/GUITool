using Avalonia.Controls;
using Ursa.Controls;

namespace App.Views
{
    public partial class MainWindow : UrsaWindow
    {
        public WindowNotificationManager? NotificationManager { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            NotificationManager = new WindowNotificationManager(this) { MaxItems = 3 };
        }
        protected override async Task<bool> CanClose()
        {

            var result = await MessageBox.ShowOverlayAsync("Are you sure you want to exit?\n��ȷ��Ҫ�˳���", "Exit", button: MessageBoxButton.YesNo);
            return result == MessageBoxResult.Yes;
        }
    }
}