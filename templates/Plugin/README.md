# Plugin_Name

[简体中文](README_CN.md) | [English](README.md)

This is a SharwAPI-based plugin project.

- **Author**: Plugin_Author
- **Framework**: .NET 10.0

## Directory Structure

- `Plugin.cs`: The main entry point of the plugin. Register services and routes here.
- `Plugin_NameSettings.cs`: Define the plugin configuration options here.

## Development Guide

1. Add your required configuration properties in `Plugin_NameSettings.cs`.
2. Inject your services in the `RegisterServices` method within `Plugin.cs`.
3. Register your API routes in the `RegisterRoutes` method within `Plugin.cs`.
4. Add any middleware in the `Configure` method within `Plugin.cs` (if needed).
5. Build and publish the project to the plugin directory.

## Important Notes

This project depends on the private NuGet source `nuget.hope-now.top`. Please ensure `nuget.config` is correctly configured.
