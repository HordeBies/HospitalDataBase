
namespace DBM_EF
{
    partial class addEditPDR
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
            this.label4 = new System.Windows.Forms.Label();
            this.patientDiseaseRelationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pdrPatients = new System.Windows.Forms.ComboBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pdrDisease = new System.Windows.Forms.ComboBox();
            this.diseaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pdrAppointment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddEditApp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pdrPrescription = new System.Windows.Forms.TextBox();
            this.pdrPatient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pdrDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.patientDiseaseRelationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Disease:";
            // 
            // patientDiseaseRelationBindingSource
            // 
            this.patientDiseaseRelationBindingSource.DataSource = typeof(DBM_EF.PatientDiseaseRelation);
            // 
            // pdrPatients
            // 
            this.pdrPatients.DataSource = this.patientBindingSource;
            this.pdrPatients.DisplayMember = "FullName";
            this.pdrPatients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pdrPatients.FormattingEnabled = true;
            this.pdrPatients.Location = new System.Drawing.Point(97, 6);
            this.pdrPatients.Name = "pdrPatients";
            this.pdrPatients.Size = new System.Drawing.Size(100, 21);
            this.pdrPatients.TabIndex = 75;
            this.pdrPatients.SelectedIndexChanged += new System.EventHandler(this.pdrPatients_SelectedIndexChanged);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(DBM_EF.Patient);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(97, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 74;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Patient:";
            // 
            // pdrDisease
            // 
            this.pdrDisease.DataSource = this.diseaseBindingSource;
            this.pdrDisease.DisplayMember = "Name";
            this.pdrDisease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pdrDisease.FormattingEnabled = true;
            this.pdrDisease.Location = new System.Drawing.Point(97, 33);
            this.pdrDisease.Name = "pdrDisease";
            this.pdrDisease.Size = new System.Drawing.Size(100, 21);
            this.pdrDisease.TabIndex = 79;
            this.pdrDisease.SelectedIndexChanged += new System.EventHandler(this.pdrDisease_SelectedIndexChanged);
            // 
            // diseaseBindingSource
            // 
            this.diseaseBindingSource.DataSource = typeof(DBM_EF.Disease);
            // 
            // pdrAppointment
            // 
            this.pdrAppointment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientDiseaseRelationBindingSource, "AppointmentID", true));
            this.pdrAppointment.Location = new System.Drawing.Point(97, 60);
            this.pdrAppointment.Name = "pdrAppointment";
            this.pdrAppointment.ReadOnly = true;
            this.pdrAppointment.Size = new System.Drawing.Size(100, 20);
            this.pdrAppointment.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "AppointmentID:";
            // 
            // AddEditApp
            // 
            this.AddEditApp.Location = new System.Drawing.Point(203, 58);
            this.AddEditApp.Name = "AddEditApp";
            this.AddEditApp.Size = new System.Drawing.Size(75, 23);
            this.AddEditApp.TabIndex = 82;
            this.AddEditApp.Text = "Add/Edit";
            this.AddEditApp.UseVisualStyleBackColor = true;
            this.AddEditApp.Click += new System.EventHandler(this.AddEditApp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "PrescriptionID:";
            // 
            // pdrPrescription
            // 
            this.pdrPrescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientDiseaseRelationBindingSource, "PrescriptionID", true));
            this.pdrPrescription.Location = new System.Drawing.Point(97, 86);
            this.pdrPrescription.Name = "pdrPrescription";
            this.pdrPrescription.ReadOnly = true;
            this.pdrPrescription.Size = new System.Drawing.Size(100, 20);
            this.pdrPrescription.TabIndex = 84;
            // 
            // pdrPatient
            // 
            this.pdrPatient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientDiseaseRelationBindingSource, "PatientID", true));
            this.pdrPatient.Location = new System.Drawing.Point(97, 6);
            this.pdrPatient.Name = "pdrPatient";
            this.pdrPatient.ReadOnly = true;
            this.pdrPatient.Size = new System.Drawing.Size(100, 20);
            this.pdrPatient.TabIndex = 85;
            this.pdrPatient.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "label3";
            // 
            // pdrDate
            // 
            this.pdrDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientDiseaseRelationBindingSource, "ChangedOn", true));
            this.pdrDate.Location = new System.Drawing.Point(97, 112);
            this.pdrDate.Name = "pdrDate";
            this.pdrDate.Size = new System.Drawing.Size(200, 20);
            this.pdrDate.TabIndex = 87;
            // 
            // addEditPDR
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 195);
            this.Controls.Add(this.pdrDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pdrPatient);
            this.Controls.Add(this.pdrPrescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddEditApp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pdrAppointment);
            this.Controls.Add(this.pdrDisease);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pdrPatients);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "addEditPDR";
            this.Text = "addEditPDR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addEditPDR_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.patientDiseaseRelationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pdrPatients;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pdrDisease;
        private System.Windows.Forms.TextBox pdrAppointment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddEditApp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pdrPrescription;
        private System.Windows.Forms.BindingSource diseaseBindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.TextBox pdrPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource patientDiseaseRelationBindingSource;
        private System.Windows.Forms.DateTimePicker pdrDate;
    }
}