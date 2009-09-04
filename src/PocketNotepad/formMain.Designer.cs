namespace PocketNotepad
{
    partial class formMain
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
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemNew = new System.Windows.Forms.MenuItem();
            this.menuItemOpen = new System.Windows.Forms.MenuItem();
            this.menuItemSave = new System.Windows.Forms.MenuItem();
            this.menuItemSaveAs = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItemMenu = new System.Windows.Forms.MenuItem();
            this.menuItemUndo = new System.Windows.Forms.MenuItem();
            this.menuItemCut = new System.Windows.Forms.MenuItem();
            this.menuItemCopy = new System.Windows.Forms.MenuItem();
            this.menuItemPaste = new System.Windows.Forms.MenuItem();
            this.menuItemSelectAll = new System.Windows.Forms.MenuItem();
            this.menuItemSeparator1 = new System.Windows.Forms.MenuItem();
            this.menuItemWordWrap = new System.Windows.Forms.MenuItem();
            this.menuItemInsert = new System.Windows.Forms.MenuItem();
            this.menuItemTime = new System.Windows.Forms.MenuItem();
            this.menuItemDate = new System.Windows.Forms.MenuItem();
            this.menuItemDateTime = new System.Windows.Forms.MenuItem();
            this.menuItemSeparator2 = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.textBoxDoc = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItemContextCut = new System.Windows.Forms.MenuItem();
            this.menuItemContextCopy = new System.Windows.Forms.MenuItem();
            this.menuItemContextPaste = new System.Windows.Forms.MenuItem();
            this.menuItemContextSelectAll = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemFile);
            this.mainMenu1.MenuItems.Add(this.menuItemMenu);
            // 
            // menuItemFile
            // 
            this.menuItemFile.MenuItems.Add(this.menuItemNew);
            this.menuItemFile.MenuItems.Add(this.menuItemOpen);
            this.menuItemFile.MenuItems.Add(this.menuItemSave);
            this.menuItemFile.MenuItems.Add(this.menuItemSaveAs);
            this.menuItemFile.MenuItems.Add(this.menuItemExit);
            this.menuItemFile.Text = "File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Text = "&New";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Text = "&Open";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Text = "&Save";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // menuItemSaveAs
            // 
            this.menuItemSaveAs.Text = "Save &As";
            this.menuItemSaveAs.Click += new System.EventHandler(this.menuItemSaveAs_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemMenu
            // 
            this.menuItemMenu.MenuItems.Add(this.menuItemUndo);
            this.menuItemMenu.MenuItems.Add(this.menuItemCut);
            this.menuItemMenu.MenuItems.Add(this.menuItemCopy);
            this.menuItemMenu.MenuItems.Add(this.menuItemPaste);
            this.menuItemMenu.MenuItems.Add(this.menuItemSelectAll);
            this.menuItemMenu.MenuItems.Add(this.menuItemSeparator1);
            this.menuItemMenu.MenuItems.Add(this.menuItemWordWrap);
            this.menuItemMenu.MenuItems.Add(this.menuItemInsert);
            this.menuItemMenu.MenuItems.Add(this.menuItemSeparator2);
            this.menuItemMenu.MenuItems.Add(this.menuItemAbout);
            this.menuItemMenu.Text = "Menu";
            // 
            // menuItemUndo
            // 
            this.menuItemUndo.Text = "Undo";
            this.menuItemUndo.Click += new System.EventHandler(this.menuItemUndo_Click);
            // 
            // menuItemCut
            // 
            this.menuItemCut.Text = "Cu&t";
            this.menuItemCut.Click += new System.EventHandler(this.menuItemCut_Click);
            // 
            // menuItemCopy
            // 
            this.menuItemCopy.Text = "&Copy";
            this.menuItemCopy.Click += new System.EventHandler(this.menuItemCopy_Click);
            // 
            // menuItemPaste
            // 
            this.menuItemPaste.Text = "&Paste";
            this.menuItemPaste.Click += new System.EventHandler(this.menuItemPaste_Click);
            // 
            // menuItemSelectAll
            // 
            this.menuItemSelectAll.Text = "Select &All";
            this.menuItemSelectAll.Click += new System.EventHandler(this.menuItemSelectAll_Click);
            // 
            // menuItemSeparator1
            // 
            this.menuItemSeparator1.Text = "-";
            // 
            // menuItemWordWrap
            // 
            this.menuItemWordWrap.Checked = true;
            this.menuItemWordWrap.Text = "&Word Wrap";
            this.menuItemWordWrap.Click += new System.EventHandler(this.menuItemWordWrap_Click);
            // 
            // menuItemInsert
            // 
            this.menuItemInsert.MenuItems.Add(this.menuItemTime);
            this.menuItemInsert.MenuItems.Add(this.menuItemDate);
            this.menuItemInsert.MenuItems.Add(this.menuItemDateTime);
            this.menuItemInsert.Text = "&Insert";
            // 
            // menuItemTime
            // 
            this.menuItemTime.Text = "&Time";
            this.menuItemTime.Click += new System.EventHandler(this.menuItemTime_Click);
            // 
            // menuItemDate
            // 
            this.menuItemDate.Text = "&Date";
            this.menuItemDate.Click += new System.EventHandler(this.menuItemDate_Click);
            // 
            // menuItemDateTime
            // 
            this.menuItemDateTime.Text = "Date/Time";
            this.menuItemDateTime.Click += new System.EventHandler(this.menuItemDateTime_Click);
            // 
            // menuItemSeparator2
            // 
            this.menuItemSeparator2.Text = "-";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Text = "About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // textBoxDoc
            // 
            this.textBoxDoc.AcceptsReturn = true;
            this.textBoxDoc.AcceptsTab = true;
            this.textBoxDoc.ContextMenu = this.contextMenu1;
            this.textBoxDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDoc.Location = new System.Drawing.Point(0, 0);
            this.textBoxDoc.MaxLength = 2147483647;
            this.textBoxDoc.Multiline = true;
            this.textBoxDoc.Name = "textBoxDoc";
            this.textBoxDoc.Size = new System.Drawing.Size(240, 268);
            this.textBoxDoc.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = global::PocketNotepad.Properties.Resources.Filetypes;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = global::PocketNotepad.Properties.Resources.Filetypes;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.menuItemContextCut);
            this.contextMenu1.MenuItems.Add(this.menuItemContextCopy);
            this.contextMenu1.MenuItems.Add(this.menuItemContextPaste);
            this.contextMenu1.MenuItems.Add(this.menuItemContextSelectAll);
            // 
            // menuItemContextCut
            // 
            this.menuItemContextCut.Text = "Cut";
            this.menuItemContextCut.Click += new System.EventHandler(this.menuItemCut_Click);
            // 
            // menuItemContextCopy
            // 
            this.menuItemContextCopy.Text = "Copy";
            this.menuItemContextCopy.Click += new System.EventHandler(this.menuItemCopy_Click);
            // 
            // menuItemContextPaste
            // 
            this.menuItemContextPaste.Text = "Paste";
            this.menuItemContextPaste.Click += new System.EventHandler(this.menuItemPaste_Click);
            // 
            // menuItemContextSelectAll
            // 
            this.menuItemContextSelectAll.Text = "Select All";
            this.menuItemContextSelectAll.Click += new System.EventHandler(this.menuItemSelectAll_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.textBoxDoc);
            this.Menu = this.mainMenu1;
            this.Name = "formMain";
            this.Text = "Notepad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemFile;
        private System.Windows.Forms.MenuItem menuItemNew;
        private System.Windows.Forms.MenuItem menuItemOpen;
        private System.Windows.Forms.MenuItem menuItemSave;
        private System.Windows.Forms.MenuItem menuItemSaveAs;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.MenuItem menuItemMenu;
        private System.Windows.Forms.MenuItem menuItemUndo;
        private System.Windows.Forms.MenuItem menuItemCut;
        private System.Windows.Forms.MenuItem menuItemCopy;
        private System.Windows.Forms.MenuItem menuItemPaste;
        private System.Windows.Forms.MenuItem menuItemSelectAll;
        private System.Windows.Forms.MenuItem menuItemSeparator1;
        private System.Windows.Forms.MenuItem menuItemWordWrap;
        private System.Windows.Forms.MenuItem menuItemInsert;
        private System.Windows.Forms.MenuItem menuItemTime;
        private System.Windows.Forms.MenuItem menuItemDate;
        private System.Windows.Forms.MenuItem menuItemDateTime;
        private System.Windows.Forms.MenuItem menuItemSeparator2;
        private System.Windows.Forms.MenuItem menuItemAbout;
        private System.Windows.Forms.TextBox textBoxDoc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItemContextCut;
        private System.Windows.Forms.MenuItem menuItemContextCopy;
        private System.Windows.Forms.MenuItem menuItemContextPaste;
        private System.Windows.Forms.MenuItem menuItemContextSelectAll;
    }
}

