using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PocketNotepad
{
    public partial class formMain : Form
    {
        #region Initialization stuff

        private string filename;

        public formMain()
        {
            InitializeComponent();
            this.filename = null;
        }

        public formMain(string filename)
        {
            InitializeComponent();
            this.filename = filename;
            this.OpenFile(this.filename);
        }

        #endregion

        #region Click Events

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            switch (this.SaveConfirm())
            {
                case DialogResult.Yes:
                    if (this.SaveFile())
                    {
                        this.textBoxDoc.Text = "";
                        this.textBoxDoc.Modified = false;
                        this.filename = null;
                    }
                    break;
                case DialogResult.No:
                    this.textBoxDoc.Text = "";
                    this.filename = null;
                    break;
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            switch (this.SaveConfirm())
            {
                case DialogResult.Yes:
                    if (this.SaveFile())
                    {
                        this.OpenFile();
                    }
                    break;
                case DialogResult.No:
                    this.OpenFile();
                    break;
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            this.SaveFile();
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            this.filename = null;
            this.SaveFile();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            switch (this.SaveConfirm())
            {
                case DialogResult.Yes:
                    if (this.SaveFile())
                    {
                        Application.Exit();
                    }
                    break;
                case DialogResult.No:
                    Application.Exit();
                    break;
            }
        }

        private void menuItemUndo_Click(object sender, EventArgs e)
        {
            this.textBoxDoc.Undo();
        }

        private void menuItemCut_Click(object sender, EventArgs e)
        {
            this.Cut();
        }

        private void menuItemCopy_Click(object sender, EventArgs e)
        {
            this.Copy();
        }

        private void menuItemPaste_Click(object sender, EventArgs e)
        {
            this.Paste();
        }

        private void menuItemSelectAll_Click(object sender, EventArgs e)
        {
            this.textBoxDoc.SelectAll();
        }

        private void menuItemWordWrap_Click(object sender, EventArgs e)
        {
            switch (this.textBoxDoc.WordWrap)
            {
                case true:
                    this.menuItemWordWrap.Checked = false;
                    this.textBoxDoc.WordWrap = false;
                    this.textBoxDoc.ScrollBars = ScrollBars.Both;
                    break;
                case false:
                    this.menuItemWordWrap.Checked = true;
                    this.textBoxDoc.WordWrap = true;
                    this.textBoxDoc.ScrollBars = ScrollBars.Vertical;
                    break;
            }
        }

        private void menuItemTime_Click(object sender, EventArgs e)
        {
            string DateTimeText = DateTime.Now.ToShortTimeString();
            int SelectionStart = this.textBoxDoc.SelectionStart;
            this.textBoxDoc.Text = this.textBoxDoc.Text.Insert(SelectionStart, DateTimeText);
            this.textBoxDoc.SelectionStart = SelectionStart + DateTimeText.Length;
        }

        private void menuItemDate_Click(object sender, EventArgs e)
        {
            string DateTimeText = DateTime.Now.ToShortDateString();
            int SelectionStart = this.textBoxDoc.SelectionStart;
            this.textBoxDoc.Text = this.textBoxDoc.Text.Insert(SelectionStart, DateTimeText);
            this.textBoxDoc.SelectionStart = SelectionStart + DateTimeText.Length;
        }

        private void menuItemDateTime_Click(object sender, EventArgs e)
        {
            string DateTimeText = DateTime.Now.ToString();
            int SelectionStart = this.textBoxDoc.SelectionStart;
            this.textBoxDoc.Text = this.textBoxDoc.Text.Insert(SelectionStart, DateTimeText);
            this.textBoxDoc.SelectionStart = SelectionStart + DateTimeText.Length;
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version " +
                            ApplicationDetails.Get(ApplicationDetails.AttributeType.Version) + "\r\n" +
                            ApplicationDetails.Get(ApplicationDetails.AttributeType.Copyright) + "\r\n\r\n" +
                            ApplicationDetails.Get(ApplicationDetails.AttributeType.Description),
                            ApplicationDetails.Get(ApplicationDetails.AttributeType.Title),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1
                            );
        }

       #endregion

        #region Functions

        /// <summary>Checks to see if the document has been modified, and request confirmation if it has</summary>
        private DialogResult SaveConfirm()
        {
            if (this.textBoxDoc.Modified)
            {
                return MessageBox.Show("Do you wish to save the document?", "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else
            {
                return DialogResult.No;
            }
        }

        /// <summary>Clears the selected text</summary>
        private void Clear()
        {
            if (this.textBoxDoc.SelectedText != "")
            {
                int selectionStart = this.textBoxDoc.SelectionStart;
                int selectionLength = this.textBoxDoc.SelectionLength;
                this.textBoxDoc.Text = this.textBoxDoc.Text.Remove(selectionStart, selectionLength);
                this.textBoxDoc.SelectionStart = selectionStart;
            }
        }

        /// <summary>Copies the selected text to the clipboard</summary>
        private void Copy()
        {
            if (this.textBoxDoc.SelectedText != "")
            {
                Clipboard.SetDataObject(this.textBoxDoc.SelectedText);
            }
        }

        /// <summary>Cuts the selected text to the clipboard</summary>
        private void Cut()
        {
            this.Copy();
            this.Clear();
        }

        /// <summary>Pastes the contents of the clipboard</summary>
        private void Paste()
        {
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Text))
            {
                string pasteText = iData.GetData(DataFormats.UnicodeText, true).ToString();
                int selectionStart = this.textBoxDoc.SelectionStart;
                if (this.textBoxDoc.SelectionLength > 0)
                {
                    this.textBoxDoc.Text = this.textBoxDoc.Text.Remove(this.textBoxDoc.SelectionStart, this.textBoxDoc.SelectionLength);
                }
                this.textBoxDoc.Text = this.textBoxDoc.Text.Insert(selectionStart, pasteText);
                this.textBoxDoc.SelectionStart = selectionStart + pasteText.Length;
            }
        }

        /// <summary>Asks user for a file to open, and opens it</summary>
        private bool OpenFile()
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                return this.OpenFile(this.openFileDialog1.FileName);
            else
                return false;
        }

        /// <summary>Opens the selected file</summary>
        /// <param name="name">Filename to be opened</param>
        private bool OpenFile(string name)
        {
            if (name != null)
            {
                try
                {
                    StreamReader sr = new StreamReader(name);
                    if (sr.BaseStream.Length > this.textBoxDoc.MaxLength)
                    {
                        throw new System.IO.IOException("File is too large");
                    }
                    this.textBoxDoc.Text = sr.ReadToEnd();
                    sr.Close();
                    this.filename = name;
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(
                        "\"" + error.Message + "\" loading file \"" + name + "\"",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand,
                        MessageBoxDefaultButton.Button1);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>Saves the current file</summary>
        private bool SaveFile()
        {
            if (this.filename == null)
            {
                if (this.saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }
                else
                {
                    this.filename = this.saveFileDialog1.FileName;
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter(this.filename);
                sw.Write(this.textBoxDoc.Text);
                sw.Close();
                this.textBoxDoc.Modified = false;

                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "\"" + error.Message + "\" saving file \"" + this.filename + "\"",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand,
                    MessageBoxDefaultButton.Button1);
                return false;
            }
        }

        #endregion
    }
}