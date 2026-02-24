using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sharwapi.Contracts.Core;

namespace Plugin_Author.Plugin.Plugin_Name;

public class Plugin_NamePlugin : IApiPlugin
{
    // 插件名称
    // Plugin unique identifier name
    public string Name => "Plugin_Author.Plugin_Name";
    // 插件显示名称（人类可读，如 "My Awesome Plugin"）
    // Display name (human-readable, e.g. "My Awesome Plugin")
    public string DisplayName => "";
    // 插件版本
    // Plugin version
    public string Version => "0.1.0";

    // 依赖信息 (Key: 依赖插件名称, Value: 版本要求（例如 "1.0.0", "[1.0, 2.0)", "*"等）)
    // Dependencies (Key: plugin name, Value: version requirement e.g. "1.0.0", "[1.0, 2.0)", "*")
    public IReadOnlyDictionary<string, string> Dependencies => new Dictionary<string, string>
    {
        // 示例: { "another_plugin", "1.0.0" }
        // Example: { "another_plugin", "1.0.0" }
    };

    // 启用自动路由前缀
    // Enable automatic route prefix
    public bool UseAutoRoutePrefix => true;

    // 插件服务注册方法
    // Register plugin services into the DI container
    public void RegisterServices(IServiceCollection services, IConfiguration configuration)
    {
        
    }

    // 插件中间件配置方法
    // Configure HTTP request pipeline middleware
    public void Configure(WebApplication app)
    {
        
    }

    // 插件路由注册方法 / Register plugin API routes
    public void RegisterRoutes(IEndpointRouteBuilder app, IConfiguration configuration)
    {
        
    }

    // 默认配置
    // Default configuration object
    public object? DefaultConfig => new Plugin_NameSettings
    {
        // 留空使用 Plugin_NameSettings.cs 里的默认值
        // Leave empty to use defaults from Plugin_NameSettings.cs
    };
}
