namespace IntermediateCSharp.Lesson10
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class DatabaseDemonstration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private L10_DatabaseDataSet databaseDemonstrationDatabaseDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private L10_DatabaseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private L10_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxID;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBalance;
        private System.Windows.Forms.ToolStrip fillByLastNameToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabelLastName;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxLastName;
        private System.Windows.Forms.ToolStripButton fillByLastNameToolStripButton;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label labelFirstName;
            System.Windows.Forms.Label labelID;
            System.Windows.Forms.Label labelLastName;
            System.Windows.Forms.Label labelPhoneNumber;
            System.Windows.Forms.Label labelBalance;
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDemonstrationDatabaseDataSet = new IntermediateCSharp.Lesson10.L10_DatabaseDataSet();
            this.maskedTextBoxID = new System.Windows.Forms.MaskedTextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxBalance = new System.Windows.Forms.MaskedTextBox();
            this.fillByLastNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelLastName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxLastName = new System.Windows.Forms.ToolStripTextBox();
            this.fillByLastNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.customerTableAdapter = new IntermediateCSharp.Lesson10.L10_DatabaseDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new IntermediateCSharp.Lesson10.L10_DatabaseDataSetTableAdapters.TableAdapterManager();
            labelFirstName = new System.Windows.Forms.Label();
            labelID = new System.Windows.Forms.Label();
            labelLastName = new System.Windows.Forms.Label();
            labelPhoneNumber = new System.Windows.Forms.Label();
            labelBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDemonstrationDatabaseDataSet)).BeginInit();
            this.fillByLastNameToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new System.Drawing.Point(114, 63);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new System.Drawing.Size(60, 13);
            labelFirstName.TabIndex = 3;
            labelFirstName.Text = "First Name:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new System.Drawing.Point(153, 37);
            labelID.Name = "labelID";
            labelID.Size = new System.Drawing.Size(21, 13);
            labelID.TabIndex = 1;
            labelID.Text = "ID:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new System.Drawing.Point(113, 89);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new System.Drawing.Size(61, 13);
            labelLastName.TabIndex = 5;
            labelLastName.Text = "Last Name:";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new System.Drawing.Point(93, 115);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new System.Drawing.Size(81, 13);
            labelPhoneNumber.TabIndex = 7;
            labelPhoneNumber.Text = "Phone Number:";
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Location = new System.Drawing.Point(125, 141);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new System.Drawing.Size(49, 13);
            labelBalance.TabIndex = 9;
            labelBalance.Text = "Balance:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "First Name", true));
            this.textBoxFirstName.Location = new System.Drawing.Point(180, 60);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.databaseDemonstrationDatabaseDataSet;
            // 
            // databaseDemonstrationDatabaseDataSet
            // 
            this.databaseDemonstrationDatabaseDataSet.DataSetName = "L10_DatabaseDataSet";
            this.databaseDemonstrationDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedTextBoxID
            // 
            this.maskedTextBoxID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "ID", true));
            this.maskedTextBoxID.Location = new System.Drawing.Point(180, 34);
            this.maskedTextBoxID.Mask = "00000";
            this.maskedTextBoxID.Name = "maskedTextBoxID";
            this.maskedTextBoxID.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxID.TabIndex = 2;
            this.maskedTextBoxID.ValidatingType = typeof(int);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Last Name", true));
            this.textBoxLastName.Location = new System.Drawing.Point(180, 86);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 6;
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Phone Number", true));
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(180, 112);
            this.maskedTextBoxPhoneNumber.Mask = "000-0000";
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPhoneNumber.TabIndex = 8;
            // 
            // maskedTextBoxBalance
            // 
            this.maskedTextBoxBalance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Balance", true));
            this.maskedTextBoxBalance.Location = new System.Drawing.Point(180, 138);
            this.maskedTextBoxBalance.Mask = "$0.00";
            this.maskedTextBoxBalance.Name = "maskedTextBoxBalance";
            this.maskedTextBoxBalance.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxBalance.TabIndex = 10;
            // 
            // fillByLastNameToolStrip
            // 
            this.fillByLastNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelLastName,
            this.toolStripTextBoxLastName,
            this.fillByLastNameToolStripButton});
            this.fillByLastNameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByLastNameToolStrip.Name = "fillByLastNameToolStrip";
            this.fillByLastNameToolStrip.Size = new System.Drawing.Size(794, 25);
            this.fillByLastNameToolStrip.TabIndex = 0;
            this.fillByLastNameToolStrip.Text = "fillByLastNameToolStrip";
            // 
            // toolStripLabelLastName
            // 
            this.toolStripLabelLastName.Name = "toolStripLabelLastName";
            this.toolStripLabelLastName.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabelLastName.Text = "Last Name:";
            // 
            // toolStripTextBoxLastName
            // 
            this.toolStripTextBoxLastName.Name = "toolStripTextBoxLastName";
            this.toolStripTextBoxLastName.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByLastNameToolStripButton
            // 
            this.fillByLastNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByLastNameToolStripButton.Name = "fillByLastNameToolStripButton";
            this.fillByLastNameToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.fillByLastNameToolStripButton.Text = "Find Last Name";
            this.fillByLastNameToolStripButton.Click += new System.EventHandler(this.FillByLastNameToolStripButton_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.UpdateOrder = IntermediateCSharp.Lesson10.L10_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DatabaseDemonstration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.fillByLastNameToolStrip);
            this.Controls.Add(labelBalance);
            this.Controls.Add(this.maskedTextBoxBalance);
            this.Controls.Add(labelPhoneNumber);
            this.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.Controls.Add(labelLastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(labelID);
            this.Controls.Add(this.maskedTextBoxID);
            this.Controls.Add(labelFirstName);
            this.Controls.Add(this.textBoxFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DatabaseDemonstration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Demonstration";
            this.Load += new System.EventHandler(this.DatabaseDemonstrationGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDemonstrationDatabaseDataSet)).EndInit();
            this.fillByLastNameToolStrip.ResumeLayout(false);
            this.fillByLastNameToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

