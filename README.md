# SharwAPI Plugin Templates

[简体中文](README_CN.md) | [English](README.md)

This is the official project template for SharwAPI plugin development.

## Installation

Ensure that you have configured the private NuGet source, then run the following command to install the templates:

```bash
dotnet new install sharwapi.Templates --nuget-source https://nuget.hope-now.top/v3/index.json

```

## Usage

Once installed, use the following command to quickly create a new plugin project:

```bash
# Basic usage
dotnet new sharwplugin -n PluginName --Author AuthorName

# View help
dotnet new sharwplugin --help

```

## Parameters

| Option | Short | Description | Required |
| --- | --- | --- | --- |
| --name | -n | Plugin name (e.g., Chat) | ✅ Yes |
| --Author |  | Plugin author name (e.g., Seven) | ✅ Yes |