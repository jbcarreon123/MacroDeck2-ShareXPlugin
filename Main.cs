using System;
using System.IO;
using SuchByte.MacroDeck;
using System.Collections.Generic;
using SuchByte.MacroDeck.Plugins;
using jbcarreon123.ShareXPlugin.GUI;
using jbcarreon123.ShareXPlugin.Actions;
using jbcarreon123.ShareXPlugin.Languages;
using SuchByte.MacroDeck.Logging;

// jbcarreon123.ShareXPlugin
// ShareX Plugin for Macro Deck

namespace jbcarreon123.ShareXPlugin
{

    public static class PluginInstance
    {
        public static Main Main { get; set; }
    }

    public class Main : MacroDeckPlugin
    {
        public override bool CanConfigure => true;

        public static Main Instance;

        public Main()
        {
            //Instance = this; // does not exist in the current context
            PluginInstance.Main = this;
        }

        private void MacroDeck_OnMainWindowLoad(object sender, EventArgs e)
        {
            int apiver = MacroDeck.PluginApiVersion;
            if (apiver >= 22)
            {
                MacroDeckLogger.Trace(PluginInstance.Main, $"Plugin API: {apiver}");
            } 
            else
            {
                MacroDeckLogger.Warning(PluginInstance.Main, $"Plugin API version {apiver} is not recognized. You may expierence issues.");
            }
            string pathf = PluginConfigHelper.GetPath();
            if (!File.Exists(pathf + "\\ShareX.exe"))
            {
                MacroDeckLogger.Error(PluginInstance.Main, $"Error: Can't find ShareX.exe on path {pathf}. ");
                //return;
            }
        }

        public override void Enable()
        {
            Instance ??= this;
            PluginLanguageManager.Initialize();
            string pathf = PluginConfigHelper.GetPath();
            if (!File.Exists(pathf + "\\ShareX.exe"))
            {
                MacroDeckLogger.Error(PluginInstance.Main, $"Error: Can't find ShareX.exe on path {pathf}. ");
                //return;
            }
            this.Actions = new List<PluginAction>
            {
				// Alphabetical order.
                new AbortScreenRecordingAction(),
                new ActiveMonitorAction(),
                new ActiveWindowAction(),
                new AutoCaptureAction(),
                new BorderlessWindowAction(),
                new ClipboardUploadAction(),
                new ClipboardUploadWithContentViewerAction(),
                new ClipboardViewerAction(),
                new ColorPickerAction(),
                new CustomRegionAction(),
                new DNSChangerAction(),
                new DisableHotkeysAction(),
                new DragDropUploadAction(),
                new ExitShareXAction(),
                new FileUploadAction(),
                new FolderUploadAction(),
                new HashCheckAction(),
                new ImageCombinerAction(),
                new ImageEditorAction(),
                new ImageEffectsAction(),
                new ImageSplitterAction(),
                new ImageThumbnailerAction(),
                new ImageViewerAction(),
                new IndexFolderAction(),
                new InspectWindowAction(),
                new LastRegionAction(),
                new MonitorTestAction(),
                new OCRAction(),
                new OpenHistoryAction(),
                new OpenImageHistoryAction(),
                new OpenMainWindowAction(),
                new OpenScreenshotsFolderAction(),
                new PauseScreenRecordingAction(),
                new PrintScreenAction(),
                new QRCodeAction(),
                new QRCodeDecodeFromScreenAction(),
                new RectangleLightAction(),
                new RectangleRegionAction(),
                new RectangleTransparentAction(),
                new RulerAction(),
                new ScreenColorPickerAction(),
                new ScreenRecorderAction(),
                new ScreenRecorderActiveWindowAction(),
                new ScreenRecorderCustomRegionAction(),
                new ScreenRecorderGIFAction(),
                new ScreenRecorderGIFActiveWindowAction(),
                new ScreenRecorderGIFCustomRegionAction(),
                new ScrollingCaptureAction(),
                new ShortenURLAction(),
                new StartAutoCaptureAction(),
                new StartScreenRecorderAction(),
                new StartScreenRecorderGIFAction(),
                new StopScreenRecordingAction(),
                new StopUploadsAction(),
                new ToggleActionsToolbarAction(),
                new ToggleTrayMenuAction(),
                new TweetMessageAction(),
                new UploadTextAction(),
                new UploadURLAction(),
                new VideoConverterAction(),
                new VideoThumbnailerAction()
            };
        }
        public override void OpenConfigurator()
        {
            using (var pluginConfig = new PluginConfig())
            {
                pluginConfig.ShowDialog();
            }
        }
    }
}