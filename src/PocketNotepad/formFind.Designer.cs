namespace PocketNotepad
{
    partial class formFind
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
            this.labelFind = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // labelFind
            // 
            this.labelFind.Location = new System.Drawing.Point(3, 31);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(33, 20);
            this.labelFind.Text = "Find: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 21);
            this.textBox1.TabIndex = 1;
            // 
            // formFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelFind);
            this.Menu = this.mainMenu1;
            this.Name = "formFind";
            this.Text = "Find";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuItem menuItemOk;
        private System.Windows.Forms.MenuItem menuItemCancel;
    }
}