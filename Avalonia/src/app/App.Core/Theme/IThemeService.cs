using App.Core.Models.Theme;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Theme;


/// <summary>
/// 应用主题服务，控制应用的主题外观。
/// </summary>
public interface IThemeService
{
    /// <summary>
    /// Gets the current operating system theme.
    /// </summary>
    AvailableApplicationTheme CurrentSystemTheme { get; }

    /// <summary>
    /// Gets the current app theme defined in the app settings.
    /// </summary>
    AvailableApplicationTheme CurrentAppTheme { get; }

    /// <summary>
    /// Gets the actual theme applied in the app.
    /// </summary>
    ApplicationTheme ActualAppTheme { get; }

    /// <summary>
    /// Gets a value indicating whether the current theme is high contrast.
    /// </summary>
    bool IsHighContrast { get; }

    /// <summary>
    /// Gets a value indicating whether the UI should be in compact mode.
    /// </summary>
    bool IsCompactMode { get; }

    /// <summary>
    /// Gets a value indicating whether the customer wish to be in compact mode.
    /// </summary>
    bool UserIsCompactModePreference { get; }

    /// <summary>
    /// Gets a value indicating whether the app should use less animations.
    /// </summary>
    bool UseLessAnimations { get; }

    /// <summary>
    /// Raised when the theme has changed.
    /// </summary>
    event EventHandler? ThemeChanged;

    /// <summary>
    /// Change the color theme of the app based on <see cref="CurrentSystemTheme"/> and <see cref="CurrentAppTheme"/>.
    /// </summary>
    void ApplyDesiredColorTheme();
}