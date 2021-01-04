
namespace DBM_EF
{
    partial class addEditDisease
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dsName = new System.Windows.Forms.TextBox();
            this.diseaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDetails = new System.Windows.Forms.TextBox();
            this.dsCR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disease Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Details";
            // 
            // dsName
            // 
            this.dsName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diseaseBindingSource, "Name", true));
            this.dsName.Location = new System.Drawing.Point(99, 5);
            this.dsName.Name = "dsName";
            this.dsName.Size = new System.Drawing.Size(100, 20);
            this.dsName.TabIndex = 2;
            // 
            // diseaseBindingSource
            // 
            this.diseaseBindingSource.DataSource = typeof(DBM_EF.Disease);
            // 
            // dsDetails
            // 
            this.dsDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diseaseBindingSource, "Details", true));
            this.dsDetails.Location = new System.Drawing.Point(99, 31);
            this.dsDetails.Multiline = true;
            this.dsDetails.Name = "dsDetails";
            this.dsDetails.Size = new System.Drawing.Size(153, 53);
            this.dsDetails.TabIndex = 3;
            // 
            // dsCR
            // 
            this.dsCR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diseaseBindingSource, "CureRate", true));
            this.dsCR.Location = new System.Drawing.Point(99, 90);
            this.dsCR.Name = "dsCR";
            this.dsCR.Size = new System.Drawing.Size(100, 20);
            this.dsCR.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CureRate:";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(99, 134);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // addEditDisease
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 169);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dsCR);
            this.Controls.Add(this.dsDetails);
            this.Controls.Add(this.dsName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "addEditDisease";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Disease";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addEditDisease_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dsName;
        private System.Windows.Forms.TextBox dsDetails;
        private System.Windows.Forms.TextBox dsCR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource diseaseBindingSource;
    }
}