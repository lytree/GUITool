using App.ViewModels;
using App.Views;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;

namespace App
{
    public partial class App : Application
    {



        public static readonly string AppRootFolderPath = AppDomain.CurrentDomain.BaseDirectory;

        public static readonly string AppLogFolderPath = Path.Combine(AppRootFolderPath, "Logs");

        public static readonly string AppDataFolderPath = Path.Combine(AppRootFolderPath, "Data");

        public static readonly string AppConfigPath = Path.Combine(AppRootFolderPath, "Config");

        public static readonly string AppCacheFolderPath = Path.Combine(AppRootFolderPath, "Cache");

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                // Avoid duplicate validations from both Avalonia and the CommunityToolkit. 
                // More info: https://docs.avaloniaui.net/docs/guides/development-guides/data-validation#manage-validationplugins
                DisableAvaloniaDataAnnotationValidation();
                desktop.MainWindow = new MvvmSplashWindow
                {
                    DataContext = new SplashViewModel(),
                };
            }
            else if (ApplicationLifetime is ISingleViewApplicationLifetime singleView)
            {
                singleView.MainView = new SingleView()
                {
                    DataContext = new MainViewViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }

        private void DisableAvaloniaDataAnnotationValidation()
        {
            // Get an array of plugins to remove
            var dataValidationPluginsToRemove =
                BindingPlugins.DataValidators.OfType<DataAnnotationsValidationPlugin>().ToArray();

            // remove each entry found
            foreach (var plugin in dataValidationPluginsToRemove)
            {
                BindingPlugins.DataValidators.Remove(plugin);
            }
        }
    }
}