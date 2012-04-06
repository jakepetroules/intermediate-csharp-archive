namespace IntermediateCSharp.Lesson09
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// The word processor editor window class.
    /// </summary>
    public partial class EditorWindow : Form
    {
        /// <summary>
        /// The filename of the current document.
        /// </summary>
        private string filename;

        /// <summary>
        /// Whether the document has unsaved changes.
        /// </summary>
        private bool dirty;

        /// <summary>
        /// Initializes a new instance of the EditorWindow class.
        /// </summary>
        public EditorWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the EditorWindow class.
        /// </summary>
        /// <param name="fileName">The filename of the file to read the document from.</param>
        public EditorWindow(string fileName) : this()
        {
            this.editorText.LoadFile(fileName);
            this.filename = fileName;
            this.Text = fileName;
        }

        /// <summary>
        /// Notifies external component of state change.
        /// </summary>
        public event EventHandler UpdateReceived;

        /// <summary>
        /// Gets or sets the font of the current text selection or insertion point.
        /// </summary>
        /// <value>The font of the current text selection or insertion point.</value>
        public Font SelectionFont
        {
            get { return this.editorText.SelectionFont; }
            set { this.editorText.SelectionFont = value; }
        }

        /// <summary>
        /// Gets or sets the font size of the selected text.
        /// </summary>
        /// <value>The font size of the selected text.</value>
        public float SelectionFontSize
        {
            get
            {
                return this.SelectionFont.Size;
            }

            set
            {
                this.editorText.SelectionFont = new Font(this.editorText.SelectionFont.Name, value, this.editorText.Font.Style);
            }
        }

        /// <summary>
        /// Gets or sets the text color of the current text selection or insertion point.
        /// </summary>
        /// <value>The text color of the current text selection or insertion point.</value>
        public Color SelectionColor
        {
            get { return this.editorText.SelectionColor; }
            set { this.editorText.SelectionColor = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the editor's selected text is bold.
        /// </summary>
        /// <value>Whether the selection should be bold.</value>
        public bool SelectionBold
        {
            get
            {
                return (this.editorText.SelectionFont.Style & FontStyle.Bold) == FontStyle.Bold;
            }

            set
            {
                FontStyle fs = this.editorText.SelectionFont.Style;

                if (value)
                {
                    fs |= FontStyle.Bold;
                }
                else
                {
                    fs ^= FontStyle.Bold;
                }

                this.editorText.SelectionFont = new Font(this.editorText.SelectionFont.Name, this.editorText.SelectionFont.Size, fs);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the editor's selected text is italic.
        /// </summary>
        /// <value>Whether the selection should be italic.</value>
        public bool SelectionItalic
        {
            get
            {
                return (this.editorText.SelectionFont.Style & FontStyle.Italic) == FontStyle.Italic;
            }

            set
            {
                FontStyle fs = this.editorText.SelectionFont.Style;

                if (value)
                {
                    fs |= FontStyle.Italic;
                }
                else
                {
                    fs ^= FontStyle.Italic;
                }

                this.editorText.SelectionFont = new Font(this.editorText.SelectionFont.Name, this.editorText.SelectionFont.Size, fs);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the editor's selected text is underlined.
        /// </summary>
        /// <value>Whether the selection should be underlined.</value>
        public bool SelectionUnderline
        {
            get
            {
                return (this.editorText.SelectionFont.Style & FontStyle.Underline) == FontStyle.Underline;
            }

            set
            {
                FontStyle fs = this.editorText.SelectionFont.Style;

                if (value)
                {
                    fs |= FontStyle.Underline;
                }
                else
                {
                    fs ^= FontStyle.Underline;
                }

                this.editorText.SelectionFont = new Font(this.editorText.SelectionFont.Name, this.editorText.SelectionFont.Size, fs);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the bullet style is applied to the current selection or insertion point.
        /// </summary>
        /// <value>Whether the selection should be bulleted.</value>
        public bool SelectionBullet
        {
            get { return this.editorText.SelectionBullet; }
            set { this.editorText.SelectionBullet = value; }
        }

        /// <summary>
        /// Gets or sets the background color of the editor window.
        /// </summary>
        /// <value>The background color of the editor window.</value>
        public Color BackgroundColor
        {
            get { return this.editorText.BackColor; }
            set { this.editorText.BackColor = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the document has unsaved changes.
        /// </summary>
        /// <value>
        /// True if the document's state should be set so that
        /// it has unsaved changes, or false if it does not.
        /// </value>
        private bool Dirty
        {
            get
            {
                return this.dirty;
            }

            set
            {
                // Set the document state to dirty
                this.dirty = value;

                // If this is a file that's been open or
                // has previously been saved, place an asterisk
                // next to its title to show it has unsaved changes
                if (this.filename != null)
                {
                    this.Text = this.filename + (value ? "*" : string.Empty);
                }
            }
        }

        /// <summary>
        /// Saves the document.
        /// </summary>
        public void SaveDocument()
        {
            if (this.filename == null)
            {
                this.SaveDocumentAs();
            }
            else
            {
                this.editorText.SaveFile(this.filename, EditorWindow.GetStreamType(this.saveDocumentDialog.FilterIndex));
                this.Dirty = false;
            }
        }

        /// <summary>
        /// Saves the document, prompting the user for a file name.
        /// </summary>
        public void SaveDocumentAs()
        {
            if (this.saveDocumentDialog.ShowDialog() == DialogResult.OK)
            {
                this.editorText.SaveFile(this.saveDocumentDialog.FileName, EditorWindow.GetStreamType(this.saveDocumentDialog.FilterIndex));
                this.filename = this.saveDocumentDialog.FileName;
                this.Dirty = false;
            }
        }

        /// <summary>
        /// Prints the document.
        /// </summary>
        public void PrintDocument()
        {
            // Perhaps in a future expansion...
            throw new NotImplementedException("PrintDocument() not implemented");
        }

        /// <summary>
        /// Shows a print preview of the document.
        /// </summary>
        public void PrintPreviewDocument()
        {
            // Perhaps in a future expansion...
            throw new NotImplementedException("PrintPreviewDocument() not implemented");
        }

        /// <summary>
        /// Undo the last editor action.
        /// </summary>
        public void UndoAction()
        {
            this.editorText.Undo();
        }

        /// <summary>
        /// Redo the last editor action that was undone.
        /// </summary>
        public void RedoAction()
        {
            this.editorText.Redo();
        }

        /// <summary>
        /// Cut the currently selected text.
        /// </summary>
        public void CutText()
        {
            this.editorText.Cut();
        }

        /// <summary>
        /// Copy the currently selected text.
        /// </summary>
        public void CopyText()
        {
            this.editorText.Copy();
        }

        /// <summary>
        /// Paste the clipboard contents into the document.
        /// </summary>
        public void PasteText()
        {
            this.editorText.Paste();
        }

        /// <summary>
        /// Select all text in the document.
        /// </summary>
        public void SelectAllText()
        {
            this.editorText.SelectAll();
        }

        /// <summary>
        /// Gets the name of the current undo action.
        /// </summary>
        /// <returns>The name of the current undo action.</returns>
        public string UndoActionName()
        {
            return this.editorText.UndoActionName;
        }

        /// <summary>
        /// Gets the name of the current redo action.
        /// </summary>
        /// <returns>The name of the current redo action.</returns>
        public string RedoActionName()
        {
            return this.editorText.RedoActionName;
        }

        /// <summary>
        /// Prompts the user to save the document when it receives a close message.
        /// </summary>
        /// <param name="e">The event arguments.</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.Dirty)
            {
                DialogResult result = MessageBox.Show("Do you wish to save changes to this document?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RtlReading : 0);
                if (result == DialogResult.Yes)
                {
                    this.SaveDocument();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Gets the stream type for a particular save file filter index.
        /// </summary>
        /// <param name="filterIndex">The filter index.</param>
        /// <returns>The stream type corresponding to the given filter index.</returns>
        private static RichTextBoxStreamType GetStreamType(int filterIndex)
        {
            switch (filterIndex)
            {
                case 1:
                    return RichTextBoxStreamType.RichText;
                case 2:
                    return RichTextBoxStreamType.PlainText;
                case 3:
                    return RichTextBoxStreamType.UnicodePlainText;
                default:
                    throw new InvalidOperationException("Unrecognized stream type.");
            }
        }

        /// <summary>
        /// Executed when the text in the editor has changed.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void EditorText_TextChanged(object sender, EventArgs e)
        {
            this.Dirty = true;
            this.OnChangeAction();
        }

        /// <summary>
        /// Executed when any change to the editor text window occurs.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void EditorText_SomethingChanged(object sender, EventArgs e)
        {
            this.OnChangeAction();
        }

        /// <summary>
        /// Executed when any keys are pressed down or released in the editor text window.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void EditorText_KeyUpDown(object sender, KeyEventArgs e)
        {
            this.OnChangeAction();
        }

        /// <summary>
        /// Executed when any keys are pressed and released in the editor text window.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void EditorText_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnChangeAction();
        }

        /// <summary>
        /// Called by the various action methods to perform actions upon a state change.
        /// </summary>
        private void OnChangeAction()
        {
            if (this.UpdateReceived != null)
            {
                this.UpdateReceived(this, EventArgs.Empty);
            }
        }
    }
}
