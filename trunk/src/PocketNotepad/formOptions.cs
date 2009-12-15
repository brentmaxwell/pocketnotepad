using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PocketNotepad
{
    public partial class formOptions : Form
    {
        Settings settings;
        public formOptions(Settings settingsObj)
        {
            this.settings = settingsObj;
            InitializeComponent();
            this.textBoxFileTypes.Text = this.settings.FileTypes;
            this.numericUpDown1.Value = (decimal)this.settings.TabWidth;
            this.checkBoxWordWrap.Checked = (bool)this.settings.WordWrap;
        }

        private void menuItemOk_Click(object sender, EventArgs e)
        {
            this.settings.FileTypes = this.textBoxFileTypes.Text;
            this.settings.TabWidth = (int)this.numericUpDown1.Value;
            this.settings.WordWrap = this.checkBoxWordWrap.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void menuItemCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}