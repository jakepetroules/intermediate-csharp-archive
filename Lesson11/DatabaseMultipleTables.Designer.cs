namespace IntermediateCSharp.Lesson11
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class DatabaseMultipleTables
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
        private System.Windows.Forms.BindingSource siteBindingSource;
        private System.Windows.Forms.ToolStrip toolStripCategory;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxCategory;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddCategory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveCategory;
        private System.Windows.Forms.ToolStrip toolStripWebsite;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddWebsite;
        private System.Windows.Forms.WebBrowser webBrowserNavigator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveWebsite;
        private System.Windows.Forms.ListBox siteNameListBox;

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
            System.Windows.Forms.Label siteNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseMultipleTables));
            this.websitesDataSet = new IntermediateCSharp.Lesson11.websitesDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new IntermediateCSharp.Lesson11.websitesDataSetTableAdapters.CategoryTableAdapter();
            this.tableAdapterManager = new IntermediateCSharp.Lesson11.websitesDataSetTableAdapters.TableAdapterManager();
            this.siteTableAdapter = new IntermediateCSharp.Lesson11.websitesDataSetTableAdapters.SiteTableAdapter();
            this.categoryNameComboBox = new System.Windows.Forms.ComboBox();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripCategory = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxCategory = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonAddCategory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRemoveCategory = new System.Windows.Forms.ToolStripButton();
            this.toolStripWebsite = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddWebsite = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRemoveWebsite = new System.Windows.Forms.ToolStripButton();
            this.webBrowserNavigator = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.siteNameListBox = new System.Windows.Forms.ListBox();
            categoryNameLabel = new System.Windows.Forms.Label();
            siteNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.websitesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            this.toolStripCategory.SuspendLayout();
            this.toolStripWebsite.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            categoryNameLabel.Location = new System.Drawing.Point(3, 0);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new System.Drawing.Size(94, 27);
            categoryNameLabel.TabIndex = 0;
            categoryNameLabel.Text = "Category Name:";
            categoryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // siteNameLabel
            // 
            siteNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            siteNameLabel.Location = new System.Drawing.Point(3, 27);
            siteNameLabel.Name = "siteNameLabel";
            siteNameLabel.Size = new System.Drawing.Size(94, 49);
            siteNameLabel.TabIndex = 2;
            siteNameLabel.Text = "Site Name:";
            siteNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.categoryNameComboBox.Location = new System.Drawing.Point(103, 3);
            this.categoryNameComboBox.Name = "categoryNameComboBox";
            this.categoryNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryNameComboBox.TabIndex = 1;
            this.categoryNameComboBox.ValueMember = "Category.CategoryID";
            this.categoryNameComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryNameComboBox_SelectedIndexChanged);
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataMember = "Site";
            this.siteBindingSource.DataSource = this.websitesDataSet;
            // 
            // toolStripCategory
            // 
            this.toolStripCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxCategory,
            this.toolStripButtonAddCategory,
            this.toolStripSeparator1,
            this.toolStripButtonRemoveCategory});
            this.toolStripCategory.Location = new System.Drawing.Point(0, 0);
            this.toolStripCategory.Name = "toolStripCategory";
            this.toolStripCategory.Size = new System.Drawing.Size(792, 25);
            this.toolStripCategory.TabIndex = 0;
            this.toolStripCategory.Text = "Categories";
            // 
            // toolStripTextBoxCategory
            // 
            this.toolStripTextBoxCategory.Name = "toolStripTextBoxCategory";
            this.toolStripTextBoxCategory.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonAddCategory
            // 
            this.toolStripButtonAddCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddCategory.Image")));
            this.toolStripButtonAddCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddCategory.Name = "toolStripButtonAddCategory";
            this.toolStripButtonAddCategory.Size = new System.Drawing.Size(76, 22);
            this.toolStripButtonAddCategory.Text = "Add category";
            this.toolStripButtonAddCategory.Click += new System.EventHandler(this.ToolStripButtonAddCategory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRemoveCategory
            // 
            this.toolStripButtonRemoveCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRemoveCategory.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemoveCategory.Image")));
            this.toolStripButtonRemoveCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveCategory.Name = "toolStripButtonRemoveCategory";
            this.toolStripButtonRemoveCategory.Size = new System.Drawing.Size(96, 22);
            this.toolStripButtonRemoveCategory.Text = "Remove category";
            this.toolStripButtonRemoveCategory.Click += new System.EventHandler(this.ToolStripButtonRemoveCategory_Click);
            // 
            // toolStripWebsite
            // 
            this.toolStripWebsite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddWebsite,
            this.toolStripSeparator2,
            this.toolStripButtonRemoveWebsite});
            this.toolStripWebsite.Location = new System.Drawing.Point(0, 25);
            this.toolStripWebsite.Name = "toolStripWebsite";
            this.toolStripWebsite.Size = new System.Drawing.Size(792, 25);
            this.toolStripWebsite.TabIndex = 1;
            this.toolStripWebsite.Text = "Websites";
            // 
            // toolStripButtonAddWebsite
            // 
            this.toolStripButtonAddWebsite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAddWebsite.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddWebsite.Image")));
            this.toolStripButtonAddWebsite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddWebsite.Name = "toolStripButtonAddWebsite";
            this.toolStripButtonAddWebsite.Size = new System.Drawing.Size(70, 22);
            this.toolStripButtonAddWebsite.Text = "Add website";
            this.toolStripButtonAddWebsite.Click += new System.EventHandler(this.ToolStripButtonAddWebsite_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRemoveWebsite
            // 
            this.toolStripButtonRemoveWebsite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRemoveWebsite.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemoveWebsite.Image")));
            this.toolStripButtonRemoveWebsite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveWebsite.Name = "toolStripButtonRemoveWebsite";
            this.toolStripButtonRemoveWebsite.Size = new System.Drawing.Size(90, 22);
            this.toolStripButtonRemoveWebsite.Text = "Remove website";
            this.toolStripButtonRemoveWebsite.Click += new System.EventHandler(this.ToolStripButtonRemoveWebsite_Click);
            // 
            // webBrowserNavigator
            // 
            this.tableLayoutPanel.SetColumnSpan(this.webBrowserNavigator, 2);
            this.webBrowserNavigator.DataBindings.Add(new System.Windows.Forms.Binding("Url", this.siteBindingSource, "URL", true));
            this.webBrowserNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserNavigator.Location = new System.Drawing.Point(3, 79);
            this.webBrowserNavigator.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserNavigator.Name = "webBrowserNavigator";
            this.webBrowserNavigator.ScriptErrorsSuppressed = true;
            this.webBrowserNavigator.Size = new System.Drawing.Size(786, 434);
            this.webBrowserNavigator.TabIndex = 4;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(categoryNameLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.webBrowserNavigator, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.categoryNameComboBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(siteNameLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.siteNameListBox, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(792, 516);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // siteNameListBox
            // 
            this.siteNameListBox.DataSource = this.siteBindingSource;
            this.siteNameListBox.DisplayMember = "SiteName";
            this.siteNameListBox.FormattingEnabled = true;
            this.siteNameListBox.Location = new System.Drawing.Point(103, 30);
            this.siteNameListBox.Name = "siteNameListBox";
            this.siteNameListBox.Size = new System.Drawing.Size(120, 43);
            this.siteNameListBox.TabIndex = 3;
            this.siteNameListBox.ValueMember = "SiteID";
            // 
            // DatabaseMultipleTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.toolStripWebsite);
            this.Controls.Add(this.toolStripCategory);
            this.Name = "DatabaseMultipleTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Demonstration with Multiple Tables";
            this.Load += new System.EventHandler(this.DatabaseMultiTableGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.websitesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            this.toolStripCategory.ResumeLayout(false);
            this.toolStripCategory.PerformLayout();
            this.toolStripWebsite.ResumeLayout(false);
            this.toolStripWebsite.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

