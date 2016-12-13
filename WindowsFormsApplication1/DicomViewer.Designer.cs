namespace WindowsFormsApplication1
{
    partial class DicomViewer
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
            this.Viewer = new DicomObjects.DicomViewer();
            this.SuspendLayout();
            // 
            // Viewer
            // 
            this.Viewer.AutoDisplay = false;
            this.Viewer.AutoScroll = true;
            this.Viewer.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.Viewer.BackColor = System.Drawing.Color.Black;
            this.Viewer.BackColour = System.Drawing.Color.Black;
            this.Viewer.Border = ((short)(0));
            this.Viewer.CellSpacing = ((short)(0));
            this.Viewer.CineUpdateTime = 0;
            this.Viewer.CurrentIndex = 0;
            this.Viewer.HitMargin = 3;
            this.Viewer.Location = new System.Drawing.Point(92, 70);
            this.Viewer.MultiColumns = ((short)(1));
            this.Viewer.MultiRows = ((short)(1));
            this.Viewer.Name = "Viewer";
            this.Viewer.PixelSize = new System.Drawing.SizeF(0.3F, 0.3F);
            this.Viewer.ShowLabels = true;
            this.Viewer.Size = new System.Drawing.Size(429, 365);
            this.Viewer.TabIndex = 0;
            this.Viewer.Text = "Viewer";
            this.Viewer.UseScrollBars = true;
            this.Viewer.UseThreads = false;
            this.Viewer.Click += new System.EventHandler(this.dicomViewer1_Click);
            // 
            // DicomViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 507);
            this.Controls.Add(this.Viewer);
            this.Name = "DicomViewer";
            this.Text = "DicomViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private DicomObjects.DicomViewer Viewer;
    }
}