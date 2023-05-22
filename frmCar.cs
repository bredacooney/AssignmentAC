using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Systems.Data.SQLite;
namespace CarsDataBase
{
    public partial class frmCar : Form
    {
        // need to connect to a data source
        SQLiteConnection databaseConnection = new SQLiteConnection(@"data source = C:\data\hire.db");  // connection to SQLite 
        public frmCar()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult toUpdate = MessageBox.Show("Are you sure you'd like to Update this record?", "Update Record", MessageBoxButtons.YesNo);
            if (toUpdate == DialogResult.Yes)
            {
                updateRecord();
                MessageBox.Show("Record is updated");
            }
            else if (toUpdate == DialogResult.No)
            {
                MessageBox.Show("No Record has been  updated");
            }
            frmMake.BackColor = Color.White;
            frmEngine.BackColor = Color.White;
            frmDate.BackColor = Color.White;
            frmAvailable.BackColor = Color.White;
            frmRental.BackColor = Color.White;


        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            recordCounter("first"); // go to first position
            getData(); // get data of current position
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            recordCounter("previous"); // go to previous position
            getData(); // get data of current position
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            recordCounter("Next"); // go to next position
            getData(); // get data of current position
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            recordCount("Last"); // go to last position
            getData(); // get data of current position
        }

        int recordControlNo = 1;  // used in mumber display at bottom of for
        int totalRecords;  // Where we store the total amount of records

        public void recTotal()
        { //FINDS THE TOTAL AMOUNT OF RECORDS WHEN CALLED
            string findTotal = @"SELECT COUNT(*) FROM tblCar"; // sql Qurety to find the count of all records

            DatabaseConnection.Open();  // open the connection to the database
            var commanbd = databaseConnection.CreateCommand();
            command.CommandText = findTotal;  // turning the sql query into the command
            using (var reader = commanbd.ExecuteReader())   // using reader to execute the command
            {
                while (reader.Read())
                {
                    var total = reader.GetInt32(0);
                    totalRecords = total;  // returns the query and stores the number as totalRecords

                }

            }
            recordCount.Text = $"{recordControlNo} of {totalRecords}";   // Heres how we show our record count at the bottom of our forms
            databaseConnection.Close(); //closing the database connection


            Public void recordCounter(string frmbtn)
         // UPDATES RECORD BOX DEPENDING ON BUTTONS PRESS && ALSO USED AS A REFERENCE FOR CYCLING THROUGH -> getData()
            if (frmBtn == "next")
            {// Determines behaviour of next button
                if (recordControlNo < totalRecords)
                { recordControlNo += 1; }   //Keep adding 1 on   -  if it false it will go onto the next button

            }
            if (frmBtn == "previous")  //  If it is false it will go onto first
            { // Determines behaviour of previous button
                if (recordControlNo > 1)  // if you want to go back a previous one, it will be minus 1,
                { recordControlNo -= 1; }
            }

            // Determines behaviour of first button
            if (frmBtn == "first")  // fi this is false it goes onto the last   if the next button brought it upto 4, then it would minus back to 3, then minus back to 2
            { recordControlNo = 1; }

            // Determines behaviour of last button
            if (frmBtn == "last")
            { recordControlNo = totalRecords; }

            recordCount.Text = $"{recordControlNo} of{totalRecords}";  // updates the record counter at the bottom of our form
        }

        private void recordCount_TextChanged(object sender, EventArgs e)
        {
            recordCount.Text = $"{recordControlNo} of {totalRecords}";
        }

