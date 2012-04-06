namespace IntermediateCSharp.Lesson08
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class ExceptionHandling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.NumericUpDown numericUpDownNumerator;
        private System.Windows.Forms.NumericUpDown numericUpDownDenominator;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox groupBoxOperation;
        private System.Windows.Forms.RadioButton radioButtonDivide;
        private System.Windows.Forms.RadioButton radioButtonMultiply;
        private System.Windows.Forms.RadioButton radioButtonSubtract;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.Button buttonCopyResult;

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
            this.buttonGo = new System.Windows.Forms.Button();
            this.numericUpDownNumerator = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDenominator = new System.Windows.Forms.NumericUpDown();
            this.labelResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxOperation = new System.Windows.Forms.GroupBox();
            this.radioButtonDivide = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiply = new System.Windows.Forms.RadioButton();
            this.radioButtonSubtract = new System.Windows.Forms.RadioButton();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.buttonCopyResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumerator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDenominator)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.groupBoxOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonGo.Location = new System.Drawing.Point(303, 55);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(140, 23);
            this.buttonGo.TabIndex = 3;
            this.buttonGo.Text = "Calculate Result";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // numericUpDownNumerator
            // 
            this.tableLayoutPanel.SetColumnSpan(this.numericUpDownNumerator, 2);
            this.numericUpDownNumerator.DecimalPlaces = 99;
            this.numericUpDownNumerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownNumerator.Location = new System.Drawing.Point(103, 3);
            this.numericUpDownNumerator.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericUpDownNumerator.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.numericUpDownNumerator.Name = "numericUpDownNumerator";
            this.numericUpDownNumerator.Size = new System.Drawing.Size(686, 20);
            this.numericUpDownNumerator.TabIndex = 1;
            // 
            // numericUpDownDenominator
            // 
            this.tableLayoutPanel.SetColumnSpan(this.numericUpDownDenominator, 2);
            this.numericUpDownDenominator.DecimalPlaces = 99;
            this.numericUpDownDenominator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownDenominator.Location = new System.Drawing.Point(103, 29);
            this.numericUpDownDenominator.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericUpDownDenominator.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.numericUpDownDenominator.Name = "numericUpDownDenominator";
            this.numericUpDownDenominator.Size = new System.Drawing.Size(686, 20);
            this.numericUpDownDenominator.TabIndex = 2;
            // 
            // labelResult
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelResult, 3);
            this.labelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(3, 81);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(786, 269);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "Result:";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.labelResult, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.buttonGo, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.numericUpDownNumerator, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.numericUpDownDenominator, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.groupBoxOperation, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonCopyResult, 2, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(792, 350);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // groupBoxOperation
            // 
            this.groupBoxOperation.Controls.Add(this.radioButtonDivide);
            this.groupBoxOperation.Controls.Add(this.radioButtonMultiply);
            this.groupBoxOperation.Controls.Add(this.radioButtonSubtract);
            this.groupBoxOperation.Controls.Add(this.radioButtonAdd);
            this.groupBoxOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOperation.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOperation.Name = "groupBoxOperation";
            this.tableLayoutPanel.SetRowSpan(this.groupBoxOperation, 3);
            this.groupBoxOperation.Size = new System.Drawing.Size(94, 75);
            this.groupBoxOperation.TabIndex = 0;
            this.groupBoxOperation.TabStop = false;
            this.groupBoxOperation.Text = "Operation";
            // 
            // radioButtonDivide
            // 
            this.radioButtonDivide.AutoSize = true;
            this.radioButtonDivide.Location = new System.Drawing.Point(52, 40);
            this.radioButtonDivide.Name = "radioButtonDivide";
            this.radioButtonDivide.Size = new System.Drawing.Size(31, 17);
            this.radioButtonDivide.TabIndex = 3;
            this.radioButtonDivide.TabStop = true;
            this.radioButtonDivide.Text = "÷";
            this.radioButtonDivide.UseVisualStyleBackColor = true;
            // 
            // radioButtonMultiply
            // 
            this.radioButtonMultiply.AutoSize = true;
            this.radioButtonMultiply.Location = new System.Drawing.Point(52, 17);
            this.radioButtonMultiply.Name = "radioButtonMultiply";
            this.radioButtonMultiply.Size = new System.Drawing.Size(31, 17);
            this.radioButtonMultiply.TabIndex = 2;
            this.radioButtonMultiply.TabStop = true;
            this.radioButtonMultiply.Text = "×";
            this.radioButtonMultiply.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubtract
            // 
            this.radioButtonSubtract.AutoSize = true;
            this.radioButtonSubtract.Location = new System.Drawing.Point(12, 40);
            this.radioButtonSubtract.Name = "radioButtonSubtract";
            this.radioButtonSubtract.Size = new System.Drawing.Size(34, 17);
            this.radioButtonSubtract.TabIndex = 1;
            this.radioButtonSubtract.TabStop = true;
            this.radioButtonSubtract.Text = "− ";
            this.radioButtonSubtract.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(12, 17);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(31, 17);
            this.radioButtonAdd.TabIndex = 0;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "+";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonCopyResult
            // 
            this.buttonCopyResult.Location = new System.Drawing.Point(449, 55);
            this.buttonCopyResult.Name = "buttonCopyResult";
            this.buttonCopyResult.Size = new System.Drawing.Size(140, 23);
            this.buttonCopyResult.TabIndex = 4;
            this.buttonCopyResult.Text = "Copy Result to Clipboard";
            this.buttonCopyResult.UseVisualStyleBackColor = true;
            this.buttonCopyResult.Click += new System.EventHandler(this.ButtonCopyResult_Click);
            // 
            // ExceptionHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 350);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "ExceptionHandling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exception Handling Demonstration";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumerator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDenominator)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.groupBoxOperation.ResumeLayout(false);
            this.groupBoxOperation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

