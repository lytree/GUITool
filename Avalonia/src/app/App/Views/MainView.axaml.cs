using App.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Ursa.Controls;

namespace App.Views;

public partial class MainView : UserControl
{

    private MainViewViewModel? _viewModel;
    public MainView()
    {
        InitializeComponent();
    }

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);
        _viewModel = DataContext as MainViewViewModel;
        var topLevel = TopLevel.GetTopLevel(this);
        if (topLevel is null || _viewModel is null)
            return;
        _viewModel.NotificationManager = WindowNotificationManager.TryGetNotificationManager(topLevel, out var manager)
            ? manager
            : new WindowNotificationManager(topLevel);
    }
}