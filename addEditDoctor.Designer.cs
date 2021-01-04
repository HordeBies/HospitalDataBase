
namespace DBM_EF
{
    partial class addEditDoctor
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
            this.label6 = new System.Windows.Forms.Label();
            this.EditAddress = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dcAddressID = new System.Windows.Forms.TextBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dcPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dcGender = new System.Windows.Forms.TextBox();
            this.dcLastName = new System.Windows.Forms.TextBox();
            this.dcName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dcSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dcDiseaseID = new System.Windows.Forms.ComboBox();
            this.diseaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dcDateOfBirth = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Address ID:";
            // 
            // EditAddress
            // 
            this.EditAddress.Location = new System.Drawing.Point(204, 158);
            this.EditAddress.Name = "EditAddress";
            this.EditAddress.Size = new System.Drawing.Size(75, 23);
            this.EditAddress.TabIndex = 33;
            this.EditAddress.Text = "Add/Edit";
            this.EditAddress.UseVisualStyleBackColor = true;
            this.EditAddress.Click += new System.EventHandler(this.EditAddress_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Date Of Birth:";
            // 
            // dcAddressID
            // 
            this.dcAddressID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "AddressID", true));
            this.dcAddressID.Location = new System.Drawing.Point(97, 162);
            this.dcAddressID.Name = "dcAddressID";
            this.dcAddressID.ReadOnly = true;
            this.dcAddressID.Size = new System.Drawing.Size(100, 20);
            this.dcAddressID.TabIndex = 31;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(DBM_EF.Doctor);
            // 
            // dcPhoneNumber
            // 
            this.dcPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "PhoneNumber", true));
            this.dcPhoneNumber.Location = new System.Drawing.Point(97, 84);
            this.dcPhoneNumber.Name = "dcPhoneNumber";
            this.dcPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.dcPhoneNumber.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Phone Number:";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(99, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Gender(0,1):";
            // 
            // dcGender
            // 
            this.dcGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Gender", true));
            this.dcGender.Location = new System.Drawing.Point(97, 58);
            this.dcGender.Name = "dcGender";
            this.dcGender.Size = new System.Drawing.Size(100, 20);
            this.dcGender.TabIndex = 25;
            // 
            // dcLastName
            // 
            this.dcLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "LastName", true));
            this.dcLastName.Location = new System.Drawing.Point(97, 32);
            this.dcLastName.Name = "dcLastName";
            this.dcLastName.Size = new System.Drawing.Size(100, 20);
            this.dcLastName.TabIndex = 24;
            // 
            // dcName
            // 
            this.dcName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Name", true));
            this.dcName.Location = new System.Drawing.Point(97, 6);
            this.dcName.Name = "dcName";
            this.dcName.Size = new System.Drawing.Size(100, 20);
            this.dcName.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name:";
            // 
            // dcSalary
            // 
            this.dcSalary.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Salary", true));
            this.dcSalary.Location = new System.Drawing.Point(97, 110);
            this.dcSalary.Name = "dcSalary";
            this.dcSalary.Size = new System.Drawing.Size(100, 20);
            this.dcSalary.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Salary:";
            // 
            // dcDiseaseID
            // 
            this.dcDiseaseID.DataSource = this.diseaseBindingSource;
            this.dcDiseaseID.DisplayMember = "Name";
            this.dcDiseaseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dcDiseaseID.FormattingEnabled = true;
            this.dcDiseaseID.Location = new System.Drawing.Point(97, 188);
            this.dcDiseaseID.Name = "dcDiseaseID";
            this.dcDiseaseID.Size = new System.Drawing.Size(100, 21);
            this.dcDiseaseID.TabIndex = 37;
            this.dcDiseaseID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // diseaseBindingSource
            // 
            this.diseaseBindingSource.DataSource = typeof(DBM_EF.Disease);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Disease:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "ID:";
            // 
            // dcDateOfBirth
            // 
            this.dcDateOfBirth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "DateOfBirth", true));
            this.dcDateOfBirth.Location = new System.Drawing.Point(97, 136);
            this.dcDateOfBirth.Name = "dcDateOfBirth";
            this.dcDateOfBirth.Size = new System.Drawing.Size(208, 20);
            this.dcDateOfBirth.TabIndex = 40;
            // 
            // addEditDoctor
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 292);
            this.Controls.Add(this.dcDateOfBirth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dcDiseaseID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dcSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EditAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dcAddressID);
            this.Controls.Add(this.dcPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dcGender);
            this.Controls.Add(this.dcLastName);
            this.Controls.Add(this.dcName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "addEditDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addEditDoctors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addEditDoctor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EditAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dcAddressID;
        private System.Windows.Forms.TextBox dcPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dcGender;
        private System.Windows.Forms.TextBox dcLastName;
        private System.Windows.Forms.TextBox dcName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dcSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dcDiseaseID;
        private System.Windows.Forms.BindingSource diseaseBindingSource;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dcDateOfBirth;
    }
}