using App.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Ursa.Controls;

namespace App.Views;

public partial class MvvmSplashWindow : SplashWindow
{
    public MvvmSplashWindow()
    {
        InitializeComponent();
    }
    protected override Task<Window?> CreateNextWindow()
    {
        if (this.DialogResult is true)
        {
            return Task.FromResult<Window?>(new MainWindow()
            {
                DataContext = new MainViewViewModel()
            });
        }
        return Task.FromResult<Window?>(null);
    }
}