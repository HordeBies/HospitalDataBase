
namespace DBM_EF
{
    partial class addEditAppointment
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.appDetails = new System.Windows.Forms.TextBox();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.appDoctor = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(97, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Details:";
            // 
            // appDetails
            // 
            this.appDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "Details", true));
            this.appDetails.Location = new System.Drawing.Point(97, 58);
            this.appDetails.Multiline = true;
            this.appDetails.Name = "appDetails";
            this.appDetails.Size = new System.Drawing.Size(200, 57);
            this.appDetails.TabIndex = 44;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(DBM_EF.Appointment);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Doctor:";
            // 
            // appDoctor
            // 
            this.appDoctor.DataSource = this.doctorBindingSource;
            this.appDoctor.DisplayMember = "FullName";
            this.appDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appDoctor.FormattingEnabled = true;
            this.appDoctor.Location = new System.Drawing.Point(97, 6);
            this.appDoctor.Name = "appDoctor";
            this.appDoctor.Size = new System.Drawing.Size(100, 21);
            this.appDoctor.TabIndex = 59;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(DBM_EF.Doctor);
            // 
            // appDate
            // 
            this.appDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "Date", true));
            this.appDate.Location = new System.Drawing.Point(97, 32);
            this.appDate.Name = "appDate";
            this.appDate.Size = new System.Drawing.Size(200, 20);
            this.appDate.TabIndex = 60;
            // 
            // addEditAppointment
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 174);
            this.Controls.Add(this.appDate);
            this.Controls.Add(this.appDoctor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.appDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "addEditAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addEditAppointment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addEditAppointment_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox appDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox appDoctor;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.DateTimePicker appDate;
    }
}