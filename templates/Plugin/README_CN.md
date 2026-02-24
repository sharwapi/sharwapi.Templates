# Plugin_Name

[简体中文](README_CN.md) | [English](README.md)

这是一个基于 SharwAPI 的插件项目。

- **作者**: Plugin_Author
- **框架**: .NET 10.0

## 目录结构

- `Plugin.cs`: 插件的主入口，在这里注册服务和路由。
- `Plugin_NameSettings.cs`: 在这里定义插件的配置项。

## 开发指南

1. 在 `Plugin_NameSettings.cs` 中添加你需要的配置属性。
2. 在 `Plugin.cs` 的 `RegisterServices` 中注入你的服务。
3. 在 `Plugin.cs` 的 `RegisterRoutes` 中注册你的 API 路由。
4. 在 `Plugin.cs` 的 `Configure` 中添加中间件（如有需要）。
5. 编译并发布到插件目录。

## 注意事项

本项目依赖私有源 `nuget.hope-now.top`，请确保 `nuget.config` 配置正确。