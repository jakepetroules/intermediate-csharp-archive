namespace IntermediateCSharp.Lesson11
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class SiteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private websitesDataSet websitesDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private IntermediateCSharp.Lesson11.websitesDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private IntermediateCSharp.Lesson11.websitesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox categoryNameComboBox;
        private IntermediateCSharp.Lesson11.websitesDataSetTableAdapters.SiteTableAdapter siteTableAdapter;
        private System.Windows.Forms.TextBox textBoxSiteName;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelSiteName;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;

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
            System.Windows.Forms.Label categoryNameLabel;
            this.websitesDataSet = new IntermediateCSharp.Lesson11.websitesDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new IntermediateCSharp.Lesson11.websitesDataSetTableAdapters.CategoryTableAdapter();
            this.tableAdapterManager = new IntermediateCSharp.Lesson11.websitesDataSetTableAdapters.TableAdapterManager();
            this.siteTableAdapter = new IntermediateCSharp.Lesson11.websitesDataSetTableAdapters.SiteTableAdapter();
            this.categoryNameComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxSiteName = new System.Windows.Forms.TextBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelSiteName = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            categoryNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.websitesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.AutoSize = true;
            categoryNameLabel.Location = new System.Drawing.Point(12, 15);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new System.Drawing.Size(83, 13);
            categoryNameLabel.TabIndex = 0;
            categoryNameLabel.Text = "Category Name:";
            // 
            // websitesDataSet
            // 
            this.websitesDataSet.DataSetName = "websitesDataSet";
            this.websitesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.websitesDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.SiteTableAdapter = this.siteTableAdapter;
            this.tableAdapterManager.UpdateOrder = IntermediateCSharp.Lesson11.websitesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // categoryNameComboBox
            // 
            this.categoryNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "CategoryName", true));
            this.categoryNameComboBox.DataSource = this.websitesDataSet;
            this.categoryNameComboBox.DisplayMember = "Category.CategoryName";
            this.categoryNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryNameComboBox.FormattingEnabled = true;
            this.categoryNameComboBox.Location = new System.Drawing.Point(101, 12);
            this.categoryNameComboBox.Name = "categoryNameComboBox";
            this.categoryNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryNameComboBox.TabIndex = 1;
            this.categoryNameComboBox.ValueMember = "Category.CategoryID";
            // 
            // textBoxSiteName
            // 
            this.textBoxSiteName.Location = new System.Drawing.Point(101, 39);
            this.textBoxSiteName.Name = "textBoxSiteName";
            this.textBoxSiteName.Size = new System.Drawing.Size(121, 20);
            this.textBoxSiteName.TabIndex = 3;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(101, 65);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(121, 20);
            this.textBoxURL.TabIndex = 5;
            // 
            // labelSiteName
            // 
            this.labelSiteName.AutoSize = true;
            this.labelSiteName.Location = new System.Drawing.Point(12, 42);
            this.labelSiteName.Name = "labelSiteName";
            this.labelSiteName.Size = new System.Drawing.Size(59, 13);
            this.labelSiteName.TabIndex = 2;
            this.labelSiteName.Text = "Site Name:";
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(12, 68);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(32, 13);
            this.labelURL.TabIndex = 4;
            this.labelURL.Text = "URL:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(39, 91);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(120, 91);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // SiteForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(234, 128);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.labelSiteName);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.textBoxSiteName);
            this.Controls.Add(categoryNameLabel);
            this.Controls.Add(this.categoryNameComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SiteForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Website";
            this.Load += new System.EventHandler(this.SiteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.websitesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}