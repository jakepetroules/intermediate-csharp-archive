namespace IntermediateCSharp.Assignment10
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class MoviesDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private MoviesDataSet moviesDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private IntermediateCSharp.Assignment10.MoviesDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private IntermediateCSharp.Assignment10.MoviesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator movieBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton movieBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.ToolStrip toolStripFindByTitle;
        private System.Windows.Forms.ToolStripLabel toolStripLabelMovieTitle;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxMovieTitle;
        private System.Windows.Forms.ToolStripButton toolStripButtonFindByTitle;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripButton movieBindingNavigatorRefresh;

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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label ratingLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesDatabase));
            this.moviesDataSet = new IntermediateCSharp.Assignment10.MoviesDataSet();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTableAdapter = new IntermediateCSharp.Assignment10.MoviesDataSetTableAdapters.MovieTableAdapter();
            this.tableAdapterManager = new IntermediateCSharp.Assignment10.MoviesDataSetTableAdapters.TableAdapterManager();
            this.movieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.movieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.movieBindingNavigatorRefresh = new System.Windows.Forms.ToolStripButton();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.toolStripFindByTitle = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelMovieTitle = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxMovieTitle = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFindByTitle = new System.Windows.Forms.ToolStripButton();
            titleLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingNavigator)).BeginInit();
            this.movieBindingNavigator.SuspendLayout();
            this.toolStripFindByTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(135, 88);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Title:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(133, 114);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 4;
            yearLabel.Text = "Year:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(126, 140);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(39, 13);
            genreLabel.TabIndex = 6;
            genreLabel.Text = "Genre:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(124, 166);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(41, 13);
            ratingLabel.TabIndex = 8;
            ratingLabel.Text = "Rating:";
            // 
            // moviesDataSet
            // 
            this.moviesDataSet.DataSetName = "MoviesDataSet";
            this.moviesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.moviesDataSet;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MovieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.UpdateOrder = IntermediateCSharp.Assignment10.MoviesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // movieBindingNavigator
            // 
            this.movieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.movieBindingNavigator.BindingSource = this.movieBindingSource;
            this.movieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.movieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.movieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.movieBindingNavigatorSaveItem,
            this.bindingNavigatorSeparator3,
            this.movieBindingNavigatorRefresh});
            this.movieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.movieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.movieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.movieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.movieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.movieBindingNavigator.Name = "movieBindingNavigator";
            this.movieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.movieBindingNavigator.Size = new System.Drawing.Size(394, 25);
            this.movieBindingNavigator.TabIndex = 0;
            this.movieBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // movieBindingNavigatorSaveItem
            // 
            this.movieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.movieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("movieBindingNavigatorSaveItem.Image")));
            this.movieBindingNavigatorSaveItem.Name = "movieBindingNavigatorSaveItem";
            this.movieBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.movieBindingNavigatorSaveItem.Text = "Save Data";
            this.movieBindingNavigatorSaveItem.Click += new System.EventHandler(this.MovieBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // movieBindingNavigatorRefresh
            // 
            this.movieBindingNavigatorRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.movieBindingNavigatorRefresh.Image = ((System.Drawing.Image)(resources.GetObject("movieBindingNavigatorRefresh.Image")));
            this.movieBindingNavigatorRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.movieBindingNavigatorRefresh.Name = "movieBindingNavigatorRefresh";
            this.movieBindingNavigatorRefresh.Size = new System.Drawing.Size(49, 22);
            this.movieBindingNavigatorRefresh.Text = "Refresh";
            this.movieBindingNavigatorRefresh.Click += new System.EventHandler(this.MovieBindingNavigatorRefresh_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(171, 85);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 3;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(171, 111);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 5;
            // 
            // genreTextBox
            // 
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "Genre", true));
            this.genreTextBox.Location = new System.Drawing.Point(171, 137);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(100, 20);
            this.genreTextBox.TabIndex = 7;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(171, 163);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(100, 20);
            this.ratingTextBox.TabIndex = 9;
            // 
            // toolStripFindByTitle
            // 
            this.toolStripFindByTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelMovieTitle,
            this.toolStripTextBoxMovieTitle,
            this.toolStripButtonFindByTitle});
            this.toolStripFindByTitle.Location = new System.Drawing.Point(0, 25);
            this.toolStripFindByTitle.Name = "toolStripFindByTitle";
            this.toolStripFindByTitle.Size = new System.Drawing.Size(394, 25);
            this.toolStripFindByTitle.TabIndex = 1;
            this.toolStripFindByTitle.Text = "toolStrip1";
            // 
            // toolStripLabelMovieTitle
            // 
            this.toolStripLabelMovieTitle.Name = "toolStripLabelMovieTitle";
            this.toolStripLabelMovieTitle.Size = new System.Drawing.Size(62, 22);
            this.toolStripLabelMovieTitle.Text = "Movie Title:";
            // 
            // toolStripTextBoxMovieTitle
            // 
            this.toolStripTextBoxMovieTitle.Name = "toolStripTextBoxMovieTitle";
            this.toolStripTextBoxMovieTitle.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonFindByTitle
            // 
            this.toolStripButtonFindByTitle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFindByTitle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFindByTitle.Image")));
            this.toolStripButtonFindByTitle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFindByTitle.Name = "toolStripButtonFindByTitle";
            this.toolStripButtonFindByTitle.Size = new System.Drawing.Size(62, 22);
            this.toolStripButtonFindByTitle.Text = "Find Movie";
            this.toolStripButtonFindByTitle.Click += new System.EventHandler(this.ToolStripButtonFindByTitle_Click);
            // 
            // MoviesDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 268);
            this.Controls.Add(this.toolStripFindByTitle);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(genreLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.movieBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MoviesDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Database";
            this.Load += new System.EventHandler(this.MovieDatabaseGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingNavigator)).EndInit();
            this.movieBindingNavigator.ResumeLayout(false);
            this.movieBindingNavigator.PerformLayout();
            this.toolStripFindByTitle.ResumeLayout(false);
            this.toolStripFindByTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

