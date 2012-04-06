namespace IntermediateCSharp.Lesson10
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The DatabaseDemonstration GUI class.
    /// </summary>
    public partial class DatabaseDemonstration : Form
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseDemonstration class.
        /// </summary>
        public DatabaseDemonstration()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Fills the table adapter on form load.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void DatabaseDemonstrationGui_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'l10_DatabaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.databaseDemonstrationDatabaseDataSet.Customer);
        }

        /// <summary>
        /// Fills the table adapter.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void FillByLastNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter.FillByLastName(this.databaseDemonstrationDatabaseDataSet.Customer, this.toolStripTextBoxLastName.Text);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
            }
        }
    }
}
