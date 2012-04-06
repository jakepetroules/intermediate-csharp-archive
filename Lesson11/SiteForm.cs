namespace IntermediateCSharp.Lesson11
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    /// <summary>
    /// Dialog to add a website to the database.
    /// </summary>
    public partial class SiteForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the SiteForm class.
        /// </summary>
        public SiteForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Performs actions that must be done when the form first loads.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SiteForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websitesDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.websitesDataSet.Category);
        }

        /// <summary>
        /// Closes the dialog, accepting the data.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBoxSiteName.Text) && !string.IsNullOrEmpty(this.textBoxURL.Text))
            {
                // Create a new SiteRow object
                websitesDataSet.SiteRow newSite = this.websitesDataSet.Site.NewSiteRow();
                newSite.SiteName = this.textBoxSiteName.Text;
                newSite.URL = this.textBoxURL.Text;
                newSite.CategoryID = Convert.ToInt32(this.categoryNameComboBox.SelectedValue, CultureInfo.InvariantCulture);

                // Add the row to the database
                this.websitesDataSet.Site.AddSiteRow(newSite);

                // Update the siteTableAdapter object
                this.siteTableAdapter.Update(newSite);

                MessageBox.Show("Website \"" + this.textBoxSiteName.Text + "\" was added to the " + this.categoryNameComboBox.Text + " category.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
                this.Close();
            }
            else
            {
                MessageBox.Show("You must specify values for both Site Name and URL.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
            }
        }

        /// <summary>
        /// Closes the dialog without doing anything.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nothing was added.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
            this.Close();
        }
    }
}
