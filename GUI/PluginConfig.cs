using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using SuchByte.MacroDeck.Plugins;
using jbcarreon123.ShareXPlugin.Languages;
using SuchByte.MacroDeck.Language;
using System.Runtime.InteropServices;

namespace jbcarreon123.ShareXPlugin.GUI
{
    public partial class PluginConfig : Form
    {
        // from https://stackoverflow.com/questions/18822067/rounded-corners-in-c-sharp-windows-forms
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public MacroDeckPlugin IMacroDeckPlugin { get; private set; }

        public PluginConfig()
        {
            InitializeComponent();
            label1.Text = PluginLanguageManager.PluginStrings.ShareXPath;
            label2.Text = PluginLanguageManager.PluginStrings.ShareXPathExpl;
            btnOK.Text = LanguageManager.Strings.Ok;
            btnCancel.Text = PluginLanguageManager.PluginStrings.Cancel;
            textBox1.Text = PluginConfigHelper.GetPath();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
                PluginConfigHelper.UpdatePath(folderpath);
                this.Close();
            }
            else
            {
                using var messageBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox();
                messageBox.ShowDialog(PluginLanguageManager.PluginStrings.CantFindEXE, PluginLanguageManager.PluginStrings.CantFindEXE1, MessageBoxButtons.OK);
                label3.Visible = true;
                //btnOK.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var fpath = textBox1.Text;
            if (File.Exists(fpath + "\\ShareX.exe"))
            {
                label3.Visible = false;
                var folderpath = textBox1.Text;
                btnOK.Enabled = true;
            }
            else
            {
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

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (TabPage tab in label4.Controls)
            {
                foreach (Label lbl in tab.Controls.OfType<Label>())
                {
                    lbl.MouseEnter += lbl_MouseEnter;
                    lbl.MouseLeave += lbl_MouseLeave;
                }
            }
        }

        void lbl_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#CDCDCD");
        }

        void lbl_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
