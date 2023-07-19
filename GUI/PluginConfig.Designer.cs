using SuchByte.MacroDeck.GUI.CustomControls;
using System.Runtime.InteropServices;
using System;

namespace jbcarreon123.ShareXPlugin.GUI
{
    partial class PluginConfig
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginConfig));
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            textBox1 = new RoundedTextBox();
            label1 = new System.Windows.Forms.Label();
            btnBrowse = new ButtonPrimary();
            label2 = new System.Windows.Forms.Label();
            btnCancel = new ButtonPrimary();
            btnOK = new ButtonPrimary();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            comboBox1 = new RoundedComboBox();
            label4 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
            textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            textBox1.Icon = null;
            textBox1.Location = new System.Drawing.Point(13, 53);
            textBox1.Margin = new System.Windows.Forms.Padding(4);
            textBox1.MaxCharacters = 32767;
            textBox1.Multiline = false;
            textBox1.Name = "textBox1";
            textBox1.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            textBox1.PasswordChar = false;
            textBox1.PlaceHolderColor = System.Drawing.Color.Gray;
            textBox1.PlaceHolderText = "";
            textBox1.ReadOnly = false;
            textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox1.SelectionStart = 0;
            textBox1.Size = new System.Drawing.Size(393, 32);
            textBox1.TabIndex = 0;
            textBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(13, 30);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(142, 19);
            label1.TabIndex = 1;
            label1.Text = "ShareX Install Path";
            // 
            // btnBrowse
            // 
            btnBrowse.BorderRadius = 8;
            btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBrowse.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBrowse.ForeColor = System.Drawing.Color.White;
            btnBrowse.HoverColor = System.Drawing.Color.Empty;
            btnBrowse.Icon = null;
            btnBrowse.Location = new System.Drawing.Point(419, 53);
            btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Progress = 0;
            btnBrowse.ProgressColor = System.Drawing.Color.FromArgb(0, 103, 205);
            btnBrowse.Size = new System.Drawing.Size(96, 30);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.UseWindowsAccentColor = true;
            btnBrowse.WriteProgress = true;
            btnBrowse.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            label2.Location = new System.Drawing.Point(13, 117);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(308, 133);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            label2.Click += label2_Click;
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 8;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.HoverColor = System.Drawing.Color.Empty;
            btnCancel.Icon = null;
            btnCancel.Location = new System.Drawing.Point(419, 220);
            btnCancel.Margin = new System.Windows.Forms.Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Progress = 0;
            btnCancel.ProgressColor = System.Drawing.Color.FromArgb(0, 103, 205);
            btnCancel.Size = new System.Drawing.Size(96, 30);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.UseWindowsAccentColor = true;
            btnCancel.WriteProgress = true;
            btnCancel.Click += button2_Click;
            // 
            // btnOK
            // 
            btnOK.BorderRadius = 8;
            btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOK.ForeColor = System.Drawing.Color.White;
            btnOK.HoverColor = System.Drawing.Color.Empty;
            btnOK.Icon = null;
            btnOK.Location = new System.Drawing.Point(419, 182);
            btnOK.Margin = new System.Windows.Forms.Padding(4);
            btnOK.Name = "btnOK";
            btnOK.Progress = 0;
            btnOK.ProgressColor = System.Drawing.Color.FromArgb(0, 103, 205);
            btnOK.Size = new System.Drawing.Size(96, 30);
            btnOK.TabIndex = 5;
            btnOK.TabStop = false;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.UseWindowsAccentColor = true;
            btnOK.WriteProgress = true;
            btnOK.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            label3.Location = new System.Drawing.Point(13, 89);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(347, 19);
            label3.TabIndex = 6;
            label3.Text = "ShareX.exe does not exist on the specified path.";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            label5.Location = new System.Drawing.Point(13, 89);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(178, 19);
            label5.TabIndex = 8;
            label5.Text = "This section is required.";
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBox1.Icon = null;
            comboBox1.Location = new System.Drawing.Point(97, 266);
            comboBox1.Name = "comboBox1";
            comboBox1.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedItem = null;
            comboBox1.Size = new System.Drawing.Size(170, 26);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label4.Location = new System.Drawing.Point(13, 269);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(77, 19);
            label4.TabIndex = 10;
            label4.Text = "Language";
            // 
            // PluginConfig
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(528, 309);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnBrowse);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(label3);
            Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Location = new System.Drawing.Point(0, 0);
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PluginConfig";
            Text = "PluginConfiguration";
            Load += PluginConfig_Load;
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(btnOK, 0);
            Controls.SetChildIndex(btnCancel, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(btnBrowse, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(comboBox1, 0);
            Controls.SetChildIndex(label4, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private RoundedTextBox textBox1;
        private System.Windows.Forms.Label label1;
        private ButtonPrimary btnBrowse;
        private System.Windows.Forms.Label label2;
        private ButtonPrimary btnCancel;
        private ButtonPrimary btnOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private RoundedComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}
