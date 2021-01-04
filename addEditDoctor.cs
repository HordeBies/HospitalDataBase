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
    public partial class addEditDoctor : Form
    {
        private static string initName;
        private static string initLastName;
        private static bool initGender;
        private static string initPhoneNumber;
        private static DateTime initDateOfBirth;
        private static int initSalary;
        private static int initAddressID;
        private static int initDiseaseID;
        private Address initAddress;
        HospitalEntities db = Program.db;
        Doctor baseDoctor;
        bool isNew = false;
        public addEditDoctor(Doctor doctor, Form parentForm)
        {
            InitializeComponent();
            diseaseBindingSource.DataSource = db.Diseases.ToList();
            label9.Text = "ID: " + (dcDiseaseID.SelectedItem as Disease).ID.ToString();

            if (doctor == null)
            {
                doctorBindingSource.DataSource = new Doctor();
                baseDoctor = doctorBindingSource.Current as Doctor;
                baseDoctor.AddressID = 1;
                baseDoctor.DiseaseID = 1;
                baseDoctor.Name = "";
                baseDoctor.LastName = "";
                baseDoctor.Gender = false;
                baseDoctor.PhoneNumber = "";
                baseDoctor.DateOfBirth = DateTime.Now;
                baseDoctor.Salary = 0;
                isNew = true;
            }
            else
            {
                doctorBindingSource.DataSource = doctor;
                db.Doctors.Attach(doctor);
                baseDoctor = doctor;
            }
            getInitialState();
        }
        private void getInitialState()
        {

            initName = baseDoctor.Name;
            initLastName = baseDoctor.LastName;
            initGender = baseDoctor.Gender;
            initPhoneNumber = baseDoctor.PhoneNumber;
            initDateOfBirth = baseDoctor.DateOfBirth;
            initSalary = baseDoctor.Salary;
            initAddressID = baseDoctor.AddressID;
            initDiseaseID = baseDoctor.DiseaseID;

        }
        private void discardChanges()
        {
            baseDoctor.Name = initName;
            baseDoctor.LastName = initLastName;
            baseDoctor.Gender = initGender;
            baseDoctor.PhoneNumber = initPhoneNumber;
            baseDoctor.DateOfBirth = initDateOfBirth;
            baseDoctor.Salary = initSalary;
            baseDoctor.AddressID = initAddressID;
            baseDoctor.DiseaseID = initDiseaseID;
            if(initAddress != null)
            {
                db.Addresses.Remove(initAddress);
                db.Doctors.Remove(baseDoctor);
                db.SaveChanges();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dcDiseaseID.SelectedIndex == -1)
                return;
            baseDoctor.DiseaseID = (dcDiseaseID.SelectedItem as Disease).ID;
            label9.Text = "ID: "+ (dcDiseaseID.SelectedItem as Disease).ID.ToString();
        }

        private void EditAddress_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(dcName.Text) || String.IsNullOrEmpty(dcAddressID.Text) || String.IsNullOrEmpty(dcDateOfBirth.Text)
                    || String.IsNullOrEmpty(dcGender.Text) || String.IsNullOrEmpty(dcLastName.Text) || String.IsNullOrEmpty(dcPhoneNumber.Text)
                    || String.IsNullOrEmpty(dcSalary.Text) || String.IsNullOrEmpty(dcDiseaseID.Text))
            {
                MessageBox.Show("Please fill all other areas before adding address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (addEditAddress frm = new addEditAddress(baseDoctor.Address, this))
            {
                if (frm.ShowDialog() == DialogResult.OK) { 
                    baseDoctor.AddressID= frm.getAddressID();
                    dcAddressID.Text = frm.getAddressID().ToString();
                    initAddress = frm.getAddress();
                }
            }
        }

        private void addEditDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(dcName.Text) || String.IsNullOrEmpty(dcAddressID.Text) || String.IsNullOrEmpty(dcDateOfBirth.Text) 
                    || String.IsNullOrEmpty(dcGender.Text) || String.IsNullOrEmpty(dcLastName.Text) || String.IsNullOrEmpty(dcPhoneNumber.Text)
                    || String.IsNullOrEmpty(dcSalary.Text) || String.IsNullOrEmpty(dcDiseaseID.Text) || baseDoctor.DiseaseID == 1 || baseDoctor.AddressID == 1)
                {
                    MessageBox.Show("Please fill the boxes correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
                try
                {
                    if(isNew)
                        db.Doctors.Add(doctorBindingSource.Current as Doctor);
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
