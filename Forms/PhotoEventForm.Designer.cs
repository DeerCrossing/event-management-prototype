namespace ICT365_Assignment1.Forms
{
    partial class PhotoEventForm
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
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateEventButton
            // 
            this.CreateEventButton.Location = new System.Drawing.Point(12, 280);
            this.CreateEventButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateEventButton.Click += new System.EventHandler(this.CreateEventButton_Click);
            // 
            // CancelEventButton
            // 
            this.CancelEventButton.Location = new System.Drawing.Point(160, 280);
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
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(12, 184);
            this.CommentBox.Multiline = true;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(220, 79);
            this.CommentBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Comment:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "File Path:";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(12, 145);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(220, 20);
            this.FilePathTextBox.TabIndex = 14;
            // 
            // PhotoEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(247, 315);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PhotoEventForm";
            this.Text = "Photo Event";
            this.Load += new System.EventHandler(this.PhotoEventForm_Load);
            this.Controls.SetChildIndex(this.dateTime, 0);
            this.Controls.SetChildIndex(this.LatitudeTextBox, 0);
            this.Controls.SetChildIndex(this.LongitudeTextBox, 0);
            this.Controls.SetChildIndex(this.NameBox, 0);
            this.Controls.SetChildIndex(this.CreateEventButton, 0);
            this.Controls.SetChildIndex(this.CancelEventButton, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.CommentBox, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.FilePathTextBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox CommentBox;
        protected System.Windows.Forms.TextBox FilePathTextBox;
    }
}
