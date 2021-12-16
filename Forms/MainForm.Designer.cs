namespace ICT365_Assignment1
{
    partial class LifeLogger
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
            this.MapBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MapBox
            // 
            this.MapBox.Image = global::ICT365_Assignment1.Properties.Resources.map;
            this.MapBox.Location = new System.Drawing.Point(32, 10);
            this.MapBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(960, 585);
            this.MapBox.TabIndex = 0;
            this.MapBox.TabStop = false;
            this.MapBox.Click += new System.EventHandler(this.MapBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 625);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click on the Map to create an Event, Click on an existing Event to display its da" +
    "ta";
            // 
            // LifeLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 709);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MapBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LifeLogger";
            this.Text = "LifeLogger";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MapBox;
        private System.Windows.Forms.Label label1;
    }
}

