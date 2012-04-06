namespace IntermediateCSharp.Lesson08
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class DialogsDemonstration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.TextBox textBoxWriteData;
        private System.Windows.Forms.GroupBox groupBoxRead;
        private System.Windows.Forms.GroupBox groupBoxWrite;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRead;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWrite;
        private System.Windows.Forms.TextBox textBoxReadData;

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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonRead = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.textBoxWriteData = new System.Windows.Forms.TextBox();
            this.groupBoxRead = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelRead = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxReadData = new System.Windows.Forms.TextBox();
            this.groupBoxWrite = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelWrite = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxRead.SuspendLayout();
            this.tableLayoutPanelRead.SuspendLayout();
            this.groupBoxWrite.SuspendLayout();
            this.tableLayoutPanelWrite.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Add files (*.*)|*.*";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(3, 3);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(120, 23);
            this.buttonRead.TabIndex = 0;
            this.buttonRead.Text = "Read from file";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.ButtonRead_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "All files (*.*)|*.*";
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(3, 232);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(120, 23);
            this.buttonWrite.TabIndex = 1;
            this.buttonWrite.Text = "Write to file";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.ButtonWrite_Click);
            // 
            // textBoxWriteData
            // 
            this.textBoxWriteData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWriteData.Location = new System.Drawing.Point(3, 3);
            this.textBoxWriteData.Multiline = true;
            this.textBoxWriteData.Name = "textBoxWriteData";
            this.textBoxWriteData.Size = new System.Drawing.Size(774, 223);
            this.textBoxWriteData.TabIndex = 0;
            // 
            // groupBoxRead
            // 
            this.groupBoxRead.Controls.Add(this.tableLayoutPanelRead);
            this.groupBoxRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRead.Location = new System.Drawing.Point(3, 3);
            this.groupBoxRead.Name = "groupBoxRead";
            this.groupBoxRead.Size = new System.Drawing.Size(786, 277);
            this.groupBoxRead.TabIndex = 0;
            this.groupBoxRead.TabStop = false;
            this.groupBoxRead.Text = "Read from file";
            // 
            // tableLayoutPanelRead
            // 
            this.tableLayoutPanelRead.ColumnCount = 1;
            this.tableLayoutPanelRead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRead.Controls.Add(this.buttonRead, 0, 0);
            this.tableLayoutPanelRead.Controls.Add(this.textBoxReadData, 0, 1);
            this.tableLayoutPanelRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRead.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelRead.Name = "tableLayoutPanelRead";
            this.tableLayoutPanelRead.RowCount = 2;
            this.tableLayoutPanelRead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelRead.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRead.Size = new System.Drawing.Size(780, 258);
            this.tableLayoutPanelRead.TabIndex = 0;
            // 
            // textBoxReadData
            // 
            this.textBoxReadData.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxReadData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxReadData.Location = new System.Drawing.Point(3, 32);
            this.textBoxReadData.Multiline = true;
            this.textBoxReadData.Name = "textBoxReadData";
            this.textBoxReadData.ReadOnly = true;
            this.textBoxReadData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxReadData.Size = new System.Drawing.Size(774, 223);
            this.textBoxReadData.TabIndex = 1;
            // 
            // groupBoxWrite
            // 
            this.groupBoxWrite.Controls.Add(this.tableLayoutPanelWrite);
            this.groupBoxWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWrite.Location = new System.Drawing.Point(3, 286);
            this.groupBoxWrite.Name = "groupBoxWrite";
            this.groupBoxWrite.Size = new System.Drawing.Size(786, 277);
            this.groupBoxWrite.TabIndex = 1;
            this.groupBoxWrite.TabStop = false;
            this.groupBoxWrite.Text = "Write to file";
            // 
            // tableLayoutPanelWrite
            // 
            this.tableLayoutPanelWrite.ColumnCount = 1;
            this.tableLayoutPanelWrite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelWrite.Controls.Add(this.buttonWrite, 0, 1);
            this.tableLayoutPanelWrite.Controls.Add(this.textBoxWriteData, 0, 0);
            this.tableLayoutPanelWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWrite.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelWrite.Name = "tableLayoutPanelWrite";
            this.tableLayoutPanelWrite.RowCount = 2;
            this.tableLayoutPanelWrite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWrite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelWrite.Size = new System.Drawing.Size(780, 258);
            this.tableLayoutPanelWrite.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.groupBoxRead, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.groupBoxWrite, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(792, 566);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // DialogsDemonstration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "DialogsDemonstration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialogs Demonstration";
            this.groupBoxRead.ResumeLayout(false);
            this.tableLayoutPanelRead.ResumeLayout(false);
            this.tableLayoutPanelRead.PerformLayout();
            this.groupBoxWrite.ResumeLayout(false);
            this.tableLayoutPanelWrite.ResumeLayout(false);
            this.tableLayoutPanelWrite.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}