        private void frmCar_Load(object sender, EventArgs e)
        {
            { // this is what happens when to form loads
                try
                {
                    // It will try to load the total amount of records, and the data for the first 
                    recTotal();
                    getData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Can't load database. Check datbase connection.");  // if it fails to do the above we will display a message to the screen
                }

                btnUpdate.Enabled = false;  // Updte button unusable until use conditions are met
                btnCancel.Enabled = false;  // Cancel button unusable until use conditions are met
                btnUpdate.Visible = false;  // Panel button unusable until use conditions are met. This Panel simply has text on it nothifying if we are editing the record

                if (btnUpdate.Enabled == true)
                {
                    UpdatePanel.Visible = true;  // if Update button is on then we can see the text telling us we are editing the record
                }


            }

            Details details = new Details();
            Public void getData()
            {
                int rowPosition = recordConntrolNo - 1;

                try
                {// RETURNS DATA BASED ON SELECTED RECORD.
                    databaseConnection.Open();  // open connection
                    string getDB = $@"SELECT * FROM (SELECT * from tblCar LIMIT 1 OFFSET {rowPosition}";  // SQL query to get data from database
                    SQLiteCommand cmd = new DataTable();  // declaring dt as a new datatable
                    DataTable dt = new DataTable(); // declaring dt as a new datatable
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd); // adapter for collecting data from the database
                    adapter.Fill(dt); // filling dt with data from adapter

                    frmDataGrid.DataSource = dt;  // filling datagrid with data
                    databaseConnection.Close();  // closing connection to database

                    // making text fields in form equal to specific data search in datatable
                    frmVehicleReg.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
                    frmMake.Text = Convert.ToString(dt.Rows[0].ItemArray[2]);
                    frmEngine.Text = Convert.ToString(dt.Rows[0].ItemArray[3]);
                    frmDateReg.Text = Convert.ToString(dt.Rows[0].ItemArray[4]);
                    frmRentalPerDay.Text = Convert.ToString(dt.Rows[0].ItemArray[5]);
                    int available = Convert.ToInt32(dt.Rows[0].ItemArray[6])
                    if (available == 1)
                    {//if database returns 1 then we check the checkbox
                        frmAvailable.Checked = true;
                    }
                    else
                    {//if database returns 0 then we uncheck the checkbox
                        frmAvailable.Checked = false;
                    }

                    btnUpdate.Enabled = false;
                    btnCancel.Enabled = false;
                    updatePanel.Visible = false;

                    //Not entirely neccecary, just getting famililar with properties. I used these to display in the delete message box but its not needed
                    details.VehicleReg = frmVehicleReg.Text;
                    details.Make = frmMake.Text;
                    details.Engine = frmEngine.Text;
                    details.DateReg = frmDateReg.Text;
                    details.RentalPerDay = frmRentalPerDay.Text;
                    details.Available = available;

                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot find data");  // if getData fails to work this message box appears 
                }
            }



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSearch();
            searchForm.ShowDialog();
        }

        private void frmVehicleReg_TextChanged(object sender, EventArgs e)  // also use available , it is used to check the update and cancel if there is a change, then see   - currently editing  written in ted 
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            UpdatePanel.Visible = true;
        }

        private int availability;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd openAddForm = new frmAdd();
            this.Hide();
            openAddForm.ShowDialog();
            this.Close();

        }


        // Should I put in line 227 in Jennifers car.cs form
        private void updateRecord()
        {  //UPDATES RECORD BASED ON INFORMATION IN TEXT FIELDS
            int offsetNumber = recordControlNo - 1;
            try
            {
                if (frmAvailable.Checked == true)
                {
                    availability = 1;
                }
                if (frmAvailable.Checked == false)
                {
                    availability = 0;
                }

                string updateARecord = $@"UPDATE tblCar SET VehicleRegNo = '" + frmVehicleReg.Text + "', Make = '" + frmMake.Text + "', EngineSize == '" + frmEngine.Text + "', DateRegistered== '" + frmDateReg.Text + "', RentalPerDay = '" + frmRentalPerDay.Value + "', Available = '" + availability + "' WHERE VehicleRegNo from tblCar limit 1 OFFSET '" + OffsetNumber + "');";
                databaseConnection.Open();
                SQLiteCommand insertSQL = new SQLiteCommand(databaseConnection);
                insertSQL.CommandText = updateARecord
               insertSQL.ExecuteNonQuery();
                databaseConnection.Close();
                recTotal();
                getData();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot update data");
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult toDelete = MessageBox.Show($"Are you sure you'd like to delete this record\nVehicle Registration: {details.VehicleReg}\nMake: {details.Make}\nEngine Size: {details.Engine}\nDate Registered: {details.DateReg}\nRental PerDay: {details.RentalPerDay}\nAvailable: {Details.SAvailable}", "Delete Record", MessageBoxButtons.YesNo);
            if (toDelete == DialogResult.Yes)
            {
                deleteData();
                MessageBox.Show("Record Deleted");
            }
            else if (toDelete == DialogResult.No)
            {
                MessageBox.Show("No record has been deleted.");
            }
                
        }
        private void deleteData()
        {
            {//DELETED CURRENT DISPLAYED DATA FROM DATABASE
                try
                {
                    string delteARecord = $@"DELETE FROM FblCar WHERE VehicleRegNo = '{frmVehicleReg.Text}'";

                    databaseConnection.Open();
                    string sendData2 = deleteARecord;
                    SQLiteCommand deleteSQL = new SQLiteCommand(databaseConnection);
                    deleteSQL.CommandText = sendData2;
                    deleteSQL.ExecuteNonQuery();
                    databaseConnection.Close();
                    recTotal();
                    recordCounter("last");
                    getData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot delete data");
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            getData();
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            UpdatePanel.Visible = false;
            frmMake.BackColor = Color.White;
            frmEngine.BackColor = Color.White;
            frmDate.BackColor = Color.White;
            frmAvailable.BackColor = Color.White;
            frmRental.BackColor = Color.White;
        }

        private void frmMake_TextChanged(object sender, EventArgs e)
        {
            
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            UpdatePanel.Visible=true;
        }

        private void frmEngine_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            UpdatePanel.Visible = true;
        }

        private void frmDate_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            UpdatePanel.Visible = true;
        }

        private void frmRental_ValueChanged(object sender, EventArgs e)  // line 371 to 377 on Jennifers video
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            UpdatePanel.Visible = true;
        }
    }
}   
