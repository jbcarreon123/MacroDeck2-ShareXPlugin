using System;
using SuchByte.MacroDeck;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using SuchByte.MacroDeck.Plugins;
using jbcarreon123.ShareXPlugin.Languages;
using SuchByte.MacroDeck.Language;
using SuchByte.MacroDeck.Logging;
using SuchByte.MacroDeck.GUI.CustomControls;
using System.Runtime.InteropServices;

namespace jbcarreon123.ShareXPlugin.GUI
{
    public partial class PluginConfig : DialogForm
    {
        public MacroDeckPlugin IMacroDeckPlugin { get; private set; }

        public PluginConfig()
        {
            InitializeComponent();
            label1.Text = PluginLanguageManager.PluginStrings.ShareXPath;
            label2.Text = PluginLanguageManager.PluginStrings.ShareXPathExpl;
            btnOK.Text = LanguageManager.Strings.Ok;
            btnCancel.Text = PluginLanguageManager.PluginStrings.Cancel;
            textBox1.Text = PluginConfigHelper.GetPath();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                var path = folderBrowserDialog1.SelectedPath;
                textBox1.Text = path;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var folderpath = textBox1.Text;
            if (File.Exists(folderpath + "\\ShareX.exe"))
            {
                label3.Visible = false;
                label5.Visible = false;
                using var messageBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox();
                var msgDiag = messageBox.ShowDialog(LanguageManager.Strings.MacroDeckNeedsARestart, LanguageManager.Strings.MacroDeckMustBeRestartedForTheChanges, MessageBoxButtons.YesNo);
                if (msgDiag == DialogResult.Yes)
                {
                    if (folderpath.EndsWith("\\"))
                    {
                        PluginConfigHelper.UpdatePath(folderpath);
                        MacroDeck.RestartMacroDeck();
                    }
                    else
                    {
                        folderpath = folderpath + "\\";
                        PluginConfigHelper.UpdatePath(folderpath);
                        MacroDeck.RestartMacroDeck();
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else if (String.IsNullOrEmpty(folderpath))
            {
                using var messageBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox();
                messageBox.ShowDialog(PluginLanguageManager.PluginStrings.ActionRequired, PluginLanguageManager.PluginStrings.ActionRequiredDesc, MessageBoxButtons.OK);
                label5.Visible = true;
                label3.Visible = false;
            }
            else
            {
                using var messageBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox();
                messageBox.ShowDialog(PluginLanguageManager.PluginStrings.CantFindEXE, PluginLanguageManager.PluginStrings.CantFindEXE1, MessageBoxButtons.OK);
                label3.Visible = true;
                label5.Visible = false;
                //btnOK.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var fpath = textBox1.Text;
            if (File.Exists(fpath + "\\ShareX.exe"))
            {
                label3.Visible = false;
                label5.Visible = false;
                var folderpath = textBox1.Text;
                btnOK.Enabled = true;
            }
            else if (String.IsNullOrEmpty(fpath))
            {
                label5.Visible = true;
                label3.Visible = false;
            }
            else
            {
                label5.Visible = false;
                label3.Visible = true;
                //btnOK.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
