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
    public partial class formNotepad : Form
    {
        #region Initialization stuff

        /// <summary>
        /// Private variable for the filename of the document.
        /// </summary>
        private string _filename;

        /// <summary>
        /// Initializes the notepad object with a new document.
        /// </summary>
        public formNotepad()
        {
            this.InitializeComponent();
            this._filename = null;
        }

        /// <summary>
        /// Initializes the notepad object with an existing file.
        /// </summary>
        /// <param name="filename">Path of file to open</param>
        public formNotepad(string filename)
        {
            this.InitializeComponent();
            this._filename = filename;
            this.OpenFile(this._filename);
        }

        #endregion

        #region Click Events

        /// <summary>
        /// Starts a new document, requesting save confirmation if the document has been modified.
        /// </summary>
        private void menuItemNew_Click(object sender, EventArgs e)
        {
            switch (this.SaveConfirm())
            {
                case DialogResult.Yes:
                    if (this.SaveFile())
                    {
                        this.textBoxDoc.Text = "";
                        this.textBoxDoc.Modified = false;
                        this._filename = null;
                    }
                    break;
                case DialogResult.No:
                    this.textBoxDoc.Text = "";
                    this._filename = null;
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        /// <summary>
        /// Opens a new document, requesting save confirmation if the exisiting document has been modified.
        /// </summary>
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
                case DialogResult.Cancel:
                    break;
            }
        }

        /// <summary>
        /// Saves the current document.
        /// </summary>
        private void menuItemSave_Click(object sender, EventArgs e)
        {
            this.SaveFile();
        }

        /// <summary>
        /// Saves the current document with a new filename
        /// </summary>
        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            this.SaveFileAs();
        }

        /// <summary>
        /// Exits the application, requesting save confirmation if the document has been modified.
        /// </summary>
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
                case DialogResult.Cancel:
                    break;
            }
        }

        /// <summary>
        /// Undo the last action.
        /// </summary>
        private void menuItemUndo_Click(object sender, EventArgs e)
        {
            this.textBoxDoc.Undo();
        }

        /// <summary>
        /// Cuts the selected text.
        /// </summary>
        private void menuItemCut_Click(object sender, EventArgs e)
        {
            this.Cut();
        }

        /// <summary>
        /// Copies the selected text.
        /// </summary>
        private void menuItemCopy_Click(object sender, EventArgs e)
        {
            this.Copy();
        }

        /// <summary>
        /// Pastes the contents of the clipboard at the selected position.
        /// </summary>
        private void menuItemPaste_Click(object sender, EventArgs e)
        {
            this.Paste();
        }

        /// <summary>
        /// Selects the contents of the document.
        /// </summary>
        private void menuItemSelectAll_Click(object sender, EventArgs e)
        {
            this.textBoxDoc.SelectAll();
        }

        /// <summary>
        /// Toggles wordwrap on and off.
        /// </summary>
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

        /// <summary>
        /// Inserts the time at the selected position.
        /// </summary>
        private void menuItemTime_Click(object sender, EventArgs e)
        {
            string DateTimeText = DateTime.Now.ToShortTimeString();
            int SelectionStart = this.textBoxDoc.SelectionStart;
            this.textBoxDoc.Text = this.textBoxDoc.Text.Insert(SelectionStart, DateTimeText);
            this.textBoxDoc.SelectionStart = SelectionStart + DateTimeText.Length;
        }

        /// <summary>
        /// Inserts date at the selected position.
        /// </summary>
        private void menuItemDate_Click(object sender, EventArgs e)
        {
            string DateTimeText = DateTime.Now.ToShortDateString();
            int SelectionStart = this.textBoxDoc.SelectionStart;
            this.textBoxDoc.Text = this.textBoxDoc.Text.Insert(SelectionStart, DateTimeText);
            this.textBoxDoc.SelectionStart = SelectionStart + DateTimeText.Length;
        }

        /// <summary>
        /// Inserts the date and time at the selected position.
        /// </summary>
        private void menuItemDateTime_Click(object sender, EventArgs e)
        {
            string DateTimeText = DateTime.Now.ToString();
            int SelectionStart = this.textBoxDoc.SelectionStart;
            this.textBoxDoc.Text = this.textBoxDoc.Text.Insert(SelectionStart, DateTimeText);
            this.textBoxDoc.SelectionStart = SelectionStart + DateTimeText.Length;
        }

        /// <summary>
        /// Shows the about dialog.
        /// </summary>
        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version " +
                            ApplicationDetails.Version + "\r\n" +
                            ApplicationDetails.Copyright + "\r\n\r\n" +
                            ApplicationDetails.Description,
                            ApplicationDetails.Title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1
                            );
        }

        #endregion

        #region Functions

        /// <summary>
        /// Checks to see if the document has been modified, and request confirmation if it has.
        /// </summary>
        /// <returns>DialogResult indicating OK or Cancel</returns>
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

        /// <summary>
        /// Clears the selected text
        /// </summary>
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

        /// <summary>
        /// Copies the selected text to the clipboard
        /// </summary>
        private void Copy()
        {
            if (this.textBoxDoc.SelectedText != "")
            {
                Clipboard.SetDataObject(this.textBoxDoc.SelectedText);
            }
        }

        /// <summary>
        /// Cuts the selected text to the clipboard
        /// </summary>
        private void Cut()
        {
            this.Copy();
            this.Clear();
        }

        /// <summary>
        /// Pastes the contents of the clipboard.
        /// </summary>
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

        /// <summary>
        /// Asks user for a file to open, and opens it.
        /// </summary>
        /// <returns>Boolean indicating success</returns>
        private bool OpenFile()
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                return this.OpenFile(this.openFileDialog1.FileName);
            else
                return false;
        }

        /// <summary>
        /// Opens the selected file.
        /// </summary>
        /// <param name="name">Filename to be opened</param>
        /// <returns>Boolean indicating success</returns>
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
                    this._filename = name;
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

        /* TODO:
         * I don't like the way this switches for
         * save, save as, and save when it doesn't already have a file name.
         */

        /// <summary>
        /// Saves the current file with a new name.
        /// </summary>
        /// <returns>Boolean indicating success</returns>
        private bool SaveFileAs()
        {
            if (this.saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return false;
            }
            else
            {
                this._filename = this.saveFileDialog1.FileName;
            }
            this.saveFileDialog1.FileName = "";
            return this.SaveFile(this._filename);
        }

        /// <summary>
        /// Saves the current file.
        /// </summary>
        /// <returns>Boolean indicating success</returns>
        private bool SaveFile()
        {
            if (this._filename == null)
            {
                return this.SaveFileAs();
            }
            else
            {
                return this.SaveFile(this._filename);
            }
        }

        /// <summary>
        /// Saves the current file with a filename
        /// </summary>
        /// <param name="filename">Path to be saved.  If null, will ask for filename.</param>
        /// <returns>Boolean indicating success</returns>
        private bool SaveFile(string filename)
        {
            if (filename == null)
            {
                return this.SaveFile();
            }
            try
            {
                StreamWriter sw = new StreamWriter(this._filename);
                sw.Write(this.textBoxDoc.Text);
                sw.Close();
                this.textBoxDoc.Modified = false;
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "\"" + error.Message + "\" saving file \"" + this._filename + "\"",
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