namespace IntermediateCSharp.Lesson09
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class EditorWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.RichTextBox editorText;
        private System.Windows.Forms.SaveFileDialog saveDocumentDialog;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.editorText = new System.Windows.Forms.RichTextBox();
            this.saveDocumentDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // editorText
            // 
            this.editorText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorText.Location = new System.Drawing.Point(0, 0);
            this.editorText.Name = "editorText";
            this.editorText.Size = new System.Drawing.Size(592, 416);
            this.editorText.TabIndex = 0;
            this.editorText.Text = string.Empty;
            this.editorText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditorText_KeyUpDown);
            this.editorText.SelectionChanged += new System.EventHandler(this.EditorText_SomethingChanged);
            this.editorText.Protected += new System.EventHandler(this.EditorText_SomethingChanged);
            this.editorText.Enter += new System.EventHandler(this.EditorText_SomethingChanged);
            this.editorText.DoubleClick += new System.EventHandler(this.EditorText_SomethingChanged);
            this.editorText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditorText_KeyPress);
            this.editorText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EditorText_KeyUpDown);
            this.editorText.TextChanged += new System.EventHandler(this.EditorText_TextChanged);
            this.editorText.Click += new System.EventHandler(this.EditorText_SomethingChanged);
            // 
            // saveDocumentDialog
            // 
            this.saveDocumentDialog.DefaultExt = "rtf";
            this.saveDocumentDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|Unicode Text Files (*.txt" +
                ")|*.txt";
            this.saveDocumentDialog.Title = "Save document";
            // 
            // EditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 416);
            this.Controls.Add(this.editorText);
            this.Name = "EditorWindow";
            this.Text = "EditorWindow";
            this.ResumeLayout(false);

        }

        #endregion
    }
}