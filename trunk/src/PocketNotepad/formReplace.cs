using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PocketNotepad
{
    public partial class formReplace : Form
    {
        public string FindText;
        public string ReplaceText;

        public formReplace()
        {
            InitializeComponent();
        }

        private void menuItemOk_Click(object sender, EventArgs e)
        {
            this.FindText = this.textBoxFind.Text;
            this.ReplaceText = this.textBoxReplace.Text;
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