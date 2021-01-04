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
    public partial class addEditPDR : Form
    {
        private static int initPatientID;
        private static int initDiseaseID;
        private static Nullable<int> initAppointmentID;
        private static Nullable<int> initPrescriptionID;
        private static DateTime initDate;
        private Appointment initAppointment;
        HospitalEntities db = Program.db;
        private PatientDiseaseRelation basePDR;
        bool isNew = false;

        public addEditPDR(PatientDiseaseRelation pdr, AdminPanel parentForm)
        {
            InitializeComponent();
            patientBindingSource.DataSource = db.Patients.ToList();
            diseaseBindingSource.DataSource = db.Diseases.ToList();
            if (pdr == null)
            {
                patientDiseaseRelationBindingSource.DataSource = new PatientDiseaseRelation();
                basePDR = patientDiseaseRelationBindingSource.Current as PatientDiseaseRelation;
                basePDR.DiseaseID = 1;
                basePDR.PatientID = 1;
                basePDR.ChangedOn = DateTime.Now;
                isNew = true;
            }
            else
            {
                patientDiseaseRelationBindingSource.DataSource = pdr;
                db.PatientDiseaseRelations.Attach(pdr);
                basePDR = pdr;
            }
            getInitialState();
        }
        private void getInitialState()
        {
            initPatientID = basePDR.PatientID;
            initDiseaseID = basePDR.DiseaseID;
            initAppointmentID = basePDR.AppointmentID;
            initPrescriptionID = basePDR.PrescriptionID;
            initDate = basePDR.ChangedOn;
        }
        private void discardChanges()
        {
            basePDR.PatientID = initPatientID;
            basePDR.DiseaseID = initDiseaseID;
            basePDR.AppointmentID = initAppointmentID;
            basePDR.PrescriptionID = initPrescriptionID;
            basePDR.ChangedOn = initDate;
            if(initAppointment != null)
            {
                db.Appointments.Remove(initAppointment);
                db.SaveChanges();
            }
        }

        private void AddEditApp_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(pdrDate.Text))
            {
                MessageBox.Show("Please fill the Date before continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (addEditAppointment frm = new addEditAppointment(basePDR.Appointment, this))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    basePDR.AppointmentID= frm.getAppointmentID();
                    pdrAppointment.Text = frm.getAppointmentID().ToString();
                    initAppointment = frm.GetAppointment();
                }
            }
        }

        private void addEditPDR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(pdrDate.Text))
                {
                    MessageBox.Show("Please fill the boxes correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
                try
                {
                    if(isNew)
                        db.PatientDiseaseRelations.Add(patientDiseaseRelationBindingSource.Current as PatientDiseaseRelation);
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
            else { 
            discardChanges();
            e.Cancel = false;
            }
        }

        private void pdrDisease_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pdrDisease.SelectedIndex == -1)
                return;
            basePDR.DiseaseID = (pdrDisease.SelectedItem as Disease).ID;
            label3.Text = "ID: " + (pdrDisease.SelectedItem as Disease).ID.ToString();
        }

        private void pdrPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pdrPatients.SelectedIndex == -1)
                return;
            basePDR.PatientID = (pdrPatients.SelectedItem as Patient).ID;
        }
    }
}
