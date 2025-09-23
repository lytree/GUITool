using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Models.Theme;


public class ThemeUpdatedEventArgs
{
    public int ThemeMode = 0;
    public Color Primary;
    public Color Secondary;
    public int RealThemeMode = 0;
}