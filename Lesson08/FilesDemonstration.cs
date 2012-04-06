namespace IntermediateCSharp.Lesson08
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// The FilesDemonstration GUI class.
    /// </summary>
    public partial class FilesDemonstration : Form
    {
        /// <summary>
        /// The file that we write to and read from in this demonstration.
        /// </summary>
        private string demoFile = Application.StartupPath + "\\output.txt";

        /// <summary>
        /// Initializes a new instance of the FilesDemonstration class.
        /// </summary>
        public FilesDemonstration()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Writes the user's name to a file.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonWrite_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBoxName.Text))
            {
                try
                {
                    StreamWriter outFile = File.CreateText(this.demoFile);
                    outFile.WriteLine(this.textBoxName.Text);
                    outFile.Close();
                    this.textBoxName.Text = string.Empty;
                    MessageBox.Show("File written successfully!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("You do not have permission to write to the file.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
                }
                catch (PathTooLongException)
                {
                    MessageBox.Show("The file path is too long. Try placing this program's executable in a directory closer to the root and running it from there.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
                }
                catch (IOException)
                {
                    MessageBox.Show("An I/O error occurred writing to the file.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
                }
            }
            else
            {
                MessageBox.Show("Please enter your name in the text box.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
            }
        }

        /// <summary>
        /// Read's the user's name from the file.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inFile = File.OpenText(this.demoFile);
                this.textBoxName.Text = inFile.ReadLine();
                inFile.Close();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to read from the file.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("The file path is too long. Try placing this program's executable in a directory closer to the root and running it from there.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The " + Path.GetFileName(this.demoFile) + " file does not exist. Click the '" + this.buttonWrite.Text + "' button to create it.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
            }
        }

        /// <summary>
        /// Cleans up when the form has closed.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void FilesDemonstration_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                File.Delete(this.demoFile);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to delete the file.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("The file path of the file to delete is too long. Try placing this program's executable in a directory closer to the root and running it from there.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
            }
            catch (IOException)
            {
                MessageBox.Show("The file is in use and cannot be deleted at this time.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
            }
        }
    }
}
