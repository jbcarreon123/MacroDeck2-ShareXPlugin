// This C# file is created by jbcarreon123's C# Generator batch file.

using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.Plugins;
using jbcarreon123.ShareXPlugin.Languages;
using System.Diagnostics;

namespace jbcarreon123.ShareXPlugin.Actions
{
    public class ScreenRecorderGIFActiveWindowAction : PluginAction
    {
        public override string Name => PluginLanguageManager.PluginStrings.ScreenRecorderGIFActiveWindowAction;

        public override string Description => PluginLanguageManager.PluginStrings.ScreenRecorderGIFActiveWindowActionDescription;

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            string path = PluginConfigHelper.GetPath();
            Process.Start(path + "ShareX.exe", "-ScreenRecorderGIFActiveWindow");
        }
    }
}
