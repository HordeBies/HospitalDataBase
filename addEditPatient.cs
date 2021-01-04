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
    public partial class addEditPatient : Form
    {
        private static string initName;
        private static string initLastName;
        private static bool initGender;
        private static string initPhoneNumber;
        private static DateTime initDateOfBirth;
        private static int initAddressID;
        private Address initAddress;
        HospitalEntities db = Program.db;
        Patient basePatient;
        bool isNew = false;
        public addEditPatient(Patient patient, Form parentForm)
        {
            InitializeComponent();
            if (patient == null)
            {
                patientBindingSource.DataSource = new Patient();
                basePatient = patientBindingSource.Current as Patient;
                basePatient.AddressID = 1;
                basePatient.DateOfBirth = DateTime.Now;
                basePatient.Name = "";
                basePatient.LastName = "";
                basePatient.Gender = false;
                basePatient.PhoneNumber = "";
                isNew = true;
            }
            else
            {
                patientBindingSource.DataSource = patient;
                db.Patients.Attach(patient);
                basePatient = patient;
            }
            getInitialState();
        }
        private void getInitialState()
        {

            initName = basePatient.Name;
            initLastName = basePatient.LastName;
            initGender = basePatient.Gender;
            initPhoneNumber = basePatient.PhoneNumber;
            initDateOfBirth = basePatient.DateOfBirth;
            initAddressID = basePatient.AddressID;

        }
        private void discardChanges()
        {
            basePatient.Name = initName;
            basePatient.LastName = initLastName;
            basePatient.Gender = initGender;
            basePatient.PhoneNumber = initPhoneNumber;
            basePatient.DateOfBirth = initDateOfBirth;
            basePatient.AddressID = initAddressID;
            if(isNew)
            {
                db.Addresses.Remove(initAddress);
            }
            db.SaveChanges();
        }
        private void EditAddress_Click(object sender, EventArgs e)
        {
            using (addEditAddress frm = new addEditAddress(basePatient.Address,this))
            {
                if (frm.ShowDialog() == DialogResult.OK) { 
                    ptAddressID.Text = frm.getAddressID().ToString();
                    basePatient.AddressID = frm.getAddressID();
                    initAddress = frm.getAddress();
                }
            }
        }

        private void addEditPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(ptName.Text) || String.IsNullOrEmpty(ptAddressID.Text) || String.IsNullOrEmpty(ptDateOfBirth.Text) || String.IsNullOrEmpty(ptGender.Text) || String.IsNullOrEmpty(ptLastName.Text) || String.IsNullOrEmpty(ptPhoneNumber.Text) || basePatient.AddressID == 1)
                {
                    MessageBox.Show("Please fill the boxes correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
                try
                {
                    if(isNew)
                        db.Patients.Add(patientBindingSource.Current as Patient);
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
    }
}
