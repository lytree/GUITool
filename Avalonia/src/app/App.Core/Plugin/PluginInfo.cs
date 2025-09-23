﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Core.Plugin;


/// <summary>
/// 插件信息
/// </summary>
public class PluginInfo : ObservableRecipient
{
    private bool _isAvailableOnMarket = false;
    private PluginManifest _manifest = new();
    private bool _restartRequired = false;
    private bool _isUpdateAvailable = false;
    private long _downloadCount = 0;
    private long _starsCount = 0;

    /// <summary>
    /// 插件元数据
    /// </summary>
    public PluginManifest Manifest
    {
        get => _manifest;
        set
        {
            if (Equals(value, _manifest)) return;
            _manifest = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// 插件是否存在于本地
    /// </summary>
    [JsonIgnore]
    public bool IsLocal { get; internal set; } = false;

    /// <summary>
    /// 插件是否已启用
    /// </summary>
    [JsonIgnore]
    public bool IsEnabled
    {
        get
        {
            if (!IsLocal)
                return false;
            return !File.Exists(Path.Combine(PluginFolderPath, ".disabled"));
        }
        set
        {
            if (!IsLocal)
                throw new InvalidOperationException("无法为不存在本地的插件设置启用状态。");
            var path = Path.Combine(PluginFolderPath, ".disabled");
            RestartRequired = true;
            if (value)
            {
                File.Delete(path);
            }
            else
            {
                File.WriteAllText(path, "");
            }
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// 插件是否将要卸载
    /// </summary>
    [JsonIgnore]
    public bool IsUninstalling
    {
        get
        {
            if (!IsLocal)
                return false;
            return File.Exists(Path.Combine(PluginFolderPath, ".uninstall"));
        }
        set
        {
            if (!IsLocal)
                throw new InvalidOperationException("无法为不存在本地的插件设置将要卸载状态。");
            var path = Path.Combine(PluginFolderPath, ".uninstall");
            if (value)
            {
                File.WriteAllText(path, "");
            }
            else
            {
                File.Delete(path);
            }
            OnPropertyChanged();
        }
    }


    /// <summary>
    /// 插件文件路径。
    /// </summary>
    [JsonIgnore]
    public string PluginFolderPath { get; internal set; } = "";

    /// <summary>
    /// 图标真实路径
    /// </summary>
    public string RealIconPath { get; set; } = "";

    /// <summary>
    /// 插件加载时错误
    /// </summary>
    [JsonIgnore]
    public Exception? Exception { get; internal set; }

    /// <summary>
    /// 插件加载状态
    /// </summary>
    [JsonIgnore]
    public PluginLoadStatus LoadStatus { get; internal set; } = PluginLoadStatus.NotLoaded;


    /// <summary>
    /// 是否在插件市场上可用
    /// </summary>
    [JsonIgnore]
    public bool IsAvailableOnMarket
    {
        get => _isAvailableOnMarket;
        set
        {
            if (value == _isAvailableOnMarket) return;
            _isAvailableOnMarket = value;
            OnPropertyChanged();
        }
    }


    /// <summary>
    /// 需要重启
    /// </summary>
    [JsonIgnore]
    public bool RestartRequired
    {
        get => _restartRequired;
        set
        {
            if (value == _restartRequired) return;
            _restartRequired = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// 插件是否有更新可用。
    /// </summary>
    [JsonIgnore]
    public bool IsUpdateAvailable
    {
        get => _isUpdateAvailable;
        set
        {
            if (value == _isUpdateAvailable) return;
            _isUpdateAvailable = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// 插件下载量
    /// </summary>
    public long DownloadCount
    {
        get => _downloadCount;
        set
        {
            if (value == _downloadCount) return;
            _downloadCount = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// 插件 Stars 数量
    /// </summary>
    public long StarsCount
    {
        get => _starsCount;
        set
        {
            if (value == _starsCount) return;
            _starsCount = value;
            OnPropertyChanged();
        }
    }
}