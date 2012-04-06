namespace IntermediateCSharp.Assignment10
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The MoviesDatabase GUI class.
    /// </summary>
    public partial class MoviesDatabase : Form
    {
        /// <summary>
        /// Initializes a new instance of the MoviesDatabase class.
        /// </summary>
        public MoviesDatabase()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Performs actions that must be done when the form first loads.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MovieDatabaseGui_Load(object sender, EventArgs e)
        {
            this.movieTableAdapter.Fill(this.moviesDataSet.Movie);
        }

        /// <summary>
        /// Saves the data to the database.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MovieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.moviesDataSet);
        }

        /// <summary>
        /// Refreshes the data from the database. This is useful if a search was performed and it did not return any results.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MovieBindingNavigatorRefresh_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.Fill(this.moviesDataSet.Movie);
        }

        /// <summary>
        /// Finds a movie by its title.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ToolStripButtonFindByTitle_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.FillByTitle(this.moviesDataSet.Movie, this.toolStripTextBoxMovieTitle.Text);
        }
    }
}
