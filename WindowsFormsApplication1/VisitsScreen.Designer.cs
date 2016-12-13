namespace WindowsFormsApplication1
{
    partial class VisitsScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitsScreen));
            this.Save = new System.Windows.Forms.Button();
            this.Visits = new System.Windows.Forms.DataGridView();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagesPanel = new System.Windows.Forms.Panel();
            this.AddImage = new System.Windows.Forms.Button();
            this.openFileDialogImages = new System.Windows.Forms.OpenFileDialog();
            this.logo = new System.Windows.Forms.PictureBox();
            this.sexText = new System.Windows.Forms.TextBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.TextBox();
            this.labelBorn = new System.Windows.Forms.Label();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.labelPatientMain = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.info = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Visits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(742, 683);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(149, 61);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Visits
            // 
            this.Visits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Visits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tag,
            this.Value});
            this.Visits.Location = new System.Drawing.Point(466, 245);
            this.Visits.Name = "Visits";
            this.Visits.Size = new System.Drawing.Size(425, 297);
            this.Visits.TabIndex = 2;
            this.Visits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Visits_CellContentClick);
            // 
            // Tag
            // 
            this.Tag.HeaderText = "Tag";
            this.Tag.Name = "Tag";
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // imagesPanel
            // 
            this.imagesPanel.AutoScroll = true;
            this.imagesPanel.Location = new System.Drawing.Point(13, 604);
            this.imagesPanel.Name = "imagesPanel";
            this.imagesPanel.Size = new System.Drawing.Size(723, 140);
            this.imagesPanel.TabIndex = 3;
            // 
            // AddImage
            // 
            this.AddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddImage.Location = new System.Drawing.Point(742, 604);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(149, 61);
            this.AddImage.TabIndex = 4;
            this.AddImage.Text = "Add Images";
            this.AddImage.UseVisualStyleBackColor = true;
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // openFileDialogImages
            // 
            this.openFileDialogImages.FileName = "openFileDialog1";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(13, 74);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(241, 189);
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // sexText
            // 
            this.sexText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sexText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexText.Location = new System.Drawing.Point(791, 164);
            this.sexText.Name = "sexText";
            this.sexText.ReadOnly = true;
            this.sexText.Size = new System.Drawing.Size(54, 26);
            this.sexText.TabIndex = 8;
            this.sexText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSex
            // 
            this.labelSex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.Location = new System.Drawing.Point(735, 164);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(56, 32);
            this.labelSex.TabIndex = 14;
            this.labelSex.Text = "Sex";
            this.labelSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateText
            // 
            this.dateText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateText.Location = new System.Drawing.Point(565, 164);
            this.dateText.Name = "dateText";
            this.dateText.ReadOnly = true;
            this.dateText.Size = new System.Drawing.Size(127, 26);
            this.dateText.TabIndex = 9;
            this.dateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBorn
            // 
            this.labelBorn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorn.Location = new System.Drawing.Point(462, 164);
            this.labelBorn.Name = "labelBorn";
            this.labelBorn.Size = new System.Drawing.Size(80, 32);
            this.labelBorn.TabIndex = 15;
            this.labelBorn.Text = "Birth";
            this.labelBorn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // surnameText
            // 
            this.surnameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameText.Location = new System.Drawing.Point(565, 119);
            this.surnameText.Name = "surnameText";
            this.surnameText.ReadOnly = true;
            this.surnameText.Size = new System.Drawing.Size(152, 26);
            this.surnameText.TabIndex = 10;
            this.surnameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSurname
            // 
            this.labelSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(462, 119);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(80, 32);
            this.labelSurname.TabIndex = 16;
            this.labelSurname.Text = "Surname";
            this.labelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(462, 74);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(80, 32);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameText
            // 
            this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(565, 74);
            this.nameText.Name = "nameText";
            this.nameText.ReadOnly = true;
            this.nameText.Size = new System.Drawing.Size(152, 26);
            this.nameText.TabIndex = 11;
            this.nameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPatientMain
            // 
            this.labelPatientMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPatientMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientMain.Location = new System.Drawing.Point(560, 9);
            this.labelPatientMain.Name = "labelPatientMain";
            this.labelPatientMain.Size = new System.Drawing.Size(208, 44);
            this.labelPatientMain.TabIndex = 12;
            this.labelPatientMain.Text = "Visit";
            this.labelPatientMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPatientMain.Click += new System.EventHandler(this.labelPatientMain_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // info
            // 
            this.info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("info.BackgroundImage")));
            this.info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(126, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(51, 51);
            this.info.TabIndex = 20;
            this.info.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(69, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(51, 51);
            this.back.TabIndex = 19;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Home
            // 
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(12, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(51, 51);
            this.Home.TabIndex = 18;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // VisitsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(903, 893);
            this.Controls.Add(this.info);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.sexText);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.labelBorn);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.labelPatientMain);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.AddImage);
            this.Controls.Add(this.imagesPanel);
            this.Controls.Add(this.Visits);
            this.Controls.Add(this.Save);
            this.Name = "VisitsScreen";
            this.Text = "VisitsScreen";
            ((System.ComponentModel.ISupportInitialize)(this.Visits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView Visits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Panel imagesPanel;
        private System.Windows.Forms.Button AddImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogImages;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox sexText;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.TextBox dateText;
        private System.Windows.Forms.Label labelBorn;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label labelPatientMain;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button Home;
    }
}