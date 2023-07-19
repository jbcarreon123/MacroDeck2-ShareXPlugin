// got from PiHole Plugin by SuchByte and modified it.

using jbcarreon123.ShareXPlugin.Languages;
using SuchByte.MacroDeck.Language;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

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

        public static void UpdateLang(string lang)
        {
            PluginConfiguration.SetValue(Main.Instance, "lang", lang);
        }

        public static string GetLang()
        {
            var allCultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            var lang = PluginConfiguration.GetValue(Main.Instance, "lang");
            var mdlang = LanguageManager.GetLanguageName();

            if (string.IsNullOrWhiteSpace(lang))
            {
                if (PluginLanguageManager.Languages.Contains(mdlang))
                {
                    return mdlang;
                }
                else
                {
                    return "English";
                }
            }
            return lang;
        }
    }
}