using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Plugin;

/// <summary>
/// 描述插件的属性
/// </summary>
/// <inheritdoc />
[AttributeUsage(AttributeTargets.Class)]
public class PluginEntrance : Attribute;
