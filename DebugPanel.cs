using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBM_EF
{
    public partial class DebugPanel : Form
    {
        HospitalEntities db = Program.db;
        public DebugPanel()
        {
            InitializeComponent();
            UpdateBindings();
        }

        private void opnAdminPanel_Click(object sender, EventArgs e)
        {
            Program.detachAll();
            this.Hide();
            Program.adminPanel.Show();
        }
        public void UpdateBindings()
        {
            patientBindingSource.DataSource = db.Patients.ToList();
            doctorBindingSource.DataSource = db.Doctors.ToList();
        }

        private void opnPatient_Click(object sender, EventArgs e)
        {
            Program.detachAll();
            if (ptComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a valid Patient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PatientPanel patientPanel = new PatientPanel(patientBindingSource.Current as Patient);
            patientPanel.Text = (patientBindingSource.Current as Patient).FullName;
            this.Hide();
            patientPanel.Show();
        }

        private void newPatient_Click(object sender, EventArgs e)
        {
            Program.detachAll();
            using (addEditPatient frm = new addEditPatient(null, this))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    patientBindingSource.DataSource = db.Patients.ToList();
                }
            }
            Program.detachAll();
        }

        private void newDoctor_Click(object sender, EventArgs e)
        {
            Program.detachAll();
            using (addEditDoctor frm = new addEditDoctor(null, this))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    doctorBindingSource.DataSource = db.Doctors.ToList();
                }
            }
            Program.detachAll();
        }

        private void opnDoctor_Click(object sender, EventArgs e)
        {
            if (dcComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a valid Doctor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
