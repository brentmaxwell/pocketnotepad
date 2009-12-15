namespace PocketNotepad
{
    partial class formReplace
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
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.labelFind = new System.Windows.Forms.Label();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.labelReplace = new System.Windows.Forms.Label();
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
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(3, 66);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(234, 21);
            this.textBoxFind.TabIndex = 3;
            // 
            // labelFind
            // 
            this.labelFind.Location = new System.Drawing.Point(3, 43);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(33, 20);
            this.labelFind.Text = "Find: ";
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(3, 127);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(234, 21);
            this.textBoxReplace.TabIndex = 6;
            // 
            // labelReplace
            // 
            this.labelReplace.Location = new System.Drawing.Point(3, 104);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(87, 20);
            this.labelReplace.Text = "Replace: ";
            // 
            // formReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.textBoxReplace);
            this.Controls.Add(this.labelReplace);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.labelFind);
            this.Menu = this.mainMenu1;
            this.Name = "formReplace";
            this.Text = "Replace";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemOk;
        private System.Windows.Forms.MenuItem menuItemCancel;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.Label labelReplace;
    }
}