﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Plugin;
/// <summary>
/// 插件抽象基类。
/// </summary>
public abstract class PluginBase
{
    /// <summary>
    /// 当前插件的设置目录。插件的各项设置应当存放在此目录中。
    /// </summary>
    public string PluginConfigFolder { get; internal set; } = "";

    /// <summary>
    /// 当前插件的信息
    /// </summary>
    public PluginInfo Info { get; internal set; } = null!;

    /// <summary>
    /// 初始化插件。一般在这个方法中完成插件的各项服务的注册。
    /// </summary>
    /// <param name="context"></param>
    /// <param name="services"></param>
    public abstract void Initialize(HostBuilderContext context, IServiceCollection services);
}
