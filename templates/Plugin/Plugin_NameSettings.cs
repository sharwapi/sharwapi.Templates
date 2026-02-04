namespace Plugin_Author.Plugin.Plugin_Name;

/// <summary>
/// 插件的配置类
/// </summary>
public class Plugin_NameSettings
{
    // 一条 String 类的配置项
    public string Message { get; set; } = "Hello World";
    
    // 一条 Bool 类的配置项
    public bool EnableFeature { get; set; } = true;
    
    // 一条 Int 类的配置项
    public int MaxRetries { get; set; } = 3;

    // 一条 List 类的配置项
    public List<string> Tags { get; set; } = new() { "Tag1", "Tag2" };
}