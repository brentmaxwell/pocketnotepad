namespace PocketNotepad
{
    partial class formNotepad
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;
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
        private System.Windows.Forms.MenuItem menuItemTextSize;
        private System.Windows.Forms.MenuItem menuItemTextSizeNormal;
        private System.Windows.Forms.MenuItem menuItemTextSizeSmaller;
        private System.Windows.Forms.MenuItem menuItemTextSizeLarger;
        private System.Windows.Forms.MenuItem menuItemInsert;
        private System.Windows.Forms.MenuItem menuItemInsertTime;
        private System.Windows.Forms.MenuItem menuItemInsertDate;
        private System.Windows.Forms.MenuItem menuItemInsertDateTime;
        private System.Windows.Forms.MenuItem menuItemSeparator2;
        private System.Windows.Forms.MenuItem menuItemAbout;
        private System.Windows.Forms.MenuItem menuItemFindNext;
        private System.Windows.Forms.MenuItem menuItemCancel;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItemContextCut;
        private System.Windows.Forms.MenuItem menuItemContextCopy;
        private System.Windows.Forms.MenuItem menuItemContextPaste;
        private System.Windows.Forms.MenuItem menuItemContextSelectAll;
        private System.Windows.Forms.MenuItem menuItemContextSeparator;
        private System.Windows.Forms.MenuItem menuItemContextWordWrap;
        private System.Windows.Forms.MenuItem menuItemContextTextSize;
        private System.Windows.Forms.MenuItem menuItemContextTextSizeNormal;
        private System.Windows.Forms.MenuItem menuItemContextTextSizeSmaller;
        private System.Windows.Forms.MenuItem menuItemContextTextSizeLarger;
        private System.Windows.Forms.MenuItem menuItemContextInsert;
        private System.Windows.Forms.MenuItem menuItemContextInsertTime;
        private System.Windows.Forms.MenuItem menuItemContextInsertDate;
        private System.Windows.Forms.MenuItem menuItemContextInsertDateTime;
        private System.Windows.Forms.TextBox textBoxDoc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
     

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
            this.menuItemFind = new System.Windows.Forms.MenuItem();
            this.menuItemReplace = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItemWordWrap = new System.Windows.Forms.MenuItem();
            this.menuItemTextSize = new System.Windows.Forms.MenuItem();
            this.menuItemTextSizeLarger = new System.Windows.Forms.MenuItem();
            this.menuItemTextSizeNormal = new System.Windows.Forms.MenuItem();
            this.menuItemTextSizeSmaller = new System.Windows.Forms.MenuItem();
            this.menuItemInsert = new System.Windows.Forms.MenuItem();
            this.menuItemInsertTime = new System.Windows.Forms.MenuItem();
            this.menuItemInsertDate = new System.Windows.Forms.MenuItem();
            this.menuItemInsertDateTime = new System.Windows.Forms.MenuItem();
            this.menuItemSeparator2 = new System.Windows.Forms.MenuItem();
            this.menuItemOptions = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.menuItemFindNext = new System.Windows.Forms.MenuItem();
            this.menuItemCancel = new System.Windows.Forms.MenuItem();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItemContextCut = new System.Windows.Forms.MenuItem();
            this.menuItemContextCopy = new System.Windows.Forms.MenuItem();
            this.menuItemContextPaste = new System.Windows.Forms.MenuItem();
            this.menuItemContextSelectAll = new System.Windows.Forms.MenuItem();
            this.menuItemContextSeparator = new System.Windows.Forms.MenuItem();
            this.menuItemContextWordWrap = new System.Windows.Forms.MenuItem();
            this.menuItemContextTextSize = new System.Windows.Forms.MenuItem();
            this.menuItemContextTextSizeLarger = new System.Windows.Forms.MenuItem();
            this.menuItemContextTextSizeNormal = new System.Windows.Forms.MenuItem();
            this.menuItemContextTextSizeSmaller = new System.Windows.Forms.MenuItem();
            this.menuItemContextInsert = new System.Windows.Forms.MenuItem();
            this.menuItemContextInsertTime = new System.Windows.Forms.MenuItem();
            this.menuItemContextInsertDate = new System.Windows.Forms.MenuItem();
            this.menuItemContextInsertDateTime = new System.Windows.Forms.MenuItem();
            this.textBoxDoc = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuItemEdit = new System.Windows.Forms.MenuItem();
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
            this.menuItemMenu.MenuItems.Add(this.menuItemEdit);
            this.menuItemMenu.MenuItems.Add(this.menuItemSeparator1);
            this.menuItemMenu.MenuItems.Add(this.menuItemFind);
            this.menuItemMenu.MenuItems.Add(this.menuItemReplace);
            this.menuItemMenu.MenuItems.Add(this.menuItem3);
            this.menuItemMenu.MenuItems.Add(this.menuItemWordWrap);
            this.menuItemMenu.MenuItems.Add(this.menuItemTextSize);
            this.menuItemMenu.MenuItems.Add(this.menuItemInsert);
            this.menuItemMenu.MenuItems.Add(this.menuItemSeparator2);
            this.menuItemMenu.MenuItems.Add(this.menuItemOptions);
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
            // menuItemFind
            // 
            this.menuItemFind.Text = "&Find";
            this.menuItemFind.Click += new System.EventHandler(this.menuItemFind_Click);
            // 
            // menuItemReplace
            // 
            this.menuItemReplace.Text = "&Replace";
            this.menuItemReplace.Click += new System.EventHandler(this.menuItemReplace_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "-";
            // 
            // menuItemWordWrap
            // 
            this.menuItemWordWrap.Checked = true;
            this.menuItemWordWrap.Text = "&Word Wrap";
            this.menuItemWordWrap.Click += new System.EventHandler(this.menuItemWordWrap_Click);
            // 
            // menuItemTextSize
            // 
            this.menuItemTextSize.MenuItems.Add(this.menuItemTextSizeLarger);
            this.menuItemTextSize.MenuItems.Add(this.menuItemTextSizeNormal);
            this.menuItemTextSize.MenuItems.Add(this.menuItemTextSizeSmaller);
            this.menuItemTextSize.Text = "Text &Size";
            // 
            // menuItemTextSizeLarger
            // 
            this.menuItemTextSizeLarger.Text = "Larger - &+";
            this.menuItemTextSizeLarger.Click += new System.EventHandler(this.menuItemTextSizeLarger_Click);
            // 
            // menuItemTextSizeNormal
            // 
            this.menuItemTextSizeNormal.Text = "Normal - &0";
            this.menuItemTextSizeNormal.Click += new System.EventHandler(this.menuItemTextSizeNormal_Click);
            // 
            // menuItemTextSizeSmaller
            // 
            this.menuItemTextSizeSmaller.Text = "Smaller - &-";
            this.menuItemTextSizeSmaller.Click += new System.EventHandler(this.menuItemTextSizeSmaller_Click);
            // 
            // menuItemInsert
            // 
            this.menuItemInsert.MenuItems.Add(this.menuItemInsertTime);
            this.menuItemInsert.MenuItems.Add(this.menuItemInsertDate);
            this.menuItemInsert.MenuItems.Add(this.menuItemInsertDateTime);
            this.menuItemInsert.Text = "&Insert";
            // 
            // menuItemInsertTime
            // 
            this.menuItemInsertTime.Text = "&Time";
            this.menuItemInsertTime.Click += new System.EventHandler(this.menuItemInsertTime_Click);
            // 
            // menuItemInsertDate
            // 
            this.menuItemInsertDate.Text = "&Date";
            this.menuItemInsertDate.Click += new System.EventHandler(this.menuItemInsertDate_Click);
            // 
            // menuItemInsertDateTime
            // 
            this.menuItemInsertDateTime.Text = "Date/Time";
            this.menuItemInsertDateTime.Click += new System.EventHandler(this.menuItemInsertDateTime_Click);
            // 
            // menuItemSeparator2
            // 
            this.menuItemSeparator2.Text = "-";
            // 
            // menuItemOptions
            // 
            this.menuItemOptions.Text = "&Options";
            this.menuItemOptions.Click += new System.EventHandler(this.menuItemOptions_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Text = "About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // menuItemFindNext
            // 
            this.menuItemFindNext.Text = "Next";
            this.menuItemFindNext.Click += new System.EventHandler(this.menuItemFindNext_Click);
            // 
            // menuItemCancel
            // 
            this.menuItemCancel.Text = "Cancel";
            this.menuItemCancel.Click += new System.EventHandler(this.menuItemCancel_Click);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.menuItemContextCut);
            this.contextMenu1.MenuItems.Add(this.menuItemContextCopy);
            this.contextMenu1.MenuItems.Add(this.menuItemContextPaste);
            this.contextMenu1.MenuItems.Add(this.menuItemContextSelectAll);
            this.contextMenu1.MenuItems.Add(this.menuItemContextSeparator);
            this.contextMenu1.MenuItems.Add(this.menuItemContextWordWrap);
            this.contextMenu1.MenuItems.Add(this.menuItemContextTextSize);
            this.contextMenu1.MenuItems.Add(this.menuItemContextInsert);
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
            // menuItemContextSeparator
            // 
            this.menuItemContextSeparator.Text = "-";
            // 
            // menuItemContextWordWrap
            // 
            this.menuItemContextWordWrap.Checked = true;
            this.menuItemContextWordWrap.Text = "&Word Wrap";
            this.menuItemContextWordWrap.Click += new System.EventHandler(this.menuItemWordWrap_Click);
            // 
            // menuItemContextTextSize
            // 
            this.menuItemContextTextSize.MenuItems.Add(this.menuItemContextTextSizeLarger);
            this.menuItemContextTextSize.MenuItems.Add(this.menuItemContextTextSizeNormal);
            this.menuItemContextTextSize.MenuItems.Add(this.menuItemContextTextSizeSmaller);
            this.menuItemContextTextSize.Text = "Text &Size";
            // 
            // menuItemContextTextSizeLarger
            // 
            this.menuItemContextTextSizeLarger.Text = "Larger - &+";
            this.menuItemContextTextSizeLarger.Click += new System.EventHandler(this.menuItemTextSizeLarger_Click);
            // 
            // menuItemContextTextSizeNormal
            // 
            this.menuItemContextTextSizeNormal.Text = "Normal - &0";
            this.menuItemContextTextSizeNormal.Click += new System.EventHandler(this.menuItemTextSizeNormal_Click);
            // 
            // menuItemContextTextSizeSmaller
            // 
            this.menuItemContextTextSizeSmaller.Text = "Smaller - &-";
            this.menuItemContextTextSizeSmaller.Click += new System.EventHandler(this.menuItemTextSizeSmaller_Click);
            // 
            // menuItemContextInsert
            // 
            this.menuItemContextInsert.MenuItems.Add(this.menuItemContextInsertTime);
            this.menuItemContextInsert.MenuItems.Add(this.menuItemContextInsertDate);
            this.menuItemContextInsert.MenuItems.Add(this.menuItemContextInsertDateTime);
            this.menuItemContextInsert.Text = "Insert";
            // 
            // menuItemContextInsertTime
            // 
            this.menuItemContextInsertTime.Text = "Time";
            this.menuItemContextInsertTime.Click += new System.EventHandler(this.menuItemInsertTime_Click);
            // 
            // menuItemContextInsertDate
            // 
            this.menuItemContextInsertDate.Text = "Date";
            this.menuItemContextInsertDate.Click += new System.EventHandler(this.menuItemInsertDate_Click);
            // 
            // menuItemContextInsertDateTime
            // 
            this.menuItemContextInsertDateTime.Text = "Date/Time";
            this.menuItemContextInsertDateTime.Click += new System.EventHandler(this.menuItemInsertDateTime_Click);
            // 
            // textBoxDoc
            // 
            this.textBoxDoc.AcceptsReturn = true;
            this.textBoxDoc.AcceptsTab = true;
            this.textBoxDoc.ContextMenu = this.contextMenu1;
            this.textBoxDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDoc.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular);
            this.textBoxDoc.Location = new System.Drawing.Point(0, 0);
            this.textBoxDoc.MaxLength = 2147483647;
            this.textBoxDoc.Multiline = true;
            this.textBoxDoc.Name = "textBoxDoc";
            this.textBoxDoc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDoc.Size = new System.Drawing.Size(240, 268);
            this.textBoxDoc.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text files|*.txt|XML files|*.xml|HTML files|*.html|All files|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files|*.txt|XML files|*.xml|HTML files|*.html|All files|*.*";
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.MenuItems.Add(this.menuItemUndo);
            this.menuItemEdit.MenuItems.Add(this.menuItemCut);
            this.menuItemEdit.MenuItems.Add(this.menuItemCopy);
            this.menuItemEdit.MenuItems.Add(this.menuItemPaste);
            this.menuItemEdit.MenuItems.Add(this.menuItemSelectAll);
            this.menuItemEdit.Text = "&Edit";
            // 
            // formNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.textBoxDoc);
            this.Menu = this.mainMenu1;
            this.Name = "formNotepad";
            this.Text = "Notepad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemFind;
        private System.Windows.Forms.MenuItem menuItemReplace;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItemOptions;
        private System.Windows.Forms.MenuItem menuItemEdit;


        

    }
}

