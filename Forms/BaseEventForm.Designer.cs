namespace ICT365_Assignment1
{
    partial class BaseEventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.LatitudeTextBox = new System.Windows.Forms.TextBox();
            this.LongitudeTextBox = new System.Windows.Forms.TextBox();
            this.CreateEventButton = new System.Windows.Forms.Button();
            this.CancelEventButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date and Time:";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(16, 127);
            this.dateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(265, 22);
            this.dateTime.TabIndex = 3;
            // 
            // LatitudeTextBox
            // 
            this.LatitudeTextBox.Location = new System.Drawing.Point(16, 79);
            this.LatitudeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LatitudeTextBox.Name = "LatitudeTextBox";
            this.LatitudeTextBox.Size = new System.Drawing.Size(77, 22);
            this.LatitudeTextBox.TabIndex = 4;
            // 
            // LongitudeTextBox
            // 
            this.LongitudeTextBox.Location = new System.Drawing.Point(103, 79);
            this.LongitudeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LongitudeTextBox.Name = "LongitudeTextBox";
            this.LongitudeTextBox.Size = new System.Drawing.Size(77, 22);
            this.LongitudeTextBox.TabIndex = 5;
            // 
            // CreateEventButton
            // 
            this.CreateEventButton.Location = new System.Drawing.Point(16, 176);
            this.CreateEventButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateEventButton.Name = "CreateEventButton";
            this.CreateEventButton.Size = new System.Drawing.Size(100, 28);
            this.CreateEventButton.TabIndex = 6;
            this.CreateEventButton.Text = "Create Event";
            this.CreateEventButton.UseVisualStyleBackColor = true;
            this.CreateEventButton.Click += new System.EventHandler(this.CreateEventButton_Click);
            // 
            // CancelEventButton
            // 
            this.CancelEventButton.Location = new System.Drawing.Point(213, 176);
            this.CancelEventButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelEventButton.Name = "CancelEventButton";
            this.CancelEventButton.Size = new System.Drawing.Size(100, 28);
            this.CancelEventButton.TabIndex = 7;
            this.CancelEventButton.Text = "Cancel";
            this.CancelEventButton.UseVisualStyleBackColor = true;
            this.CancelEventButton.Click += new System.EventHandler(this.CancelEventButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(16, 31);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(156, 22);
            this.NameBox.TabIndex = 8;
            // 
            // BaseEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 218);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.CancelEventButton);
            this.Controls.Add(this.CreateEventButton);
            this.Controls.Add(this.LongitudeTextBox);
            this.Controls.Add(this.LatitudeTextBox);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BaseEventForm";
            this.Text = "New Event";
            this.Load += new System.EventHandler(this.BaseEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button CreateEventButton;
        public System.Windows.Forms.Button CancelEventButton;
        protected System.Windows.Forms.DateTimePicker dateTime;
        protected System.Windows.Forms.TextBox LatitudeTextBox;
        protected System.Windows.Forms.TextBox LongitudeTextBox;
        protected System.Windows.Forms.TextBox NameBox;
    }
}