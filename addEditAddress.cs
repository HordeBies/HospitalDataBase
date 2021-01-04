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
    public partial class addEditAddress : Form
    {
        static string initCity;
        static string initStreet;
        static int initNumber;
        HospitalEntities db = Program.db;
        Address baseAddress;
        bool isNew = false;
        public addEditAddress(Address address,Form parentForm)
        {
            InitializeComponent();
            if(address == null)
            {
                addressBindingSource.DataSource = new Address();
                baseAddress = addressBindingSource.Current as Address;
                isNew = true;
            }
            else
            {
                addressBindingSource.DataSource = address;
                db.Addresses.Attach(address);
                baseAddress = address;
            }
            getInitialState();
        }
        private void getInitialState()
        {
            initCity = baseAddress.City;
            initStreet = baseAddress.Street;
            initNumber = baseAddress.Number;
        }
        private void discardChanges()
        {
            baseAddress.City = initCity;
            baseAddress.Street = initStreet;
            baseAddress.Number = initNumber;
        }
        public int getAddressID()
        {
            return baseAddress.ID;
        }
        public Address getAddress() 
        {
            return baseAddress;
        }

        private void addEditAddress_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(adrCity.Text) || String.IsNullOrEmpty(adrNumber.Text) || String.IsNullOrEmpty(adrStreet.Text))
                {
                    MessageBox.Show("Please fill the boxes correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
                try
                {
                    if(isNew)
                        db.Addresses.Add(addressBindingSource.Current as Address);
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
