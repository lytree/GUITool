using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Plugin;

/// <summary>
/// 表示插件加载状态。
/// </summary>
public enum PluginLoadStatus
{
    /// <summary>
    /// 插件未加载
    /// </summary>
    NotLoaded,
    /// <summary>
    /// 插件成功加载。
    /// </summary>
    Loaded,
    /// <summary>
    /// 插件已禁用。
    /// </summary>
    Disabled,
    /// <summary>
    /// 插件加载时出现错误。
    /// </summary>
    Error,
}