namespace IntermediateCSharp.Lesson11
{
    using System;
    using System.Data;
    using System.Globalization;
    using System.Windows.Forms;

    /// <summary>
    /// The DatabaseMultipleTables GUI class.
    /// </summary>
    public partial class DatabaseMultipleTables : Form
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseMultipleTables class.
        /// </summary>
        public DatabaseMultipleTables()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Performs actions that must be done when the form first loads.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void DatabaseMultiTableGui_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websitesDataSet.Site' table. You can move, or remove it, as needed.
            this.siteTableAdapter.Fill(this.websitesDataSet.Site);

            // TODO: This line of code loads data into the 'websitesDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.websitesDataSet.Category);

            this.FilterData();
        }

        /// <summary>
        /// Updates program state when the selected index of the category name combo box is changed.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CategoryNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FilterData();
        }

        /// <summary>
        /// Filters data database data according to selections on the GUI.
        /// </summary>
        private void FilterData()
        {
            try
            {
                this.siteBindingSource.Filter = "CategoryID = " + this.categoryNameComboBox.SelectedValue;
            }
            catch (SyntaxErrorException)
            {
            }
        }

        /// <summary>
        /// Adds a category to the database.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ToolStripButtonAddCategory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.toolStripTextBoxCategory.Text))
            {
                // Create an object for the new category row
                websitesDataSet.CategoryRow newCategory = this.websitesDataSet.Category.NewCategoryRow();
                newCategory.CategoryName = this.toolStripTextBoxCategory.Text;

                // Add the new category to the data set
                this.websitesDataSet.Category.AddCategoryRow(newCategory);

                // Update the database to reflect this new record
                this.categoryTableAdapter.Update(newCategory);

                // Cleanup
                MessageBox.Show("Category \"" + this.toolStripTextBoxCategory.Text + "\" was added.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
                this.toolStripTextBoxCategory.Text = string.Empty;

                // Refill the TableAdapter
                this.categoryTableAdapter.Fill(this.websitesDataSet.Category);
            }
            else
            {
                MessageBox.Show("You must type a category name to enter into the list!", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
            }
        }

        /// <summary>
        /// Removes a category from the database.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ToolStripButtonRemoveCategory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to delete the " + this.categoryNameComboBox.Text + " category and all of its contents. Do you wish to continue?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0) == DialogResult.Yes)
            {
                // Store category name for use in the message box later
                string deleletedName = this.categoryNameComboBox.Text;
                    
                // Store CategoryID for cleaner code
                int categoryID = Convert.ToInt32(this.categoryNameComboBox.SelectedValue, CultureInfo.InvariantCulture);
                
                // Create an array of items that have the CategoryID to be deleted
                websitesDataSet.SiteRow[] sites = (websitesDataSet.SiteRow[])this.websitesDataSet.Site.Select("CategoryID = " + categoryID);
                
                // Go through each website and delete it
                foreach (websitesDataSet.SiteRow deletingSite in sites)
                {
                    deletingSite.Delete();
                }

                this.siteTableAdapter.Update(this.websitesDataSet);
                
                // Delete the Category and search for the record by CategoryID and assign this record to a CategoryRow object
                websitesDataSet.CategoryRow deletingCategory = this.websitesDataSet.Category.FindByCategoryID(categoryID);
                deletingCategory.Delete();
                this.categoryTableAdapter.Update(deletingCategory);

                this.FilterData();

                MessageBox.Show("Category \"" + deleletedName + "\" was deleted.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
            }
            else
            {
                MessageBox.Show("The category was NOT deleted.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
            }
        }

        /// <summary>
        /// Displays a form for the user to add a website to the database.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ToolStripButtonAddWebsite_Click(object sender, EventArgs e)
        {
            (new SiteForm()).ShowDialog();

            // Refill the site table adapter
            this.siteTableAdapter.Fill(this.websitesDataSet.Site);
        }

        /// <summary>
        /// Removes a website from the database.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ToolStripButtonRemoveWebsite_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to delete the " + this.siteNameListBox.Text + " website. Do you wish to continue?", "Delete Website", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0) == DialogResult.Yes)
            {
                this.websitesDataSet.Site.FindBySiteID(Convert.ToInt32(this.siteNameListBox.SelectedValue, CultureInfo.InvariantCulture)).Delete();

                // Update the siteTableAdapter object
                this.siteTableAdapter.Update(this.websitesDataSet);
            }
            else
            {
                MessageBox.Show("The website was NOT deleted.", "Delete Website", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
            }
        }
    }
}
