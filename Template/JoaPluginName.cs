using JoaLauncher.Api;
using JoaLauncher.Api.Injectables;
using JoaLauncher.Api.Plugin;

namespace JoaPluginName;

public class JoaPluginName : IPlugin
{
    private readonly IJoaLogger _joaLogger;

    public JoaPluginName(IJoaLogger joaLogger)
    {
        _joaLogger = joaLogger;
    }
    
    public void ConfigurePlugin(IPluginBuilder builder)
    {
        builder.AddGlobalResult(new DefaultSearchResult
        {
            Title = "JoaPluginName",
            Description = "A Global Search Result from JoaPluginName",
            Icon = "DefaultIcon",
            ExecutionAction = _ => _joaLogger.Info("Executing JoaPluginName")
        });
    }
}
