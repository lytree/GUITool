using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Plugin;

/// <summary>
/// 插件依赖信息
/// </summary>
public class PluginDependency
{
    /// <summary>
    /// 依赖插件 ID
    /// </summary>
    public string Id { get; set; } = "";

    /// <summary>
    /// 是否是必选依赖
    /// </summary>
    public bool IsRequired { get; set; } = true;
}