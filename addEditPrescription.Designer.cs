
namespace DBM_EF
{
    partial class addEditPrescription
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
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.preDoctor = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.preDetails = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.preCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.preDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataSource = typeof(DBM_EF.Prescription);
            // 
            // preDoctor
            // 
            this.preDoctor.DataSource = this.doctorBindingSource;
            this.preDoctor.DisplayMember = "FullName";
            this.preDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.preDoctor.FormattingEnabled = true;
            this.preDoctor.Location = new System.Drawing.Point(97, 6);
            this.preDoctor.Name = "preDoctor";
            this.preDoctor.Size = new System.Drawing.Size(100, 21);
            this.preDoctor.TabIndex = 66;
            this.preDoctor.SelectedIndexChanged += new System.EventHandler(this.preDoctor_SelectedIndexChanged);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(DBM_EF.Doctor);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(97, 146);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Details:";
            // 
            // preDetails
            // 
            this.preDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "Description", true));
            this.preDetails.Location = new System.Drawing.Point(97, 83);
            this.preDetails.Multiline = true;
            this.preDetails.Name = "preDetails";
            this.preDetails.Size = new System.Drawing.Size(200, 57);
            this.preDetails.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Doctor:";
            // 
            // preCost
            // 
            this.preCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "Cost", true));
            this.preCost.Location = new System.Drawing.Point(97, 33);
            this.preCost.Name = "preCost";
            this.preCost.Size = new System.Drawing.Size(100, 20);
            this.preCost.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Cost:";
            // 
            // preDate
            // 
            this.preDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prescriptionBindingSource, "Date", true));
            this.preDate.Location = new System.Drawing.Point(97, 57);
            this.preDate.Name = "preDate";
            this.preDate.Size = new System.Drawing.Size(200, 20);
            this.preDate.TabIndex = 70;
            // 
            // addEditPrescription
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 196);
            this.Controls.Add(this.preDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.preCost);
            this.Controls.Add(this.preDoctor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.preDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "addEditPrescription";
            this.Text = "addEditPrescription";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addEditPrescription_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox preDoctor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox preDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.TextBox preCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private System.Windows.Forms.DateTimePicker preDate;
    }
}