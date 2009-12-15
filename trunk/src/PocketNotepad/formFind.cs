using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PocketNotepad
{
    public partial class formFind : Form
    {
        public String findText;

        public formFind()
        {
            InitializeComponent();
        }

        private void menuItemOk_Click(object sender, EventArgs e)
        {
            this.findText = this.textBox1.Text;
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