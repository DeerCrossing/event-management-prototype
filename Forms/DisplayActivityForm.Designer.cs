namespace ICT365_Assignment1.Forms
{
    partial class DisplayActivityForm
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
            this.SuspendLayout();
            // 
            // ActivityNameBox
            // 
            this.ActivityNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // DurationBox
            // 
            this.DurationBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // CommentBox
            // 
            this.CommentBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CommentBox.Size = new System.Drawing.Size(219, 87);
            // 
            // CreateEventButton
            // 
            this.CreateEventButton.Text = "Delete Event";
            this.CreateEventButton.Visible = false;
            this.CreateEventButton.Click += new System.EventHandler(this.CreateEventButton_Click);
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
            // DisplayActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(247, 381);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "DisplayActivityForm";
            this.Load += new System.EventHandler(this.DisplayActivityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
