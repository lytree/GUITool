using App.Core.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Plugins;

public record class DependencyNode(PluginInfo Plugin)
{
    public PluginInfo Plugin { get; set; } = Plugin;

    public int DependencyTreeDepth { get; set; } = 0;

    public bool IsDiscovered { get; set; } = false;
}