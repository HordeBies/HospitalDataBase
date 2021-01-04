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
    public partial class AdminPanel : Form
    {
        private HospitalEntities db = Program.db;
        public AdminPanel()
        {
            InitializeComponent();
            toolStripComboBox1.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("No table selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    using (addEditAddress frm = new addEditAddress(null, this))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                            AddressBindingSource.DataSource = db.Addresses.ToList();
                    }
                    break;
                case 2:
                    using (addEditDisease frm = new addEditDisease(null, this))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                            diseaseBindingSource.DataSource = db.Diseases.ToList();
                    }
                    break;
                case 3:
                    using (addEditPatient frm = new addEditPatient(null, this))
                    {
                        if (frm.ShowDialog() == DialogResult.OK) { 
                            PatientBindingSource.DataSource = db.Patients.ToList();
                            AddressBindingSource.DataSource = db.Addresses.ToList();
                        }
                    }
                    break;
                case 4:
                    using (addEditDoctor frm = new addEditDoctor(null,this))
                    {
                        if(frm.ShowDialog() == DialogResult.OK)
                        {
                            DoctorBindingSource.DataSource = db.Doctors.ToList();
                            AddressBindingSource.DataSource = db.Addresses.ToList();
                        }
                    }
                    break;
                case 5:
                    using (addEditPrescription frm = new addEditPrescription(null, this))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            PrescriptionBindingSource.DataSource = db.Prescriptions.ToList();
                        }
                    }
                    break;
                case 6:
                    using (addEditAppointment frm = new addEditAppointment(null, this))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            AppointmentBindingSource.DataSource = db.Appointments.ToList();
                        }
                    }
                    break;
                case 7:
                    using (addEditPDR frm = new addEditPDR(null, this))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            PdrBindingSource.DataSource = db.PatientDiseaseRelations.ToList();
                            AppointmentBindingSource.DataSource = db.Appointments.ToList();
                            PrescriptionBindingSource.DataSource = db.Prescriptions.ToList();
                        }
                    }
                    break;
                default:
                    MessageBox.Show("Cant Add on View Table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            dataGridView.Refresh();
            Program.detachAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("No table selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    if(AddressBindingSource.Current == null)
                    {
                        MessageBox.Show("No Address selected for editing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    using (addEditAddress frm = new addEditAddress(AddressBindingSource.Current as Address, this))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                            AddressBindingSource.DataSource = db.Addresses.ToList();
                    }
                    break;
                case 2:
                    if (diseaseBindingSource.Current == null)
                    {
                        MessageBox.Show("No Disease selected for editing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    using (addEditDisease frm = new addEditDisease(diseaseBindingSource.Current as Disease, this))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                            diseaseBindingSource.DataSource = db.Diseases.ToList();
                    }
                    break;
                case 3:
                    if (PatientBindingSource.Current == null)
                    {
                        MessageBox.Show("No Patient selected for editing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    using (addEditPatient frm = new addEditPatient(PatientBindingSource.Current as Patient, this))
                    {
                        if (frm.ShowDialog() == DialogResult.OK) { 
                            PatientBindingSource.DataSource = db.Patients.ToList();
                            AddressBindingSource.DataSource = db.Addresses.ToList();
                        }
                    }
                    break;
                case 4:
                    if(DoctorBindingSource.Current == null)
                    {
                        MessageBox.Show("No Doctor selected for editing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    using(addEditDoctor frm = new addEditDoctor(DoctorBindingSource.Current as Doctor, this))
                    {
                        if(frm.ShowDialog() == DialogResult.OK)
                        {
                            DoctorBindingSource.DataSource = db.Doctors.ToList();
                            AddressBindingSource.DataSource = db.Addresses.ToList();
                        }
                    }
                    break;
                case 5:
                    if(PrescriptionBindingSource.Current == null)
                    {
                        MessageBox.Show("No Prescription selected for editing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    using(addEditPrescription frm = new addEditPrescription(PrescriptionBindingSource.Current as Prescription, this))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            PrescriptionBindingSource.DataSource = db.Prescriptions.ToList();
                        }
                    }
                    break;
                case 6:
                    if(AppointmentBindingSource.Current == null)
                    {
                        MessageBox.Show("No Appointment selected for editing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    using(addEditAppointment frm = new addEditAppointment(AppointmentBindingSource.Current as Appointment, this))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            AppointmentBindingSource.DataSource = db.Appointments.ToList();
                        }
                    }
                    break;
                case 7:
                    if(PdrBindingSource.Current == null)
                    {
                        MessageBox.Show("No PDR selected for editing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    using (addEditPDR frm = new addEditPDR(PdrBindingSource.Current as PatientDiseaseRelation, this))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            PdrBindingSource.DataSource = db.PatientDiseaseRelations.ToList();
                            AppointmentBindingSource.DataSource = db.Appointments.ToList();
                            PrescriptionBindingSource.DataSource = db.Prescriptions.ToList();
                        }
                    }
                        break;
                default:
                    MessageBox.Show("Cant Edit on View Table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            dataGridView.Refresh();
            Program.detachAll();
        }

        private void tryDelete(BindingSource bs)
        {
            try
            { 
                db.SaveChanges();
                bs.RemoveCurrent();
            }
            catch (Exception err)
            {
                while (err.InnerException != null)
                    err = err.InnerException;
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.detachAll();
                toolStripComboBox1_SelectedIndexChanged(null, null);
            }
        }
        private void bttnDel_Click(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("No table selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    if (AddressBindingSource.Current == null || (AddressBindingSource.Current as Address).ID ==1)
                    {
                        MessageBox.Show("No Address selected for deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to delete this Address?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Addresses.Remove(AddressBindingSource.Current as Address);
                            tryDelete(AddressBindingSource);
                        }
                    }
                    break;
                case 2:
                    if (diseaseBindingSource.Current == null || (diseaseBindingSource.Current as Disease).ID == 1)
                    {
                        MessageBox.Show("No Disease selected for deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to delete this Disease?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Diseases.Remove(diseaseBindingSource.Current as Disease);
                            tryDelete(diseaseBindingSource);
                        }
                    }
                    break;
                case 3:
                    if (PatientBindingSource.Current == null || (PatientBindingSource.Current as Patient).ID == 1)
                    {
                        MessageBox.Show("No Patient selected for deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to delete this Patient?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Patients.Remove(PatientBindingSource.Current as Patient);
                            tryDelete(PatientBindingSource);
                        }
                    }
                    break;
                case 4:
                    if (DoctorBindingSource.Current == null || (DoctorBindingSource.Current as Doctor).ID == 1)
                    {
                        MessageBox.Show("No Doctor selected for deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to delete this Doctor?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Doctors.Remove(DoctorBindingSource.Current as Doctor);
                            tryDelete(DoctorBindingSource);
                        }
                    }
                    break;
                case 5:
                    if (PrescriptionBindingSource.Current == null || (PrescriptionBindingSource.Current as Prescription).ID == 1)
                    {
                        MessageBox.Show("No Prescription selected for deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to delete this Prescription?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Prescriptions.Remove(PrescriptionBindingSource.Current as Prescription);
                            tryDelete(PrescriptionBindingSource);
                        }
                    }
                    break;
                case 6:
                    if (AppointmentBindingSource.Current == null || (AppointmentBindingSource.Current as Appointment).ID == 1)
                    {
                        MessageBox.Show("No Appointment selected for deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to delete this Appointment?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Appointments.Remove(AppointmentBindingSource.Current as Appointment);
                            tryDelete(AppointmentBindingSource);
                        }
                    }
                    break;
                case 7:
                    if (PdrBindingSource.Current == null || (PdrBindingSource.Current as PatientDiseaseRelation).ID == 1)
                    {
                        MessageBox.Show("No PatientDiseaseRelation selected for deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to delete this PatientDiseaseRelation?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.PatientDiseaseRelations.Remove(PdrBindingSource.Current as PatientDiseaseRelation);
                            tryDelete(PdrBindingSource);
                        }
                    }
                    break;
                default:
                    MessageBox.Show("Cant Delete on View Table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        //Columns to show in application(EF& I have added some relational columns)
        static string[] AdrColumns = new[] { "Doctors", "Patients" };
        static string[] DisColumns = new[] { "Doctors","PatientDiseaseRelations" };
        static string[] PatColumns = new[] { "Address","PatientDiseaseRelations" ,"FullName"};
        static string[] DocColumns = new[] { "Appointments", "Address", "Disease", "Prescriptions", "FullName" };
        static string[] PreColumns = new[] { "Doctor", "PatientDiseaseRelations" };
        static string[] AppColumns = new[] { "Doctor", "PatientDiseaseRelations" };
        static string[] PdrColumns = new[] { "Appointment", "Disease", "Patient", "Prescription" };
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView.DataSource = null;
                    break;
                case 1:
                    AddressBindingSource.DataSource = db.Addresses.ToList();
                    dataGridView.DataSource = AddressBindingSource;
                    dataGridView.Columns.Cast<DataGridViewColumn>().Where(x => AdrColumns.Contains(x.DataPropertyName)).ToList().ForEach(x => { x.Visible = false; });
                    break;
                case 2:
                    diseaseBindingSource.DataSource = db.Diseases.ToList();
                    dataGridView.DataSource = diseaseBindingSource;
                    dataGridView.Columns.Cast<DataGridViewColumn>().Where(x => DisColumns.Contains(x.DataPropertyName)).ToList().ForEach(x => { x.Visible = false; });
                    break;
                case 3:
                    PatientBindingSource.DataSource = db.Patients.ToList();
                    dataGridView.DataSource = PatientBindingSource;
                    dataGridView.Columns.Cast<DataGridViewColumn>().Where(x => PatColumns.Contains(x.DataPropertyName)).ToList().ForEach(x => { x.Visible = false; });
                    break;
                case 4:
                    DoctorBindingSource.DataSource = db.Doctors.ToList();
                    dataGridView.DataSource = DoctorBindingSource;
                    dataGridView.Columns.Cast<DataGridViewColumn>().Where(x => DocColumns.Contains(x.DataPropertyName)).ToList().ForEach(x => { x.Visible = false; });
                    break;
                case 5:
                    PrescriptionBindingSource.DataSource = db.Prescriptions.ToList();
                    dataGridView.DataSource = PrescriptionBindingSource;
                    dataGridView.Columns.Cast<DataGridViewColumn>().Where(x => PreColumns.Contains(x.DataPropertyName)).ToList().ForEach(x => { x.Visible = false; });
                    break;
                case 6:
                    AppointmentBindingSource.DataSource = db.Appointments.ToList();
                    dataGridView.DataSource = AppointmentBindingSource;
                    dataGridView.Columns.Cast<DataGridViewColumn>().Where(x => AppColumns.Contains(x.DataPropertyName)).ToList().ForEach(x => { x.Visible = false; });
                    break;
                case 7:
                    PdrBindingSource.DataSource = db.PatientDiseaseRelations.ToList();
                    dataGridView.DataSource = PdrBindingSource;
                    dataGridView.Columns.Cast<DataGridViewColumn>().Where(x => PdrColumns.Contains(x.DataPropertyName)).ToList().ForEach(x => { x.Visible = false; });
                    break;
                case 8:
                    dataGridView.DataSource = db.DoctorsThatDontHaveAppointmentTodays.ToList();
                    break;
                case 9:
                    dataGridView.DataSource = db.PatientsWaitingAppointments.ToList();
                    break;
                default:
                    break;
            }
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)//debug helper function
        {
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Program.debugPanel.Show();
            Program.debugPanel.BringToFront();
            e.Cancel = true;
            Program.debugPanel.UpdateBindings();
        }
    }
}
