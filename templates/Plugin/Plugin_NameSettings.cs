namespace Plugin_Author.Plugin.Plugin_Name;

/// <summary>
/// 插件的配置类
/// Plugin configuration class
/// </summary>
public class Plugin_NameSettings
{
    // 一条 String 类型的配置项
    // A string configuration property
    public string Message { get; set; } = "Hello World";
    
    // 一条 Bool 类型的配置项
    // A boolean configuration property
    public bool EnableFeature { get; set; } = true;
    
    // 一条 Int 类型的配置项
    // An integer configuration property
    public int MaxRetries { get; set; } = 3;

    // 一条 List 类型的配置项
    // A list configuration property
    public List<string> Tags { get; set; } = new() { "Tag1", "Tag2" };
}