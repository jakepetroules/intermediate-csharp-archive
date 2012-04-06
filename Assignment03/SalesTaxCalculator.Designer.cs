namespace IntermediateCSharp.Assignment03
{
    /// <summary>
    /// The Windows Forms initialization of the Sales Tax Calculator main class.
    /// </summary>
    public partial class SalesTaxCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// The price label.
        /// </summary>
        private System.Windows.Forms.Label labelPrice;

        /// <summary>
        /// The tax amount label.
        /// </summary>
        private System.Windows.Forms.Label labelTax;

        /// <summary>
        /// The price text box.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxPrice;

        /// <summary>
        /// The tax amount text box.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxTax;

        /// <summary>
        /// The calculate button.
        /// </summary>
        private System.Windows.Forms.Button buttonCalculate;

        /// <summary>
        /// The clear button.
        /// </summary>
        private System.Windows.Forms.Button buttonClear;

        /// <summary>
        /// The exit button.
        /// </summary>
        private System.Windows.Forms.Button buttonExit;

        /// <summary>
        /// The output text.
        /// </summary>
        private System.Windows.Forms.Label labelOutput;

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesTaxCalculator));
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.labelPrice.AccessibleDescription = null;
            this.labelPrice.AccessibleName = null;
            resources.ApplyResources(this.labelPrice, "labelPrice");
            this.labelPrice.Font = null;
            this.labelPrice.Name = "labelPrice";

            this.labelTax.AccessibleDescription = null;
            this.labelTax.AccessibleName = null;
            resources.ApplyResources(this.labelTax, "labelTax");
            this.labelTax.Font = null;
            this.labelTax.Name = "labelTax";

            this.buttonCalculate.AccessibleDescription = null;
            this.buttonCalculate.AccessibleName = null;
            resources.ApplyResources(this.buttonCalculate, "buttonCalculate");
            this.buttonCalculate.BackgroundImage = null;
            this.buttonCalculate.Font = null;
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);

            this.textBoxPrice.AccessibleDescription = null;
            this.textBoxPrice.AccessibleName = null;
            resources.ApplyResources(this.textBoxPrice, "textBoxPrice");
            this.textBoxPrice.BackgroundImage = null;
            this.textBoxPrice.Font = null;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Click += new System.EventHandler(this.TextBoxPrice_Click);
            this.textBoxPrice.Enter += new System.EventHandler(this.TextBoxPrice_Enter);

            this.textBoxTax.AccessibleDescription = null;
            this.textBoxTax.AccessibleName = null;
            resources.ApplyResources(this.textBoxTax, "textBoxTax");
            this.textBoxTax.BackgroundImage = null;
            this.textBoxTax.Font = null;
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.Click += new System.EventHandler(this.TextBoxTax_Click);
            this.textBoxTax.Enter += new System.EventHandler(this.TextBoxTax_Enter);

            this.labelOutput.AccessibleDescription = null;
            this.labelOutput.AccessibleName = null;
            resources.ApplyResources(this.labelOutput, "labelOutput");
            this.labelOutput.Font = null;
            this.labelOutput.Name = "labelOutput";

            this.buttonClear.AccessibleDescription = null;
            this.buttonClear.AccessibleName = null;
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.BackgroundImage = null;
            this.buttonClear.Font = null;
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);

            this.buttonExit.AccessibleDescription = null;
            this.buttonExit.AccessibleName = null;
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.BackgroundImage = null;
            this.buttonExit.Font = null;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);

            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxTax);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelPrice);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = null;
            this.MaximizeBox = false;
            this.Name = "CalculatorGui";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
