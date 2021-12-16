namespace ICT365_Assignment1
{
    partial class EventSelect
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
            this.EventSelectList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EventSelectList
            // 
            this.EventSelectList.FormattingEnabled = true;
            this.EventSelectList.Items.AddRange(new object[] {
            "None",
            "General",
            "Facebook Update",
            "Tweet",
            "Photo",
            "Video",
            "Activity",
            "Purchase"});
            this.EventSelectList.Location = new System.Drawing.Point(12, 25);
            this.EventSelectList.Name = "EventSelectList";
            this.EventSelectList.Size = new System.Drawing.Size(236, 121);
            this.EventSelectList.TabIndex = 0;
            this.EventSelectList.SelectedIndexChanged += new System.EventHandler(this.EventSelectList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Event:";
            // 
            // EventSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 159);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventSelectList);
            this.Name = "EventSelect";
            this.Text = "EventSelect";
            this.Load += new System.EventHandler(this.EventSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EventSelectList;
        private System.Windows.Forms.Label label1;
    }
}