using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBM_EF
{
    public partial class addEditDisease : Form
    {
        static string initName;
        static string initDetails;
        static Nullable<decimal> initCureRate;
        HospitalEntities db = Program.db;
        Disease baseDisease;
        bool isNew = false;
        public addEditDisease(Disease disease,AdminPanel parentForm)
        {
            InitializeComponent();
            if (disease == null)
            {
                diseaseBindingSource.DataSource = new Disease();
                baseDisease = diseaseBindingSource.Current as Disease;
                isNew = true;
            }
            else
            {
                diseaseBindingSource.DataSource = disease;
                db.Diseases.Attach(disease);
                baseDisease = disease;
            }
            getInitialState();
        }
        private void getInitialState()
        {

            initName = baseDisease.Name;
            initDetails = baseDisease.Details;
            initCureRate = baseDisease.CureRate;
        }
        private void discardChanges()
        {
            baseDisease.Name = initName;
            baseDisease.Details = initDetails;
            baseDisease.CureRate = initCureRate;
        }
        private void addEditDisease_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(dsName.Text) || String.IsNullOrEmpty(dsCR.Text))
                {
                    MessageBox.Show("Please fill the boxes correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
                try
                {
                    if(isNew)
                        db.Diseases.Add(diseaseBindingSource.Current as Disease);
                    db.SaveChanges();
                    getInitialState();
                }
                catch (Exception err)
                {
                    while (err.InnerException != null)
                        err = err.InnerException;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
                e.Cancel = false;
            }
            discardChanges();
            e.Cancel = false;
        }
    }
}
