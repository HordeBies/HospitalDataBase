
namespace DBM_EF
{
    partial class addEditAddress
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
            this.adrNumber = new System.Windows.Forms.TextBox();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adrStreet = new System.Windows.Forms.TextBox();
            this.adrCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(72, 84);
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
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number:";
            // 
            // adrNumber
            // 
            this.adrNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "Number", true));
            this.adrNumber.Location = new System.Drawing.Point(72, 58);
            this.adrNumber.Name = "adrNumber";
            this.adrNumber.Size = new System.Drawing.Size(100, 20);
            this.adrNumber.TabIndex = 11;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(DBM_EF.Address);
            // 
            // adrStreet
            // 
            this.adrStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "Street", true));
            this.adrStreet.Location = new System.Drawing.Point(72, 32);
            this.adrStreet.Name = "adrStreet";
            this.adrStreet.Size = new System.Drawing.Size(153, 20);
            this.adrStreet.TabIndex = 10;
            // 
            // adrCity
            // 
            this.adrCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "City", true));
            this.adrCity.Location = new System.Drawing.Point(72, 6);
            this.adrCity.Name = "adrCity";
            this.adrCity.Size = new System.Drawing.Size(100, 20);
            this.adrCity.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Street:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "City:";
            // 
            // addEditAddress
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 150);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adrNumber);
            this.Controls.Add(this.adrStreet);
            this.Controls.Add(this.adrCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "addEditAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addEditAddress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addEditAddress_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adrNumber;
        private System.Windows.Forms.TextBox adrStreet;
        private System.Windows.Forms.TextBox adrCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource addressBindingSource;
    }
}