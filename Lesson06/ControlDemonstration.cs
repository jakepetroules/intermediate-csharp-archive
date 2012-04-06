namespace IntermediateCSharp.Lesson06
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// The ControlDemonstration GUI class.
    /// </summary>
    public partial class ControlDemonstration : Form
    {
        /// <summary>
        /// Initializes a new instance of the ControlDemonstration class.
        /// </summary>
        public ControlDemonstration()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Colors the current tab-page black.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void BlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl.TabPages[this.tabControl.SelectedIndex].BackColor = Color.Black;
        }

        /// <summary>
        /// Colors the current tab-page blue.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl.TabPages[this.tabControl.SelectedIndex].BackColor = Color.Blue;
        }

        /// <summary>
        /// Colors the current tab-page red.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl.TabPages[this.tabControl.SelectedIndex].BackColor = Color.Red;
        }
    }
}
