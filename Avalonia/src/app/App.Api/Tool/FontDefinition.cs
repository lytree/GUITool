using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Api.Tool;


/// <summary>
/// Represents a font definition.
/// </summary>
public sealed class FontDefinition : IDisposable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FontDefinition"/> class.
    /// </summary>
    /// <param name="fontFamily">The font family.</param>
    /// <param name="fontReader">The stream to read the font file.</param>
    public FontDefinition(string fontFamily, Stream fontReader)
    {
        FontFamily = fontFamily;
        FontReader = fontReader;
    }

    /// <summary>
    /// Gets the font family.
    /// </summary>
    public string FontFamily { get; }

    /// <summary>
    /// Gets the stream to read the font file.
    /// </summary>
    public Stream FontReader { get; }

    /// <summary>
    /// Disposes the font reader.
    /// </summary>
    public void Dispose()
    {
        FontReader?.Dispose();
    }
}
