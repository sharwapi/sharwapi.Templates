# SharwAPI Plugin Templates

[简体中文](/README_CN.md) | [English](/README.md)

这是 SharwAPI 插件开发的官方项目模板。

## 如何安装

请确保您已配置好私有 NuGet 源，然后运行以下命令安装模板：

```bash
dotnet new install sharwapi.Templates --nuget-source https://nuget.hope-now.top/v3/index.json
```

## 如何使用

安装完成后，使用以下命令快速创建一个插件项目：

```bash
# 基本用法
dotnet new sharwapiplugin -n PluginName --Author AuthorName

# 查看帮助
dotnet new sharwapiplugin --help

```

## 参数说明

| 参数 | 简写 | 描述 | 是否必填 |
| --- | --- | --- | --- |
| --name | -n | 插件名称 (如 Chat) | ✅ 是 |
| --Author |  | 插件作者名称 (如 Seven) | ✅ 是 |
