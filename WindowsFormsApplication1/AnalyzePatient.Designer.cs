namespace WindowsFormsApplication1
{
    partial class AnalyzePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyzePatient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.notesText = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.sexText = new System.Windows.Forms.TextBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.TextBox();
            this.labelBorn = new System.Windows.Forms.Label();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.labelPatientMain = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Visits = new System.Windows.Forms.DataGridView();
            this.ButtonVisit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddVisit = new System.Windows.Forms.Button();
            this.optionalsGrid = new System.Windows.Forms.DataGridView();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Home = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Visits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionalsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.notesText);
            this.panel1.Controls.Add(this.labelNotes);
            this.panel1.Controls.Add(this.sexText);
            this.panel1.Controls.Add(this.labelSex);
            this.panel1.Controls.Add(this.dateText);
            this.panel1.Controls.Add(this.labelBorn);
            this.panel1.Controls.Add(this.surnameText);
            this.panel1.Controls.Add(this.labelSurname);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.nameText);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 299);
            this.panel1.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(735, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(249, 189);
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // notesText
            // 
            this.notesText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesText.Location = new System.Drawing.Point(23, 200);
            this.notesText.Multiline = true;
            this.notesText.Name = "notesText";
            this.notesText.Size = new System.Drawing.Size(942, 87);
            this.notesText.TabIndex = 0;
            this.notesText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNotes
            // 
            this.labelNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotes.Location = new System.Drawing.Point(19, 170);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(88, 32);
            this.labelNotes.TabIndex = 2;
            this.labelNotes.Text = "Notes";
            this.labelNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sexText
            // 
            this.sexText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sexText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexText.Location = new System.Drawing.Point(348, 125);
            this.sexText.Name = "sexText";
            this.sexText.Size = new System.Drawing.Size(62, 26);
            this.sexText.TabIndex = 0;
            this.sexText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSex
            // 
            this.labelSex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.Location = new System.Drawing.Point(292, 125);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(64, 32);
            this.labelSex.TabIndex = 2;
            this.labelSex.Text = "Sex";
            this.labelSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateText
            // 
            this.dateText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateText.Location = new System.Drawing.Point(122, 125);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(135, 26);
            this.dateText.TabIndex = 0;
            this.dateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBorn
            // 
            this.labelBorn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorn.Location = new System.Drawing.Point(19, 125);
            this.labelBorn.Name = "labelBorn";
            this.labelBorn.Size = new System.Drawing.Size(88, 32);
            this.labelBorn.TabIndex = 2;
            this.labelBorn.Text = "Birth";
            this.labelBorn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // surnameText
            // 
            this.surnameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameText.Location = new System.Drawing.Point(122, 80);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(160, 26);
            this.surnameText.TabIndex = 0;
            this.surnameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSurname
            // 
            this.labelSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(19, 80);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(88, 32);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Surname";
            this.labelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(19, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(88, 32);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameText
            // 
            this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(122, 35);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(160, 26);
            this.nameText.TabIndex = 0;
            this.nameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPatientMain
            // 
            this.labelPatientMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPatientMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientMain.Location = new System.Drawing.Point(316, 9);
            this.labelPatientMain.Name = "labelPatientMain";
            this.labelPatientMain.Size = new System.Drawing.Size(404, 44);
            this.labelPatientMain.TabIndex = 0;
            this.labelPatientMain.Text = "Patient\'s Main Information:";
            this.labelPatientMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(12, 838);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(152, 62);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Visits
            // 
            this.Visits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Visits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Visits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ButtonVisit,
            this.Date,
            this.Result});
            this.Visits.Location = new System.Drawing.Point(581, 390);
            this.Visits.Name = "Visits";
            this.Visits.Size = new System.Drawing.Size(418, 420);
            this.Visits.TabIndex = 3;
            this.Visits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Visits_CellContentClick);
            // 
            // ButtonVisit
            // 
            this.ButtonVisit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ButtonVisit.HeaderText = "ButtonVisit";
            this.ButtonVisit.Name = "ButtonVisit";
            this.ButtonVisit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ButtonVisit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ButtonVisit.Width = 82;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 55;
            // 
            // Result
            // 
            this.Result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            // 
            // AddVisit
            // 
            this.AddVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVisit.Location = new System.Drawing.Point(847, 838);
            this.AddVisit.Name = "AddVisit";
            this.AddVisit.Size = new System.Drawing.Size(152, 62);
            this.AddVisit.TabIndex = 4;
            this.AddVisit.Text = "Add Visit";
            this.AddVisit.UseVisualStyleBackColor = true;
            this.AddVisit.Click += new System.EventHandler(this.AddVisit_Click);
            // 
            // optionalsGrid
            // 
            this.optionalsGrid.AllowUserToAddRows = false;
            this.optionalsGrid.AllowUserToDeleteRows = false;
            this.optionalsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.optionalsGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.optionalsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.optionalsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tag,
            this.Value});
            this.optionalsGrid.Location = new System.Drawing.Point(12, 390);
            this.optionalsGrid.Name = "optionalsGrid";
            this.optionalsGrid.Size = new System.Drawing.Size(418, 420);
            this.optionalsGrid.TabIndex = 5;
            // 
            // Tag
            // 
            this.Tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tag.FillWeight = 101.5228F;
            this.Tag.HeaderText = "Tag";
            this.Tag.Name = "Tag";
            this.Tag.Width = 51;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.FillWeight = 98.47716F;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // Home
            // 
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(12, 2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(51, 51);
            this.Home.TabIndex = 6;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(69, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(51, 51);
            this.back.TabIndex = 7;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // info
            // 
            this.info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("info.BackgroundImage")));
            this.info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(126, 2);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(51, 51);
            this.info.TabIndex = 8;
            this.info.UseVisualStyleBackColor = true;
            // 
            // AnalyzePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1011, 913);
            this.Controls.Add(this.info);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.optionalsGrid);
            this.Controls.Add(this.AddVisit);
            this.Controls.Add(this.Visits);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPatientMain);
            this.Name = "AnalyzePatient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Visits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionalsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPatientMain;
        private System.Windows.Forms.TextBox notesText;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.TextBox sexText;
        private System.Windows.Forms.Label labelBorn;
        private System.Windows.Forms.TextBox dateText;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView Visits;
        private System.Windows.Forms.Button AddVisit;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.DataGridView optionalsGrid;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button info;
    }
}