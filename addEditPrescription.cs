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
    public partial class addEditPrescription : Form
    {
        static int initDoctorID;
        static DateTime initDate;
        static int initCost;
        static string initDetails;
        HospitalEntities db = Program.db;
        Prescription basePrescription;
        PatientDiseaseRelation pdr;
        bool isNew = false;
        public addEditPrescription(Prescription prescription, AdminPanel parentForm)
        {
            InitializeComponent();
            doctorBindingSource.DataSource = db.Doctors.ToList();
            if (prescription == null)
            {
                prescriptionBindingSource.DataSource = new Prescription();
                basePrescription = prescriptionBindingSource.Current as Prescription;
                basePrescription.DoctorID = 1;
                basePrescription.Date = DateTime.Now;
                isNew = true;
            }
            else
            {
                prescriptionBindingSource.DataSource = prescription;
                db.Prescriptions.Attach(prescription);
                basePrescription = prescription;
            }
            getInitialState();

        }
        public addEditPrescription(Form parentForm, PatientDiseaseRelation pdr)
        {
            InitializeComponent();
            doctorBindingSource.DataSource = db.Doctors.Where(x => x.DiseaseID == pdr.DiseaseID).ToList();
            this.pdr = pdr;
        }
        private void getInitialState()
        {
            if (basePrescription == null)
                return;
            initDoctorID = basePrescription.DoctorID;
            initDetails = basePrescription.Description;
            initDate = basePrescription.Date;
            initCost = basePrescription.Cost;
        }
        private void discardChanges()
        {
            if (basePrescription == null)
                return;
            basePrescription.DoctorID = initDoctorID;
            basePrescription.Description = initDetails;
            basePrescription.Date = initDate;
            basePrescription.Cost = initCost;
        }

        private void addEditPrescription_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (pdr == null) { 
                if (String.IsNullOrEmpty(preCost.Text) || String.IsNullOrEmpty(preDate.Text) || String.IsNullOrEmpty(preDoctor.Text) || String.IsNullOrEmpty(preDetails.Text))
                {
                    MessageBox.Show("Please fill the boxes correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
                try
                {
                    if(isNew)
                        db.Prescriptions.Add(prescriptionBindingSource.Current as Prescription);
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
                }
                else
                {
                    if((preDoctor.SelectedItem as Doctor).ID == 1)
                    {
                        MessageBox.Show("Please select a valid Doctor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                        return;
                    }
                    db.MakeAppointment(pdr.ID, (preDoctor.SelectedItem as Doctor).ID, "");
                    db.SaveChanges();
                }
                e.Cancel = false;
            }
            discardChanges();
            e.Cancel = false;
        }

        private void preDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(pdr == null)
            {
                if (preDoctor.SelectedIndex == -1)
                    return;
                basePrescription.DoctorID= (preDoctor.SelectedItem as Doctor).ID;
            }
        }
    }
}
