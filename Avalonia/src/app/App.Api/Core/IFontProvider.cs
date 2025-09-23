using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Api;

/// <summary>
/// Provides a platform agnostic way to retrieve information about fonts installed on the operating system.
/// </summary>
public interface IFontProvider
{
    /// <summary>
    /// Retrieves the list of font families available on the operating system.
    /// </summary>
    string[] GetFontFamilies();
}
