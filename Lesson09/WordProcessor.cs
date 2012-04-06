namespace IntermediateCSharp.Lesson09
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Text;
    using System.Globalization;
    using System.Windows.Forms;

    /// <summary>
    /// The main GUI class.
    /// </summary>
    public partial class WordProcessor : Form
    {
        /// <summary>
        /// List of the currently opened documents.
        /// </summary>
        private List<EditorWindow> editorWindows = new List<EditorWindow>();

        /// <summary>
        /// Initializes a new instance of the WordProcessor class.
        /// </summary>
        public WordProcessor()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets the currently active multiple-document interface (MDI) editor window.
        /// </summary>
        /// <returns>
        /// Returns an EditorWindow that represents the currently active
        /// MDI editor window, or null if there are currently no child windows present.
        /// </returns>
        private EditorWindow ActiveMdiEditorWindow
        {
            get
            {
                if (this.ActiveMdiChild == null)
                {
                    return null;
                }

                return (EditorWindow)this.ActiveMdiChild;
            }
        }

        /// <summary>
        /// Sets the image of the set background color button to a solid color the same as the editor window's current color.
        /// </summary>
        /// <param name="button">The button to set the color on.</param>
        /// <param name="color">The color to set.</param>
        private static void ToolStripButtonSetBackgroundColor(ToolStripButton button, Color color)
        {
            Bitmap bmp = new Bitmap(16, 16);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(color), new Rectangle(0, 0, bmp.Width, bmp.Height));

            button.Image = bmp;
        }
        
        /// <summary>
        /// Performs startup actions that must be done when the word processor loads.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void OnWordProcessorLoad(object sender, EventArgs e)
        {
            this.NewDocument(sender, e);

            InstalledFontCollection fonts = new InstalledFontCollection();
            for (int i = 0; i < fonts.Families.Length; i++)
            {
                this.toolStripComboBoxFont.Items.Add(fonts.Families[i].Name);
            }

            WordProcessor.ToolStripButtonSetBackgroundColor(this.toolStripButtonSetFontColor, Color.Black);
            WordProcessor.ToolStripButtonSetBackgroundColor(this.toolStripButtonSetBackgroundColor, Color.White);
        }

        /// <summary>
        /// Removes windows from the current windows list when they are closed.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void OnDocumentClosed(object sender, FormClosedEventArgs e)
        {
            this.editorWindows.Remove((EditorWindow)sender);
        }

        /// <summary>
        /// Executed when an update is received from an editor window.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void OnDocumentUpdateReceived(object sender, EventArgs e)
        {
            EditorWindow win = sender as EditorWindow;

            // If notifying window is current window, update UI.
            if (win != null && win == this.ActiveMdiEditorWindow)
            {
                this.toolStripComboBoxFont.Text = win.SelectionFont.Name;
                this.toolStripComboBoxFontSize.Text = win.SelectionFont.Size.ToString(CultureInfo.InvariantCulture);
                this.toolStripButtonBold.Checked = win.SelectionBold;
                this.toolStripButtonItalic.Checked = win.SelectionItalic;
                this.toolStripButtonUnderline.Checked = win.SelectionUnderline;
                this.toolStripButtonBullet.Checked = win.SelectionBullet;
                WordProcessor.ToolStripButtonSetBackgroundColor(this.toolStripButtonSetFontColor, win.SelectionColor);
                WordProcessor.ToolStripButtonSetBackgroundColor(this.toolStripButtonSetBackgroundColor, win.BackgroundColor);
            }
        }

        /// <summary>
        /// Creates a new blank document.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void NewDocument(object sender, EventArgs e)
        {
            EditorWindow editor = new EditorWindow();
            editor.MdiParent = this;
            editor.FormClosed += new FormClosedEventHandler(this.OnDocumentClosed);
            editor.UpdateReceived += new EventHandler(this.OnDocumentUpdateReceived);

            string windowTitle = String.Format(CultureInfo.InvariantCulture, "Document {0}", this.editorWindows.Count + 1);
            editor.Text = windowTitle;

            this.editorWindows.Add(editor);
            editor.Show();
        }

        /// <summary>
        /// Opens an existing document from a file.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void OpenDocument(object sender, EventArgs e)
        {
            if (this.openDocumentDialog.ShowDialog() == DialogResult.OK)
            {
                EditorWindow editor = new EditorWindow(this.openDocumentDialog.FileName);
                editor.MdiParent = this;
                editor.FormClosed += new FormClosedEventHandler(this.OnDocumentClosed);
                editor.UpdateReceived += new EventHandler(this.OnDocumentUpdateReceived);

                this.editorWindows.Add(editor);
                editor.Show();
            }
        }

        /// <summary>
        /// Asks the current document to close.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CloseDocument(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.ActiveMdiEditorWindow.Close();
            }
        }

        /// <summary>
        /// Asks the current document to save itself to file.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SaveDocument(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.ActiveMdiEditorWindow.SaveDocument();
            }
        }

        /// <summary>
        /// Asks the current document to prompt the user for a filename to save itself to.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SaveDocumentAs(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.ActiveMdiEditorWindow.SaveDocumentAs();
            }
        }

        /// <summary>
        /// Asks the current document to print itself.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PrintDocument(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.ActiveMdiEditorWindow.PrintDocument();
            }
        }

        /// <summary>
        /// Asks the current document to show a print preview of itself.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PrintPreviewDocument(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.ActiveMdiEditorWindow.PrintPreviewDocument();
            }
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Asks the current document to undo its last action.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void UndoAction(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.ActiveMdiEditorWindow.UndoAction();
            }
        }

        /// <summary>
        /// Asks the current document to redo its last action.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void RedoAction(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.ActiveMdiEditorWindow.RedoAction();
            }
        }

        /// <summary>
        /// Asks the current document to cut the selected text and place it in the clipboard.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CutText(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.ActiveMdiEditorWindow.CutText();
            }
        }

        /// <summary>
        /// Asks the current document to copy the selected text and place it in the clipboard.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CopyText(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.ActiveMdiEditorWindow.CopyText();
            }
        }

        /// <summary>
        /// Asks the current document to paste the contents of the clipboard into the document at the caret position.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PasteText(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.ActiveMdiEditorWindow.PasteText();
            }
        }

        /// <summary>
        /// Asks the current document to select all its text.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SelectAllText(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.ActiveMdiEditorWindow.SelectAllText();
            }
        }

        /// <summary>
        /// Displays a tooltip with the last undo action name on the menu item and toolbar button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void UndoToolStripSplitButton_MouseEnter(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null && !string.IsNullOrEmpty(this.ActiveMdiEditorWindow.UndoActionName()))
            {
                string text = String.Format(CultureInfo.InvariantCulture, "Undo '{0}'", this.ActiveMdiEditorWindow.UndoActionName());
                this.undoToolStripMenuItem.ToolTipText = text;
                this.undoToolStripSplitButton.ToolTipText = text;
            }
        }

        /// <summary>
        /// Displays a tooltip with the last redo action name on the menu item and toolbar button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void RedoToolStripSplitButton_MouseEnter(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null && !string.IsNullOrEmpty(this.ActiveMdiEditorWindow.RedoActionName()))
            {
                string text = String.Format(CultureInfo.InvariantCulture, "Redo '{0}'", this.ActiveMdiEditorWindow.RedoActionName());
                this.redoToolStripMenuItem.ToolTipText = text;
                this.redoToolStripSplitButton.ToolTipText = text;
            }
        }

        /// <summary>
        /// Asks the current document to change its font.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ToolStripComboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                FontStyle fontStyle = FontStyle.Regular;

                if (this.toolStripButtonBold.Checked)
                {
                    fontStyle |= FontStyle.Bold;
                }

                if (this.toolStripButtonItalic.Checked)
                {
                    fontStyle |= FontStyle.Italic;
                }

                if (this.toolStripButtonUnderline.Checked)
                {
                    fontStyle |= FontStyle.Underline;
                }

                try
                {
                    this.ActiveMdiEditorWindow.SelectionFont = new Font(this.toolStripComboBoxFont.Text, (float)Convert.ToDouble(this.toolStripComboBoxFontSize.Text, CultureInfo.InvariantCulture), fontStyle);
                }
                catch (ArgumentException ae)
                {
                    MessageBox.Show(ae.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
                }
            }
        }

        /// <summary>
        /// Asks the current document to change its font size.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ToolStripComboBoxFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.ActiveMdiEditorWindow.SelectionFontSize = (float)Convert.ToDouble(this.toolStripComboBoxFontSize.Text, CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Asks the current document to make its selected text bold.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ToolStripButtonBold_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.ActiveMdiEditorWindow.SelectionBold = this.toolStripButtonBold.Checked;
            }
        }

        /// <summary>
        /// Asks the current document to make its selected text italic.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ToolStripButtonItalic_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.ActiveMdiEditorWindow.SelectionItalic = this.toolStripButtonItalic.Checked;
            }
        }

        /// <summary>
        /// Asks the current document to make its selected text underlined.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ToolStripButtonUnderline_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.ActiveMdiEditorWindow.SelectionUnderline = this.toolStripButtonUnderline.Checked;
            }
        }

        /// <summary>
        /// Asks the current document to make its selected text bulleted.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ToolStripButtonBullet_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.ActiveMdiEditorWindow.SelectionBullet = this.toolStripButtonBullet.Checked;
            }
        }

        /// <summary>
        /// Sets the color of the current font selection.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ToolStripButtonSetFontColor_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.colorDialogEditorColor.Color = this.ActiveMdiEditorWindow.BackgroundColor;
                if (this.colorDialogEditorColor.ShowDialog() == DialogResult.OK)
                {
                    this.ActiveMdiEditorWindow.SelectionColor = this.colorDialogEditorColor.Color;

                    WordProcessor.ToolStripButtonSetBackgroundColor(this.toolStripButtonSetFontColor, this.colorDialogEditorColor.Color);
                }
            }
        }

        /// <summary>
        /// Sets the background color of the editor window.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ToolStripButtonSetBackgroundColor_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiEditorWindow != null)
            {
                this.colorDialogEditorColor.Color = this.ActiveMdiEditorWindow.BackgroundColor;
                if (this.colorDialogEditorColor.ShowDialog() == DialogResult.OK)
                {
                    this.ActiveMdiEditorWindow.BackgroundColor = this.colorDialogEditorColor.Color;

                    WordProcessor.ToolStripButtonSetBackgroundColor(this.toolStripButtonSetBackgroundColor, this.colorDialogEditorColor.Color);
                }
            }
        }
    }
}
