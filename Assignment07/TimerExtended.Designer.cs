namespace IntermediateCSharp.Assignment07
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class TimerExtended
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxTimeObject;
        private System.Windows.Forms.Button buttonControlTick;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonGetTime;
        private System.Windows.Forms.Button buttonSetTime;
        private System.Windows.Forms.NumericUpDown numericUpDownSetSecond;
        private System.Windows.Forms.NumericUpDown numericUpDownSetMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownSetHour;
        private System.Windows.Forms.Label labelSetSecond;
        private System.Windows.Forms.Label labelSetMinute;
        private System.Windows.Forms.Label labelSetHour;
        private System.Windows.Forms.Timer timerTicker;

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
            this.groupBoxTimeObject = new System.Windows.Forms.GroupBox();
            this.buttonControlTick = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonGetTime = new System.Windows.Forms.Button();
            this.buttonSetTime = new System.Windows.Forms.Button();
            this.numericUpDownSetSecond = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSetMinute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSetHour = new System.Windows.Forms.NumericUpDown();
            this.labelSetSecond = new System.Windows.Forms.Label();
            this.labelSetMinute = new System.Windows.Forms.Label();
            this.labelSetHour = new System.Windows.Forms.Label();
            this.timerTicker = new System.Windows.Forms.Timer(this.components);
            this.groupBoxTimeObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetHour)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTimeObject
            // 
            this.groupBoxTimeObject.Controls.Add(this.buttonControlTick);
            this.groupBoxTimeObject.Controls.Add(this.labelTime);
            this.groupBoxTimeObject.Controls.Add(this.buttonGetTime);
            this.groupBoxTimeObject.Location = new System.Drawing.Point(12, 119);
            this.groupBoxTimeObject.Name = "groupBoxTimeObject";
            this.groupBoxTimeObject.Size = new System.Drawing.Size(270, 137);
            this.groupBoxTimeObject.TabIndex = 7;
            this.groupBoxTimeObject.TabStop = false;
            this.groupBoxTimeObject.Text = "Time Object";
            // 
            // buttonControlTick
            // 
            this.buttonControlTick.Location = new System.Drawing.Point(87, 19);
            this.buttonControlTick.Name = "buttonControlTick";
            this.buttonControlTick.Size = new System.Drawing.Size(75, 23);
            this.buttonControlTick.TabIndex = 1;
            this.buttonControlTick.Text = "Start Ticker";
            this.buttonControlTick.UseVisualStyleBackColor = true;
            this.buttonControlTick.Click += new System.EventHandler(this.ButtonControlTick_Click);
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(6, 45);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(258, 89);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "00:00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGetTime
            // 
            this.buttonGetTime.Location = new System.Drawing.Point(6, 19);
            this.buttonGetTime.Name = "buttonGetTime";
            this.buttonGetTime.Size = new System.Drawing.Size(75, 23);
            this.buttonGetTime.TabIndex = 0;
            this.buttonGetTime.Text = "Get Time";
            this.buttonGetTime.UseVisualStyleBackColor = true;
            this.buttonGetTime.Click += new System.EventHandler(this.ButtonGetTime_Click);
            // 
            // buttonSetTime
            // 
            this.buttonSetTime.Location = new System.Drawing.Point(110, 90);
            this.buttonSetTime.Name = "buttonSetTime";
            this.buttonSetTime.Size = new System.Drawing.Size(75, 23);
            this.buttonSetTime.TabIndex = 6;
            this.buttonSetTime.Text = "Set Time";
            this.buttonSetTime.UseVisualStyleBackColor = true;
            this.buttonSetTime.Click += new System.EventHandler(this.ButtonSetTime_Click);
            // 
            // numericUpDownSetSecond
            // 
            this.numericUpDownSetSecond.Location = new System.Drawing.Point(158, 64);
            this.numericUpDownSetSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSetSecond.Name = "numericUpDownSetSecond";
            this.numericUpDownSetSecond.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownSetSecond.TabIndex = 5;
            // 
            // numericUpDownSetMinute
            // 
            this.numericUpDownSetMinute.Location = new System.Drawing.Point(158, 38);
            this.numericUpDownSetMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSetMinute.Name = "numericUpDownSetMinute";
            this.numericUpDownSetMinute.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownSetMinute.TabIndex = 3;
            // 
            // numericUpDownSetHour
            // 
            this.numericUpDownSetHour.Location = new System.Drawing.Point(158, 12);
            this.numericUpDownSetHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownSetHour.Name = "numericUpDownSetHour";
            this.numericUpDownSetHour.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownSetHour.TabIndex = 1;
            // 
            // labelSetSecond
            // 
            this.labelSetSecond.AutoSize = true;
            this.labelSetSecond.Location = new System.Drawing.Point(86, 66);
            this.labelSetSecond.Name = "labelSetSecond";
            this.labelSetSecond.Size = new System.Drawing.Size(66, 13);
            this.labelSetSecond.TabIndex = 4;
            this.labelSetSecond.Text = "Set &Second:";
            // 
            // labelSetMinute
            // 
            this.labelSetMinute.AutoSize = true;
            this.labelSetMinute.Location = new System.Drawing.Point(86, 40);
            this.labelSetMinute.Name = "labelSetMinute";
            this.labelSetMinute.Size = new System.Drawing.Size(61, 13);
            this.labelSetMinute.TabIndex = 2;
            this.labelSetMinute.Text = "Set &Minute:";
            // 
            // labelSetHour
            // 
            this.labelSetHour.AutoSize = true;
            this.labelSetHour.Location = new System.Drawing.Point(86, 14);
            this.labelSetHour.Name = "labelSetHour";
            this.labelSetHour.Size = new System.Drawing.Size(52, 13);
            this.labelSetHour.TabIndex = 0;
            this.labelSetHour.Text = "Set &Hour:";
            // 
            // timerTicker
            // 
            this.timerTicker.Interval = 1000;
            this.timerTicker.Tick += new System.EventHandler(this.TimerTicker_Tick);
            // 
            // TimerExtended
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 268);
            this.Controls.Add(this.groupBoxTimeObject);
            this.Controls.Add(this.buttonSetTime);
            this.Controls.Add(this.numericUpDownSetSecond);
            this.Controls.Add(this.numericUpDownSetMinute);
            this.Controls.Add(this.numericUpDownSetHour);
            this.Controls.Add(this.labelSetSecond);
            this.Controls.Add(this.labelSetMinute);
            this.Controls.Add(this.labelSetHour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TimerExtended";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer Extended";
            this.groupBoxTimeObject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

