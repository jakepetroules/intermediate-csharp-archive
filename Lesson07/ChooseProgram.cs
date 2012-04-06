namespace IntermediateCSharp.Lesson07
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;

    /// <summary>
    /// A program chooser letting the user decide which program to run.
    /// </summary>
    public partial class ChooseProgram : Form
    {
        /// <summary>
        /// List of programs that can be run.
        /// </summary>
        private Collection<KeyValuePair<string, Form>> programs;

        /// <summary>
        /// Initializes a new instance of the ChooseProgram class.
        /// </summary>
        /// <param name="programsToRun">List of programs to run.</param>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is the best way to do this for now.")]
        public ChooseProgram(Collection<KeyValuePair<string, Form>> programsToRun)
        {
            this.InitializeComponent();
            this.programs = programsToRun;
            for (int i = 0; i < this.programs.Count; i++)
            {
                this.comboBoxProgram.Items.Add(this.programs[i].Key);
            }
        }

        /// <summary>
        /// Runs the selected program.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonRun_Click(object sender, EventArgs e)
        {
            if (this.comboBoxProgram.SelectedIndex >= 0)
            {
                this.programs[this.comboBoxProgram.SelectedIndex].Value.ShowDialog();
            }
            else
            {
                MessageBox.Show("You have not selected a program to run!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
            }
        }

        /// <summary>
        /// Exits the program.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
