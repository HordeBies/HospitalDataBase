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
    public partial class addEditAppointment : Form
    {
        static int initDoctorID;
        static DateTime initDate;
        static string initDetails;
        HospitalEntities db = Program.db;
        Appointment baseAppointment;
        bool isNew = false;
        public addEditAppointment(Appointment appointment, Form parentForm)
        {
            InitializeComponent();
            doctorBindingSource.DataSource = db.Doctors.ToList();
            if (appointment == null)
            {
                appointmentBindingSource.DataSource = new Appointment();
                baseAppointment = appointmentBindingSource.Current as Appointment;
                baseAppointment.DoctorID = 1;
                baseAppointment.Date = DateTime.Now;
                baseAppointment.Details = "";
                isNew = true;
            }
            else
            {
                appointmentBindingSource.DataSource = appointment;
                db.Appointments.Attach(appointment);
                baseAppointment = appointment;
            }
            getInitialState();
        }
        public int getAppointmentID()
        {
            return baseAppointment.ID;
        }
        public Appointment GetAppointment()
        {
            return baseAppointment;
        }
        private void getInitialState()
        {

            initDoctorID = baseAppointment.DoctorID;
            initDetails = baseAppointment.Details;
            initDate = baseAppointment.Date;
        }
        private void discardChanges()
        {
            baseAppointment.DoctorID = initDoctorID;
            baseAppointment.Details = initDetails;
            baseAppointment.Date = initDate;
        }
        private void addEditAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(appDate.Text) || String.IsNullOrEmpty(appDetails.Text) || String.IsNullOrEmpty(appDoctor.Text) || baseAppointment.DoctorID == 1)
                {
                    MessageBox.Show("Please fill the boxes correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
                try
                {
                    if(isNew)
                        db.Appointments.Add(appointmentBindingSource.Current as Appointment);
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
