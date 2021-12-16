namespace ICT365_Assignment1.Forms
{
    partial class ActivityEventForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.ActivityNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DurationBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateEventButton
            // 
            this.CreateEventButton.Location = new System.Drawing.Point(9, 346);
            this.CreateEventButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateEventButton.Click += new System.EventHandler(this.CreateEventButton_Click);
            // 
            // CancelEventButton
            // 
            this.CancelEventButton.Location = new System.Drawing.Point(160, 346);
            this.CancelEventButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // LatitudeTextBox
            // 
            this.LatitudeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // LongitudeTextBox
            // 
            this.LongitudeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // NameBox
            // 
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Activity Name:";
            // 
            // ActivityNameBox
            // 
            this.ActivityNameBox.Location = new System.Drawing.Point(12, 142);
            this.ActivityNameBox.Name = "ActivityNameBox";
            this.ActivityNameBox.Size = new System.Drawing.Size(119, 20);
            this.ActivityNameBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Duration (In Minutes):";
            // 
            // DurationBox
            // 
            this.DurationBox.Location = new System.Drawing.Point(12, 181);
            this.DurationBox.Name = "DurationBox";
            this.DurationBox.Size = new System.Drawing.Size(72, 20);
            this.DurationBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Comment:";
            // 
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(15, 223);
            this.CommentBox.Multiline = true;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(219, 106);
            this.CommentBox.TabIndex = 15;
            // 
            // ActivityEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(247, 381);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DurationBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ActivityNameBox);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ActivityEventForm";
            this.Text = "Activity Event";
            this.Load += new System.EventHandler(this.ActivityEventForm_Load);
            this.Controls.SetChildIndex(this.dateTime, 0);
            this.Controls.SetChildIndex(this.LatitudeTextBox, 0);
            this.Controls.SetChildIndex(this.LongitudeTextBox, 0);
            this.Controls.SetChildIndex(this.NameBox, 0);
            this.Controls.SetChildIndex(this.CreateEventButton, 0);
            this.Controls.SetChildIndex(this.CancelEventButton, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.ActivityNameBox, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.DurationBox, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.CommentBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox ActivityNameBox;
        protected System.Windows.Forms.TextBox DurationBox;
        protected System.Windows.Forms.TextBox CommentBox;
    }
}
