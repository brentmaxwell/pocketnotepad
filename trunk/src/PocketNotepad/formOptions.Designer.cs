namespace PocketNotepad
{
    partial class formOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemOk = new System.Windows.Forms.MenuItem();
            this.menuItemCancel = new System.Windows.Forms.MenuItem();
            this.labelFileTypes = new System.Windows.Forms.Label();
            this.textBoxFileTypes = new System.Windows.Forms.TextBox();
            this.labelTabWidth = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxWordWrap = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemOk);
            this.mainMenu1.MenuItems.Add(this.menuItemCancel);
            // 
            // menuItemOk
            // 
            this.menuItemOk.Text = "Ok";
            this.menuItemOk.Click += new System.EventHandler(this.menuItemOk_Click);
            // 
            // menuItemCancel
            // 
            this.menuItemCancel.Text = "Cancel";
            this.menuItemCancel.Click += new System.EventHandler(this.menuItemCancel_Click);
            // 
            // labelFileTypes
            // 
            this.labelFileTypes.Location = new System.Drawing.Point(3, 3);
            this.labelFileTypes.Name = "labelFileTypes";
            this.labelFileTypes.Size = new System.Drawing.Size(70, 20);
            this.labelFileTypes.Text = "FileTypes";
            // 
            // textBoxFileTypes
            // 
            this.textBoxFileTypes.AcceptsReturn = true;
            this.textBoxFileTypes.Location = new System.Drawing.Point(79, 3);
            this.textBoxFileTypes.Multiline = true;
            this.textBoxFileTypes.Name = "textBoxFileTypes";
            this.textBoxFileTypes.Size = new System.Drawing.Size(158, 76);
            this.textBoxFileTypes.TabIndex = 1;
            // 
            // labelTabWidth
            // 
            this.labelTabWidth.Location = new System.Drawing.Point(3, 87);
            this.labelTabWidth.Name = "labelTabWidth";
            this.labelTabWidth.Size = new System.Drawing.Size(70, 20);
            this.labelTabWidth.Text = "Tab Width";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(79, 85);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(102, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // checkBoxWordWrap
            // 
            this.checkBoxWordWrap.Location = new System.Drawing.Point(3, 113);
            this.checkBoxWordWrap.Name = "checkBoxWordWrap";
            this.checkBoxWordWrap.Size = new System.Drawing.Size(100, 20);
            this.checkBoxWordWrap.TabIndex = 7;
            this.checkBoxWordWrap.Text = "Word Wrap";
            // 
            // formOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.checkBoxWordWrap);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelTabWidth);
            this.Controls.Add(this.textBoxFileTypes);
            this.Controls.Add(this.labelFileTypes);
            this.Menu = this.mainMenu1;
            this.Name = "formOptions";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemOk;
        private System.Windows.Forms.MenuItem menuItemCancel;
        private System.Windows.Forms.Label labelFileTypes;
        private System.Windows.Forms.TextBox textBoxFileTypes;
        private System.Windows.Forms.Label labelTabWidth;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBoxWordWrap;
    }
}