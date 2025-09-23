

using App.Api;
using App.Api.Tool;

namespace App.Localization;

[Export(typeof(IResourceAssemblyIdentifier))]
[Name(nameof(DevToysLocalizationResourceManagerAssemblyIdentifier))]
public sealed class DevToysLocalizationResourceManagerAssemblyIdentifier : IResourceAssemblyIdentifier
{
    public ValueTask<FontDefinition[]> GetFontDefinitionsAsync()
    {
        throw new NotImplementedException();
    }
}
