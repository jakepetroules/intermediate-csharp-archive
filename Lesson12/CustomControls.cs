namespace IntermediateCSharp.Lesson12
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The CustomControls GUI class.
    /// </summary>
    public partial class CustomControls : Form
    {
        /// <summary>
        /// The close program menu item.
        /// </summary>
        private MenuItem closeItem;

        /// <summary>
        /// Initializes a new instance of the CustomControls class.
        /// </summary>
        public CustomControls()
        {
            this.InitializeComponent();

            // Create context menu items
            this.closeItem = new MenuItem();

            // Create event handlers for our menu items
            EventHandler closeHandler = new EventHandler(this.CloseItem_Click);

            // Add this event handler to the menu item's Click event
            this.closeItem.Click += closeHandler;

            // Create the new button
            SpecialButton myButton = new SpecialButton();

            // Create an EventHandler for this button
            EventHandler buttonHandler = new EventHandler(this.MyButton_Click);

            // Add this event handler to the new button
            myButton.Click += buttonHandler;

            // Tell program where to put this button
            myButton.Location = new System.Drawing.Point(100, 50);

            // Tell program how big to make this button
            myButton.Size = new System.Drawing.Size(100, 20);

            // Add this button to the form
            this.Controls.Add(myButton);
        }

        /// <summary>
        /// Closes the form when the close button or menu item is clicked.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Occurs when the form loads.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CustomControlsMainGui_Load(object sender, EventArgs e)
        {
            // Create ToolTip object for the Close button
            ToolTip btnCloseTip = new ToolTip();

            // Set the button's ToolTip to display our text
            btnCloseTip.SetToolTip(this.buttonClose, "Click here to close program");

            // Create the context menu
            ContextMenu contextMenu = new ContextMenu();
            
            // Add menu items to this context menu
            contextMenu.MenuItems.Add(this.closeItem);
            
            // Set the Text property for what is shown to the user
            this.closeItem.Text = "Close Program";

            this.labelTest.ContextMenu = contextMenu; 
        }

        /// <summary>
        /// Shows a message when the user clicks the custom-drawn button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the button!", "Custom Button's Click Event", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
        }
    }
}
