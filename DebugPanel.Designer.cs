
namespace DBM_EF
{
    partial class DebugPanel
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
            this.ptComboBox = new System.Windows.Forms.ComboBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opnPatient = new System.Windows.Forms.Button();
            this.opnDoctor = new System.Windows.Forms.Button();
            this.dcComboBox = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opnAdminPanel = new System.Windows.Forms.Button();
            this.newPatient = new System.Windows.Forms.Button();
            this.newDoctor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ptComboBox
            // 
            this.ptComboBox.DataSource = this.patientBindingSource;
            this.ptComboBox.DisplayMember = "FullName";
            this.ptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ptComboBox.FormattingEnabled = true;
            this.ptComboBox.Location = new System.Drawing.Point(12, 41);
            this.ptComboBox.Name = "ptComboBox";
            this.ptComboBox.Size = new System.Drawing.Size(121, 21);
            this.ptComboBox.TabIndex = 0;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(DBM_EF.Patient);
            // 
            // opnPatient
            // 
            this.opnPatient.Location = new System.Drawing.Point(12, 12);
            this.opnPatient.Name = "opnPatient";
            this.opnPatient.Size = new System.Drawing.Size(121, 23);
            this.opnPatient.TabIndex = 1;
            this.opnPatient.Text = "Open Patient Panel";
            this.opnPatient.UseVisualStyleBackColor = true;
            this.opnPatient.Click += new System.EventHandler(this.opnPatient_Click);
            // 
            // opnDoctor
            // 
            this.opnDoctor.Location = new System.Drawing.Point(139, 12);
            this.opnDoctor.Name = "opnDoctor";
            this.opnDoctor.Size = new System.Drawing.Size(121, 23);
            this.opnDoctor.TabIndex = 3;
            this.opnDoctor.Text = "Open Doctor Panel";
            this.opnDoctor.UseVisualStyleBackColor = true;
            this.opnDoctor.Click += new System.EventHandler(this.opnDoctor_Click);
            // 
            // dcComboBox
            // 
            this.dcComboBox.DataSource = this.doctorBindingSource;
            this.dcComboBox.DisplayMember = "FullName";
            this.dcComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dcComboBox.FormattingEnabled = true;
            this.dcComboBox.Location = new System.Drawing.Point(139, 41);
            this.dcComboBox.Name = "dcComboBox";
            this.dcComboBox.Size = new System.Drawing.Size(121, 21);
            this.dcComboBox.TabIndex = 2;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(DBM_EF.Doctor);
            // 
            // opnAdminPanel
            // 
            this.opnAdminPanel.Location = new System.Drawing.Point(266, 12);
            this.opnAdminPanel.Name = "opnAdminPanel";
            this.opnAdminPanel.Size = new System.Drawing.Size(75, 50);
            this.opnAdminPanel.TabIndex = 4;
            this.opnAdminPanel.Text = "Open Admin Panel";
            this.opnAdminPanel.UseVisualStyleBackColor = true;
            this.opnAdminPanel.Click += new System.EventHandler(this.opnAdminPanel_Click);
            // 
            // newPatient
            // 
            this.newPatient.Location = new System.Drawing.Point(13, 69);
            this.newPatient.Name = "newPatient";
            this.newPatient.Size = new System.Drawing.Size(120, 26);
            this.newPatient.TabIndex = 5;
            this.newPatient.Text = "Register New Patient";
            this.newPatient.UseVisualStyleBackColor = true;
            this.newPatient.Click += new System.EventHandler(this.newPatient_Click);
            // 
            // newDoctor
            // 
            this.newDoctor.Location = new System.Drawing.Point(139, 68);
            this.newDoctor.Name = "newDoctor";
            this.newDoctor.Size = new System.Drawing.Size(121, 26);
            this.newDoctor.TabIndex = 6;
            this.newDoctor.Text = "Hire New Doctor";
            this.newDoctor.UseVisualStyleBackColor = true;
            this.newDoctor.Click += new System.EventHandler(this.newDoctor_Click);
            // 
            // DebugPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 102);
            this.Controls.Add(this.newDoctor);
            this.Controls.Add(this.newPatient);
            this.Controls.Add(this.opnAdminPanel);
            this.Controls.Add(this.opnDoctor);
            this.Controls.Add(this.dcComboBox);
            this.Controls.Add(this.opnPatient);
            this.Controls.Add(this.ptComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DebugPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DebugPanel";
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ptComboBox;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.Button opnPatient;
        private System.Windows.Forms.Button opnDoctor;
        private System.Windows.Forms.ComboBox dcComboBox;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.Button opnAdminPanel;
        private System.Windows.Forms.Button newPatient;
        private System.Windows.Forms.Button newDoctor;
    }
}