namespace ICT365_Assignment1.Forms
{
    partial class FacebookEventForm
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
            this.ContentBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateEventButton
            // 
            this.CreateEventButton.Location = new System.Drawing.Point(12, 233);
            this.CreateEventButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateEventButton.Click += new System.EventHandler(this.CreateEventButton_Click);
            // 
            // CancelEventButton
            // 
            this.CancelEventButton.Location = new System.Drawing.Point(160, 233);
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
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Content:";
            // 
            // ContentBox
            // 
            this.ContentBox.Location = new System.Drawing.Point(14, 143);
            this.ContentBox.Multiline = true;
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.Size = new System.Drawing.Size(220, 79);
            this.ContentBox.TabIndex = 10;
            // 
            // FacebookEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(247, 268);
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FacebookEventForm";
            this.Text = "Facebook Event";
            this.Load += new System.EventHandler(this.FacebookEventForm_Load);
            this.Controls.SetChildIndex(this.dateTime, 0);
            this.Controls.SetChildIndex(this.LatitudeTextBox, 0);
            this.Controls.SetChildIndex(this.LongitudeTextBox, 0);
            this.Controls.SetChildIndex(this.NameBox, 0);
            this.Controls.SetChildIndex(this.CreateEventButton, 0);
            this.Controls.SetChildIndex(this.CancelEventButton, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.ContentBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox ContentBox;
    }
}
