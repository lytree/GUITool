using App.Api;

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
