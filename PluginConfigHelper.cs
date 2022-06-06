// got from PiHole Plugin by SuchByte and modified it.

using SuchByte.MacroDeck.Plugins;
using System;

namespace jbcarreon123.ShareXPlugin
{
    public class PluginConfigHelper
    {

        public static void UpdatePath(string path)
        {
            PluginConfiguration.SetValue(Main.Instance, "path", path);
        }

        public static string GetPath()
        {
            var path = PluginConfiguration.GetValue(Main.Instance, "path");
            if (string.IsNullOrWhiteSpace(path))
            {
                path = "C:\\Program Files\\ShareX\\";
            }
            return path;
        }


    }
}