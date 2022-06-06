/* Some parts of this class are based on @PhoenixWyllow's implementation of translation files, he's using in the Soundboard4MacroDeck2 plugin
 * The link to the original file: https://github.com/PhoenixWyllow/Soundboard4MacroDeck2/blob/main/Services/Localization.cs
 */

using SuchByte.MacroDeck.Language;
using SuchByte.MacroDeck.Logging;
using jbcarreon123.ShareXPlugin.Languages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;


namespace jbcarreon123.ShareXPlugin.Languages
{
    public static class PluginLanguageManager
    {
        public static PluginStrings PluginStrings = new PluginStrings();

        public static void Initialize()
        {
            LoadLanguage();
            LanguageManager.LanguageChanged += (s, e) => LoadLanguage();
        }

        private static void LoadLanguage()
        {
            // Getting the current language that is set in Macro Deck
            string languageName = LanguageManager.GetLanguageName();

            try
            {
                PluginStrings = JsonSerializer.Deserialize<PluginStrings>(GetJsonLanguageResource(languageName));
            }
            catch (Exception ex)
            {
                //fallback - should never occur if things are done properly
                PluginStrings = new PluginStrings();
                MacroDeckLogger.Trace(Main.Instance, "Failed to load language: " + ex.Message);
            }
        }

        private static string GetJsonLanguageResource(string languageName)
        {
            var assembly = typeof(PluginStrings).Assembly;
            if (string.IsNullOrEmpty(languageName)
                || !assembly.GetManifestResourceNames().Any(name => name.EndsWith($"{languageName}.json")))
            {
                languageName = "English"; //This should always be present as default, otherwise the code goes to fallback implementation.
            }

            string languageFileName = $"jbcarreon123.ShareXPlugin.Resources.Languages.{languageName}.json";

            using var resourceStream = assembly.GetManifestResourceStream(languageFileName);
            using var streamReader = new StreamReader(resourceStream);
            return streamReader.ReadToEnd();
        }
    }
}