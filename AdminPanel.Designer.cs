
namespace DBM_EF
{
    partial class AdminPanel
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.diseaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PdrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PdrBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(13, 30);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(618, 326);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Not Set",
            "Addresses",
            "Diseases",
            "Patients",
            "Doctors",
            "Prescriptions",
            "Appointments",
            "PatientDiseases",
            "DoctorsWNAT",
            "PatientsWFA"});
            this.toolStripComboBox1.MaxDropDownItems = 10;
            this.toolStripComboBox1.MergeIndex = 0;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(556, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bttnDel_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(475, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "&Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(394, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "&Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // diseaseBindingSource
            // 
            this.diseaseBindingSource.DataSource = typeof(DBM_EF.Disease);
            // 
            // AddressBindingSource
            // 
            this.AddressBindingSource.DataSource = typeof(DBM_EF.Address);
            // 
            // PatientBindingSource
            // 
            this.PatientBindingSource.DataSource = typeof(DBM_EF.Patient);
            // 
            // DoctorBindingSource
            // 
            this.DoctorBindingSource.DataSource = typeof(DBM_EF.Doctor);
            // 
            // PrescriptionBindingSource
            // 
            this.PrescriptionBindingSource.DataSource = typeof(DBM_EF.Prescription);
            // 
            // AppointmentBindingSource
            // 
            this.AppointmentBindingSource.DataSource = typeof(DBM_EF.Appointment);
            // 
            // PdrBindingSource
            // 
            this.PdrBindingSource.DataSource = typeof(DBM_EF.PatientDiseaseRelation);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 397);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PdrBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource diseaseBindingSource;
        private System.Windows.Forms.BindingSource AddressBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource PatientBindingSource;
        private System.Windows.Forms.BindingSource DoctorBindingSource;
        private System.Windows.Forms.BindingSource PrescriptionBindingSource;
        private System.Windows.Forms.BindingSource AppointmentBindingSource;
        private System.Windows.Forms.BindingSource PdrBindingSource;
    }
}

