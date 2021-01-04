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
    public partial class PatientPanel : Form
    {
        HospitalEntities db = Program.db;
        Patient mainPatient;
        public PatientPanel(Patient patient)
        {
            InitializeComponent();
            mainPatient = patient;
            db.Patients.Attach(patient);
            patientDiseaseRelationBindingSource.DataSource = db.PatientDiseaseRelations.Where(pdr => pdr.PatientID == mainPatient.ID).ToList();
        }

        private void PatientPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.debugPanel.Show();
            Program.debugPanel.BringToFront();
            Program.debugPanel.UpdateBindings();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(addEditPatient frm = new addEditPatient(mainPatient, this))
            {
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Successfully updated", "Profile Update", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            Program.detachAll();
        }
    }
}
