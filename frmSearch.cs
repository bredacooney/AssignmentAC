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
using System.Data.SqlClient;

namespace CarsDataBase
{
    public partial class frmSearch : Form
    {
        SQLiteConnection databaseConnection = new SQLiteConnection(@"data source = c:\data\hire,db");  // connects to the Databas
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // populate cbofield with field names, make, enginexize, rentalperday, available
            cboField.Items.Add("Vehicle Registration Number");
            cboField.Items.Add("Make");
            cboField.Items.Add("Engine Size");
            cboField.Items.Add("Rental Per Day");
            cboField.Items.Add("Available");
            // = OPERATOR ALWAYS STAYS.  OTHER OPERATORS IN FUNCTION THAT DETERMINES OF THEY DISPLAY
            cboOperator.Items.Add("=");

            searchData();  // <--  UMCOMMENT TO SEARCH DATA RESULTS WHEN FORM LOADS
        }
        private void searchData()
        {// SETTING UP SEARCH PARAMATERS
            string findData = @"SELECT * FROM tblCar";
            if (cboField.Text != "" && cboOperator.Text != "" && valueTextbox.Text != "")
            {
                //Available
                if (cboField.Text == "Available")
                {
                    if (valueTextbox.Text == "Yes")
                    {
                        cboOperator.Text = "=";
                        findData = $@"SELECT * FROM tblCar WHERE Available != 0)";
                        //search
                    }
                    else if (valueTextbox.Text == "No")
                    {
                        cboOperator.Text = "=";
                        findData = $@"SELECT * FROM tblCar WHERE Available = 0)";
                     //search
                    }
                    else if (valueTextbox.Text != "Yes"  || valueTextbox.Text != "No")
                    {
                        MessageBox.Show("Please Enter 'Yes' or 'No'. Ensure Capitals are present.");
                        valueTextbox.Text = "";
                        return;
                    }

                }//EngineSize
                if (cboField.Text == "Engine Size")
                {
                    findData = $@"SELECT * FROM tblCar WHERE EngineSize {cboOperator.Text} '{valueTextbox.Text.TrimEnd ('L') }L'";
                }
                // Rental Per Day
                if (cboField.Text == "Rental Per Day")
                {
                    findData = $@"SELECT * FROM tblCar WHERE RentalPerDay {cboOperator.Text} '{valueTextbox.Text}'";
                }
                //Make
                if (cboField.Text == "Make")
                {
                    cboOperator.Text = "=";
                    findData = $@"SELECT * FROM tblCar WHERE Make = '{valueTextbox.Text}'";
                }

                //vehicle Registration number
                if (cboField.Text == "Vehicle Registration Number")
                { 
                    cboField.Text = "=";
                    findData = $@"SELECT * FROM tblCar WHERE VehicleRegNo = '{valueTextbox.Text}'";
                
                
                }



                // OPENING DB AND SEARCHING PARAMATERS
                SQLiteConnection connect = new SQLiteConnection(@"data source = C:\data\hire.db");
                connect.Open();
                string Query = findData;
                SQLiteCommand cmd = new SQLiteCommand(Query, connect);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(cmd);
                adapter2.Fill(dt);
                frmDataGrid.DataSource = dt;
                connect.Close();



            }

        }

        private void frmDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {

        }

        public void displayDB()
        {

        }

        private void cboField_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeOrAddOperators();
        }

        private void removeOrAddOperators()
        {
            // ADDS OR REMOVES OPERATOR FROM THE FORM DEPENDING ON FIELD SELECTION
            if (cboField.Text == "Available " || cboField.Text == "Vehicle Registration Number" | cboField.Text == "Make")
            {
                cboOperator.Items.Remove("<");
                cboOperator.Items.Remove(">");
                cboOperator.Items.Remove("<=");
                cboOperator.Items.Remove(">=");
            }
            if ((cboField.Text == "Engine Size" || cboField.Text == "Rental Per Day") && !cboField.Items.Contains("<") && !cboOperator.Items.Contains(">" ) && !cboOperator.Items.Contains("<=") && !cboOperator.Items.Contains(">="))
            {
                cboOperator.Items.Add("<");
                cboOperator.Items.Add(">");
                cboOperator.Items.Add("<=");
                cboOperator.Items.Add(">=");
            }

        }
    }
}
