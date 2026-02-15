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
    public string Name => "Plugin_Author.Plugin_Name";
    // 插件显示名称
    public string DisplayName => "";
    // 插件版本
    public string Version => "0.1.0";

    // 依赖信息 (Key: 依赖插件名称, Value: 版本要求（例如 "1.0.0", "[1.0, 2.0)", "*"等）)
    public IReadOnlyDictionary<string, string> Dependencies => new Dictionary<string, string>
    {
        // 示例: { "another_plugin", "1.0.0" }
    };

    // 启用自动路由前缀
    public bool UseAutoRoutePrefix => true;

    // 插件注册服务方法
    public void RegisterServices(IServiceCollection services, IConfiguration configuration)
    {
        
    }

    // 默认配置
    public object? DefaultConfig => new Plugin_NameSettings
    {
        // 留空使用 Plugin_NameSettings.cs 里的默认值
    };

    // 插件中间件配置方法
    public void Configure(WebApplication app)
    {
        
    }

    // 插件路由注册方法
    public void RegisterRoutes(IEndpointRouteBuilder app, IConfiguration configuration)
    {
        
    }
}
