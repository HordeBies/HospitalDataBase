
namespace DBM_EF
{
    partial class addEditPatient
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
            this.ptGender = new System.Windows.Forms.TextBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ptLastName = new System.Windows.Forms.TextBox();
            this.ptName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ptPhoneNumber = new System.Windows.Forms.TextBox();
            this.ptAddressID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EditAddress = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ptDateOfBirth = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(97, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Gender(0,1):";
            // 
            // ptGender
            // 
            this.ptGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Gender", true));
            this.ptGender.Location = new System.Drawing.Point(97, 58);
            this.ptGender.Name = "ptGender";
            this.ptGender.Size = new System.Drawing.Size(100, 20);
            this.ptGender.TabIndex = 11;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(DBM_EF.Patient);
            // 
            // ptLastName
            // 
            this.ptLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "LastName", true));
            this.ptLastName.Location = new System.Drawing.Point(97, 32);
            this.ptLastName.Name = "ptLastName";
            this.ptLastName.Size = new System.Drawing.Size(100, 20);
            this.ptLastName.TabIndex = 10;
            // 
            // ptName
            // 
            this.ptName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Name", true));
            this.ptName.Location = new System.Drawing.Point(97, 6);
            this.ptName.Name = "ptName";
            this.ptName.Size = new System.Drawing.Size(100, 20);
            this.ptName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone Number:";
            // 
            // ptPhoneNumber
            // 
            this.ptPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "PhoneNumber", true));
            this.ptPhoneNumber.Location = new System.Drawing.Point(97, 84);
            this.ptPhoneNumber.Name = "ptPhoneNumber";
            this.ptPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.ptPhoneNumber.TabIndex = 15;
            // 
            // ptAddressID
            // 
            this.ptAddressID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "AddressID", true));
            this.ptAddressID.Location = new System.Drawing.Point(97, 136);
            this.ptAddressID.Name = "ptAddressID";
            this.ptAddressID.ReadOnly = true;
            this.ptAddressID.Size = new System.Drawing.Size(100, 20);
            this.ptAddressID.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date Of Birth:";
            // 
            // EditAddress
            // 
            this.EditAddress.Location = new System.Drawing.Point(204, 132);
            this.EditAddress.Name = "EditAddress";
            this.EditAddress.Size = new System.Drawing.Size(75, 23);
            this.EditAddress.TabIndex = 19;
            this.EditAddress.Text = "Add/Edit";
            this.EditAddress.UseVisualStyleBackColor = true;
            this.EditAddress.Click += new System.EventHandler(this.EditAddress_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Address ID:";
            // 
            // ptDateOfBirth
            // 
            this.ptDateOfBirth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "DateOfBirth", true));
            this.ptDateOfBirth.Location = new System.Drawing.Point(97, 110);
            this.ptDateOfBirth.Name = "ptDateOfBirth";
            this.ptDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.ptDateOfBirth.TabIndex = 21;
            this.ptDateOfBirth.Value = new System.DateTime(2021, 1, 2, 11, 47, 16, 0);
            // 
            // addEditPatient
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 206);
            this.Controls.Add(this.ptDateOfBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EditAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ptAddressID);
            this.Controls.Add(this.ptPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ptGender);
            this.Controls.Add(this.ptLastName);
            this.Controls.Add(this.ptName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "addEditPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addEditPatient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addEditPatient_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ptGender;
        private System.Windows.Forms.TextBox ptLastName;
        private System.Windows.Forms.TextBox ptName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ptPhoneNumber;
        private System.Windows.Forms.TextBox ptAddressID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EditAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.DateTimePicker ptDateOfBirth;
    }
}