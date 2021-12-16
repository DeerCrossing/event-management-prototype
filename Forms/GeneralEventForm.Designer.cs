namespace ICT365_Assignment1.Forms
{
    partial class GeneralEventForm
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
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateEventButton
            // 
            this.CreateEventButton.Location = new System.Drawing.Point(12, 296);
            this.CreateEventButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateEventButton.Click += new System.EventHandler(this.CreateEventButton_Click);
            // 
            // CancelEventButton
            // 
            this.CancelEventButton.Location = new System.Drawing.Point(169, 296);
            this.CancelEventButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // LatitudeTextBox
            // 
            this.LatitudeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // LongitudeTextBox
            // 
            this.LongitudeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // NameBox
            // 
            this.NameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Comment:";
            // 
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(14, 160);
            this.CommentBox.Multiline = true;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(229, 84);
            this.CommentBox.TabIndex = 10;
            // 
            // GeneralEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(256, 331);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GeneralEventForm";
            this.Text = "General Event";
            this.Load += new System.EventHandler(this.GeneralEventForm_Load);
            this.Controls.SetChildIndex(this.dateTime, 0);
            this.Controls.SetChildIndex(this.LatitudeTextBox, 0);
            this.Controls.SetChildIndex(this.LongitudeTextBox, 0);
            this.Controls.SetChildIndex(this.NameBox, 0);
            this.Controls.SetChildIndex(this.CreateEventButton, 0);
            this.Controls.SetChildIndex(this.CancelEventButton, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.CommentBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox CommentBox;
    }
}
