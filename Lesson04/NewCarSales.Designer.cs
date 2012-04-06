namespace IntermediateCSharp.Lesson04
{
    /// <summary>
    /// The Windows Forms initialization of the New Car Sales calculator main class.
    /// </summary>
    public partial class NewCarSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// The power windows check box.
        /// </summary>
        private System.Windows.Forms.CheckBox checkBoxPowerWindows;

        /// <summary>
        /// The air conditioning check box.
        /// </summary>
        private System.Windows.Forms.CheckBox checkBoxAirConditioning;

        /// <summary>
        /// The chrome check box.
        /// </summary>
        private System.Windows.Forms.CheckBox checkBoxChrome;

        /// <summary>
        /// The title label.
        /// </summary>
        private System.Windows.Forms.Label labelDescription;

        /// <summary>
        /// The calculate button.
        /// </summary>
        private System.Windows.Forms.Button buttonCalculateCost;

        /// <summary>
        /// The cost label.
        /// </summary>
        private System.Windows.Forms.Label labelCost;

        /// <summary>
        /// The account type group box.
        /// </summary>
        private System.Windows.Forms.GroupBox groupBoxAccountType;

        /// <summary>
        /// The car colour group box.
        /// </summary>
        private System.Windows.Forms.GroupBox groupBoxColour;

        /// <summary>
        /// The business account radio button.
        /// </summary>
        private System.Windows.Forms.RadioButton radioButtonAcctBusiness;

        /// <summary>
        /// The personal account radio button.
        /// </summary>
        private System.Windows.Forms.RadioButton radioButtonAcctPersonal;

        /// <summary>
        /// The white car colour radio button.
        /// </summary>
        private System.Windows.Forms.RadioButton radioButtonColourWhite;

        /// <summary>
        /// The blue car colour radio button.
        /// </summary>
        private System.Windows.Forms.RadioButton radioButtonColourBlue;

        /// <summary>
        /// The name text box.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxName;

        /// <summary>
        /// The name label.
        /// </summary>
        private System.Windows.Forms.Label labelName;

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
            this.checkBoxPowerWindows = new System.Windows.Forms.CheckBox();
            this.checkBoxAirConditioning = new System.Windows.Forms.CheckBox();
            this.checkBoxChrome = new System.Windows.Forms.CheckBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonCalculateCost = new System.Windows.Forms.Button();
            this.labelCost = new System.Windows.Forms.Label();
            this.groupBoxAccountType = new System.Windows.Forms.GroupBox();
            this.radioButtonAcctBusiness = new System.Windows.Forms.RadioButton();
            this.radioButtonAcctPersonal = new System.Windows.Forms.RadioButton();
            this.groupBoxColour = new System.Windows.Forms.GroupBox();
            this.radioButtonColourWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonColourBlue = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxAccountType.SuspendLayout();
            this.groupBoxColour.SuspendLayout();
            this.SuspendLayout();

            this.checkBoxPowerWindows.AutoSize = true;
            this.checkBoxPowerWindows.Checked = true;
            this.checkBoxPowerWindows.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBoxPowerWindows.Location = new System.Drawing.Point(82, 97);
            this.checkBoxPowerWindows.Name = "checkBoxPowerWindows";
            this.checkBoxPowerWindows.Size = new System.Drawing.Size(100, 17);
            this.checkBoxPowerWindows.TabIndex = 3;
            this.checkBoxPowerWindows.Text = "Power windows";
            this.checkBoxPowerWindows.UseVisualStyleBackColor = true;

            this.checkBoxAirConditioning.AutoSize = true;
            this.checkBoxAirConditioning.Checked = true;
            this.checkBoxAirConditioning.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBoxAirConditioning.Location = new System.Drawing.Point(82, 120);
            this.checkBoxAirConditioning.Name = "checkBoxAirConditioning";
            this.checkBoxAirConditioning.Size = new System.Drawing.Size(98, 17);
            this.checkBoxAirConditioning.TabIndex = 4;
            this.checkBoxAirConditioning.Text = "Air conditioning";
            this.checkBoxAirConditioning.UseVisualStyleBackColor = true;

            this.checkBoxChrome.AutoSize = true;
            this.checkBoxChrome.Checked = true;
            this.checkBoxChrome.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBoxChrome.Location = new System.Drawing.Point(82, 143);
            this.checkBoxChrome.Name = "checkBoxChrome";
            this.checkBoxChrome.Size = new System.Drawing.Size(62, 17);
            this.checkBoxChrome.TabIndex = 5;
            this.checkBoxChrome.Text = "Chrome";
            this.checkBoxChrome.UseVisualStyleBackColor = true;

            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.labelDescription.Location = new System.Drawing.Point(147, 9);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(201, 58);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Choose from the\r\nfollowing options:";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.buttonCalculateCost.Location = new System.Drawing.Point(197, 166);
            this.buttonCalculateCost.Name = "buttonCalculateCost";
            this.buttonCalculateCost.Size = new System.Drawing.Size(100, 23);
            this.buttonCalculateCost.TabIndex = 8;
            this.buttonCalculateCost.Text = "&Calculate Cost";
            this.buttonCalculateCost.UseVisualStyleBackColor = true;
            this.buttonCalculateCost.Click += new System.EventHandler(this.ButtonCalculateCost_Click);

            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.labelCost.Location = new System.Drawing.Point(12, 192);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(470, 37);
            this.labelCost.TabIndex = 9;
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.groupBoxAccountType.Controls.Add(this.radioButtonAcctBusiness);
            this.groupBoxAccountType.Controls.Add(this.radioButtonAcctPersonal);
            this.groupBoxAccountType.Location = new System.Drawing.Point(188, 96);
            this.groupBoxAccountType.Name = "groupBoxAccountType";
            this.groupBoxAccountType.Size = new System.Drawing.Size(103, 65);
            this.groupBoxAccountType.TabIndex = 6;
            this.groupBoxAccountType.TabStop = false;
            this.groupBoxAccountType.Text = "Account type";
 
            this.radioButtonAcctBusiness.AutoSize = true;
            this.radioButtonAcctBusiness.Location = new System.Drawing.Point(6, 42);
            this.radioButtonAcctBusiness.Name = "radioButtonAcctBusiness";
            this.radioButtonAcctBusiness.Size = new System.Drawing.Size(67, 17);
            this.radioButtonAcctBusiness.TabIndex = 1;
            this.radioButtonAcctBusiness.TabStop = true;
            this.radioButtonAcctBusiness.Text = "Business";
            this.radioButtonAcctBusiness.UseVisualStyleBackColor = true;

            this.radioButtonAcctPersonal.AutoSize = true;
            this.radioButtonAcctPersonal.Checked = true;
            this.radioButtonAcctPersonal.Location = new System.Drawing.Point(6, 19);
            this.radioButtonAcctPersonal.Name = "radioButtonAcctPersonal";
            this.radioButtonAcctPersonal.Size = new System.Drawing.Size(66, 17);
            this.radioButtonAcctPersonal.TabIndex = 0;
            this.radioButtonAcctPersonal.TabStop = true;
            this.radioButtonAcctPersonal.Text = "Personal";
            this.radioButtonAcctPersonal.UseVisualStyleBackColor = true;

            this.groupBoxColour.Controls.Add(this.radioButtonColourWhite);
            this.groupBoxColour.Controls.Add(this.radioButtonColourBlue);
            this.groupBoxColour.Location = new System.Drawing.Point(297, 96);
            this.groupBoxColour.Name = "groupBoxColour";
            this.groupBoxColour.Size = new System.Drawing.Size(115, 65);
            this.groupBoxColour.TabIndex = 7;
            this.groupBoxColour.TabStop = false;
            this.groupBoxColour.Text = "Colour";

            this.radioButtonColourWhite.AutoSize = true;
            this.radioButtonColourWhite.Location = new System.Drawing.Point(6, 42);
            this.radioButtonColourWhite.Name = "radioButtonColourWhite";
            this.radioButtonColourWhite.Size = new System.Drawing.Size(53, 17);
            this.radioButtonColourWhite.TabIndex = 1;
            this.radioButtonColourWhite.TabStop = true;
            this.radioButtonColourWhite.Text = "White";
            this.radioButtonColourWhite.UseVisualStyleBackColor = true;

            this.radioButtonColourBlue.AutoSize = true;
            this.radioButtonColourBlue.Location = new System.Drawing.Point(6, 19);
            this.radioButtonColourBlue.Name = "radioButtonColourBlue";
            this.radioButtonColourBlue.Size = new System.Drawing.Size(46, 17);
            this.radioButtonColourBlue.TabIndex = 0;
            this.radioButtonColourBlue.TabStop = true;
            this.radioButtonColourBlue.Text = "Blue";
            this.radioButtonColourBlue.UseVisualStyleBackColor = true;

            this.textBoxName.Location = new System.Drawing.Point(219, 70);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;

            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(175, 73);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "&Name:";

            this.AcceptButton = this.buttonCalculateCost;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 238);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.groupBoxColour);
            this.Controls.Add(this.groupBoxAccountType);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.buttonCalculateCost);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.checkBoxChrome);
            this.Controls.Add(this.checkBoxAirConditioning);
            this.Controls.Add(this.checkBoxPowerWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewCarSalesGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Car Sales";
            this.groupBoxAccountType.ResumeLayout(false);
            this.groupBoxAccountType.PerformLayout();
            this.groupBoxColour.ResumeLayout(false);
            this.groupBoxColour.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
