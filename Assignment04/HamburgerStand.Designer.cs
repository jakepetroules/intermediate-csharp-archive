namespace IntermediateCSharp.Assignment04
{
    /// <summary>
    /// The Windows Forms initialization of the Hamburger Stand main class.
    /// </summary>
    public partial class HamburgerStand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// The hamburger check box.
        /// </summary>
        private System.Windows.Forms.CheckBox checkBoxHamburger;

        /// <summary>
        /// The fries check box.
        /// </summary>
        private System.Windows.Forms.CheckBox checkBoxFries;

        /// <summary>
        /// The drink check box.
        /// </summary>
        private System.Windows.Forms.CheckBox checkBoxDrink;

        /// <summary>
        /// The cake radio button.
        /// </summary>
        private System.Windows.Forms.RadioButton radioButtonDessertCake;

        /// <summary>
        /// The ice cream radio button.
        /// </summary>
        private System.Windows.Forms.RadioButton radioButtonDessertIceCream;

        /// <summary>
        /// The dessert group box.
        /// </summary>
        private System.Windows.Forms.GroupBox groupBoxDessert;

        /// <summary>
        /// The calculate cost button.
        /// </summary>
        private System.Windows.Forms.Button buttonCalculate;

        /// <summary>
        /// The application title label.
        /// </summary>
        private System.Windows.Forms.Label labelTitle;

        /// <summary>
        /// The order cost label.
        /// </summary>
        private System.Windows.Forms.Label labelCost;

        /// <summary>
        /// The no dessert radio button.
        /// </summary>
        private System.Windows.Forms.RadioButton radioButtonDessertNone;

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
            this.groupBoxDessert = new System.Windows.Forms.GroupBox();
            this.radioButtonDessertNone = new System.Windows.Forms.RadioButton();
            this.radioButtonDessertCake = new System.Windows.Forms.RadioButton();
            this.radioButtonDessertIceCream = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.checkBoxDrink = new System.Windows.Forms.CheckBox();
            this.checkBoxFries = new System.Windows.Forms.CheckBox();
            this.checkBoxHamburger = new System.Windows.Forms.CheckBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.groupBoxDessert.SuspendLayout();
            this.SuspendLayout();

            this.groupBoxDessert.Controls.Add(this.radioButtonDessertNone);
            this.groupBoxDessert.Controls.Add(this.radioButtonDessertCake);
            this.groupBoxDessert.Controls.Add(this.radioButtonDessertIceCream);
            this.groupBoxDessert.Location = new System.Drawing.Point(51, 198);
            this.groupBoxDessert.Name = "groupBoxDessert";
            this.groupBoxDessert.Size = new System.Drawing.Size(293, 73);
            this.groupBoxDessert.TabIndex = 4;
            this.groupBoxDessert.TabStop = false;
            this.groupBoxDessert.Text = "Dessert (free!)";

            this.radioButtonDessertNone.AutoSize = true;
            this.radioButtonDessertNone.Location = new System.Drawing.Point(6, 35);
            this.radioButtonDessertNone.Name = "radioButtonDessertNone";
            this.radioButtonDessertNone.Size = new System.Drawing.Size(51, 17);
            this.radioButtonDessertNone.TabIndex = 0;
            this.radioButtonDessertNone.TabStop = true;
            this.radioButtonDessertNone.Text = "None";
            this.radioButtonDessertNone.UseVisualStyleBackColor = true;

            this.radioButtonDessertCake.AutoSize = true;
            this.radioButtonDessertCake.Image = global::IntermediateCSharp.Assignment04.Properties.Resources.cake;
            this.radioButtonDessertCake.Location = new System.Drawing.Point(63, 19);
            this.radioButtonDessertCake.Name = "radioButtonDessertCake";
            this.radioButtonDessertCake.Size = new System.Drawing.Size(98, 48);
            this.radioButtonDessertCake.TabIndex = 1;
            this.radioButtonDessertCake.TabStop = true;
            this.radioButtonDessertCake.Text = "Cake";
            this.radioButtonDessertCake.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButtonDessertCake.UseVisualStyleBackColor = true;

            this.radioButtonDessertIceCream.AutoSize = true;
            this.radioButtonDessertIceCream.Image = global::IntermediateCSharp.Assignment04.Properties.Resources.ice_cream;
            this.radioButtonDessertIceCream.Location = new System.Drawing.Point(167, 19);
            this.radioButtonDessertIceCream.Name = "radioButtonDessertIceCream";
            this.radioButtonDessertIceCream.Size = new System.Drawing.Size(120, 48);
            this.radioButtonDessertIceCream.TabIndex = 2;
            this.radioButtonDessertIceCream.TabStop = true;
            this.radioButtonDessertIceCream.Text = "Ice cream";
            this.radioButtonDessertIceCream.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButtonDessertIceCream.UseVisualStyleBackColor = true;

            this.buttonCalculate.Location = new System.Drawing.Point(147, 277);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 23);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate Cost";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);

            this.checkBoxDrink.AutoSize = true;
            this.checkBoxDrink.Image = global::IntermediateCSharp.Assignment04.Properties.Resources.soda;
            this.checkBoxDrink.Location = new System.Drawing.Point(116, 144);
            this.checkBoxDrink.Name = "checkBoxDrink";
            this.checkBoxDrink.Size = new System.Drawing.Size(135, 48);
            this.checkBoxDrink.TabIndex = 3;
            this.checkBoxDrink.Text = "Drink - $1.00";
            this.checkBoxDrink.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxDrink.UseVisualStyleBackColor = true;

            this.checkBoxFries.AutoSize = true;
            this.checkBoxFries.Image = global::IntermediateCSharp.Assignment04.Properties.Resources.fries;
            this.checkBoxFries.Location = new System.Drawing.Point(116, 90);
            this.checkBoxFries.Name = "checkBoxFries";
            this.checkBoxFries.Size = new System.Drawing.Size(132, 48);
            this.checkBoxFries.TabIndex = 2;
            this.checkBoxFries.Text = "Fries - $1.50";
            this.checkBoxFries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxFries.UseVisualStyleBackColor = true;

            this.checkBoxHamburger.AutoSize = true;
            this.checkBoxHamburger.Image = global::IntermediateCSharp.Assignment04.Properties.Resources.hamburger;
            this.checkBoxHamburger.Location = new System.Drawing.Point(116, 36);
            this.checkBoxHamburger.Name = "checkBoxHamburger";
            this.checkBoxHamburger.Size = new System.Drawing.Size(162, 48);
            this.checkBoxHamburger.TabIndex = 1;
            this.checkBoxHamburger.Text = "Hamburger - $2.00";
            this.checkBoxHamburger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxHamburger.UseVisualStyleBackColor = true;

            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.labelTitle.Location = new System.Drawing.Point(54, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(287, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Choose menu items and dessert:";

            this.labelCost.Location = new System.Drawing.Point(12, 303);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(370, 23);
            this.labelCost.TabIndex = 6;
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 338);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxDessert);
            this.Controls.Add(this.checkBoxDrink);
            this.Controls.Add(this.checkBoxFries);
            this.Controls.Add(this.checkBoxHamburger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HamburgerStandGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hamburger Stand";
            this.groupBoxDessert.ResumeLayout(false);
            this.groupBoxDessert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
