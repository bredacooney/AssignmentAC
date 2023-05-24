using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CarsDataBase
{
    public partial class frmAdd : Form
    {
        SQLiteConnection connect = new SQLiteConnection(@"data source = C:\data\hire.db"); // connects to the Database
        public frmAdd()
        {
            InitializeComponent();
        }
        private int availability;
        private string returnedReg;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (frmVehicleReg.Text != "" && frmMake.Text != "" && frmDate.Text != "" && frmEngine.Text != "" && frmRental.Value != 0)
                try
                { 
                    //STRINGS USED FOR DB

                    string isRegInDb = $@"SELECT VehicleRegNo FROM tblCar WHERE VehicleRegNo = '" + frmVehicleReg.Text + "'";
                    connect.Open();


                    var command = connect.CreateCommand();
                    command.CommandText = isRegInDb;

                    using (var reader = command.ExecuteReader())
                    {//GETTING MATCHING RECORD
                        while (reader.Read())
                        {
                            var reg = reader.GetString(0);
                            returnedReg = reg;
                        }

                        // RETURNING IF VEHICLE REG MATCHES RECORD IN DB
                        if (frmVehicleReg.Text == returnedReg)
                        {
                            MessageBox.Show("Vehicle Registration Number may already exist in the database.");
                        }

                       //ADDING RECORD IF VehicleRegNo DOSEN'T MATCH
                       if (frmVehicleReg.Text != returnedReg) 
                        {
                            if (frmAvailable.Checked == true)
                            {
                                availability = 1;
                            }
                            if (frmAvailable.Checked == false)
                            {
                                availability = 0;
                            }

                            string AddARecord = $@"INSERT INTO tblCar (VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available) VALUES 
                                                ('" + frmVehicleReg.Text + "', '" + frmMake.Text + "', '" + frmEngine.Text + "', '" + frmDate.Text + "','" + frmRental.Value + "', '" + availability + "')";
                            SQLiteCommand insertSQL = new SQLiteCommand(AddARecord, connect);
                            insertSQL.CommandText = AddARecord;
                            insertSQL.ExecuteNonQuery();
                            MessageBox.Show("You have succesfully added a new record to the database");
                            connect.Close();
                        }
    

                    }
                
                         
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot add data");
                    return;
                }
            else
            {
                MessageBox.Show("please make sure all fields are completed");
            }

        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
        }

        private void frmVehicleReg_TextChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnClose.Enabled = true;

        }

        private void frmMake_TextChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnClose.Enabled = true;
        }

        private void frmEngine_TextChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnClose.Enabled = true;
        }

        private void frmDate_TextChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnClose.Enabled = true;
        }

        private void frmRental_ValueChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnClose.Enabled = true;
        }

        private void frmAvailable_CheckedChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnClose.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            frmVehicleReg.Text = "";
            frmMake.Text = "";
            frmEngine.Text = "";
            frmDate.Text = "";
            frmRentalLabel.Text = "0";
            frmAvailable.Checked = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmCar goToFormCars = new frmCar();
            this.Hide();
            goToFormCars.ShowDialog(); ;
            this.Close();
        }
    }
    
}
