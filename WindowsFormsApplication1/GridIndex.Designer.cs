namespace WindowsFormsApplication1
{
    partial class GridIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridIndex));
            this.Patients = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameQuery = new System.Windows.Forms.TextBox();
            this.SearchByName = new System.Windows.Forms.Label();
            this.cfQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Nuovo = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Patients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Patients
            // 
            this.Patients.AllowUserToAddRows = false;
            this.Patients.AllowUserToDeleteRows = false;
            this.Patients.AllowUserToOrderColumns = true;
            this.Patients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Patients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Patients.ColumnHeadersHeight = 35;
            this.Patients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.PatientID,
            this.NameSurname,
            this.CF});
            this.Patients.Location = new System.Drawing.Point(12, 227);
            this.Patients.Name = "Patients";
            this.Patients.ReadOnly = true;
            this.Patients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Patients.Size = new System.Drawing.Size(776, 354);
            this.Patients.TabIndex = 0;
            this.Patients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            // 
            // PatientID
            // 
            this.PatientID.HeaderText = "Patient ID";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Width = 150;
            // 
            // NameSurname
            // 
            this.NameSurname.HeaderText = "Name Surname";
            this.NameSurname.Name = "NameSurname";
            this.NameSurname.ReadOnly = true;
            this.NameSurname.Width = 250;
            // 
            // CF
            // 
            this.CF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CF.HeaderText = "CF";
            this.CF.Name = "CF";
            this.CF.ReadOnly = true;
            // 
            // nameQuery
            // 
            this.nameQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameQuery.Location = new System.Drawing.Point(487, 61);
            this.nameQuery.Multiline = true;
            this.nameQuery.Name = "nameQuery";
            this.nameQuery.Size = new System.Drawing.Size(123, 52);
            this.nameQuery.TabIndex = 1;
            this.nameQuery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameQuery.TextChanged += new System.EventHandler(this.nameQuery_TextChanged);
            this.nameQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameQuery_KeyDown);
            // 
            // SearchByName
            // 
            this.SearchByName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchByName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByName.Location = new System.Drawing.Point(353, 61);
            this.SearchByName.Name = "SearchByName";
            this.SearchByName.Size = new System.Drawing.Size(111, 52);
            this.SearchByName.TabIndex = 0;
            this.SearchByName.Text = "Search by Name";
            this.SearchByName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchByName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cfQuery
            // 
            this.cfQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cfQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfQuery.Location = new System.Drawing.Point(487, 9);
            this.cfQuery.Multiline = true;
            this.cfQuery.Name = "cfQuery";
            this.cfQuery.Size = new System.Drawing.Size(123, 52);
            this.cfQuery.TabIndex = 2;
            this.cfQuery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cfQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cfQuery_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by CF";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.AutoSize = true;
            this.Search.CausesValidation = false;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(646, 9);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(146, 104);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Nuovo
            // 
            this.Nuovo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nuovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuovo.Location = new System.Drawing.Point(589, 602);
            this.Nuovo.Name = "Nuovo";
            this.Nuovo.Size = new System.Drawing.Size(199, 55);
            this.Nuovo.TabIndex = 5;
            this.Nuovo.Text = "New Patient";
            this.Nuovo.UseVisualStyleBackColor = true;
            this.Nuovo.Click += new System.EventHandler(this.Nuovo_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(241, 189);
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // GridIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 669);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.nameQuery);
            this.Controls.Add(this.cfQuery);
            this.Controls.Add(this.SearchByName);
            this.Controls.Add(this.Nuovo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Patients);
            this.Name = "GridIndex";
            this.Text = "GridIndex";
            this.Click += new System.EventHandler(this.GridIndex_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Patients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Patients;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label SearchByName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameQuery;
        private System.Windows.Forms.TextBox cfQuery;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CF;
        private System.Windows.Forms.Button Nuovo;
        private System.Windows.Forms.PictureBox logo;
    }
}