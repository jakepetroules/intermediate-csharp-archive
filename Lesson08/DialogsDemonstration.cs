namespace IntermediateCSharp.Lesson08
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// The DialogsDemonstration GUI class.
    /// </summary>
    public partial class DialogsDemonstration : Form
    {
        /// <summary>
        /// Initializes a new instance of the DialogsDemonstration class.
        /// </summary>
        public DialogsDemonstration()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Reads the first line of a file chosen by the user.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonRead_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader inFile = File.OpenText(this.openFileDialog.FileName);
                    this.textBoxReadData.Text = inFile.ReadToEnd();
                    inFile.Close();
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("You do not have permission to write to the file.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
                }
                catch (PathTooLongException)
                {
                    MessageBox.Show("The file path is too long. Try placing this program's executable in a directory closer to the root and running it from there.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("The file " + this.openFileDialog.FileName + " does not exist.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Ran out of memory reading the file. The file may be too large or your system may simply not have sufficient memory.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
                }
                catch (IOException)
                {
                    MessageBox.Show("An I/O error occurred writing to the file.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
                }
            }
        }

        /// <summary>
        /// Writes data to a file chosen by the user.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonWrite_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBoxWriteData.Text))
            {
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StreamWriter outFile = File.AppendText(this.saveFileDialog.FileName);
                        outFile.Write(this.textBoxWriteData.Text);
                        outFile.Close();
                    }
                    catch (UnauthorizedAccessException)
                    {
                        MessageBox.Show("You do not have permission to write to the file.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
                    }
                    catch (PathTooLongException)
                    {
                        MessageBox.Show("The file path is too long. Try placing this program's executable in a directory closer to the root and running it from there.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
                    }
                    catch (DirectoryNotFoundException)
                    {
                        MessageBox.Show("The directory " + Path.GetDirectoryName(this.saveFileDialog.FileName) + " does not exist.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter some data to write to file, in the text box.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
            }
        }
    }
}
