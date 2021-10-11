using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NWU_Pointsch_System
{
    public partial class frmPointschMachine : Form
    {
        public string sActionType = "";
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbPointsch.mdf;Integrated Security=True";
        SqlConnection conn;   //all my public statements
        SqlCommand comm,comm2;
        SqlDataAdapter adap;
        SqlDataReader reader;
        string sql, sql2 = "";
        private string typeCode;

        public frmPointschMachine()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                frmPointschMachine fsa = (frmPointschMachine)Application.OpenForms["frmPointschMachine"];
                fsa.Close();
            }
            catch (NullReferenceException ne)
            {
                //FORM IS NOT OPEN
            }
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(currentDateTime.ToString());
            if (sActionType == "AD")
            {                
                //MessageBox.Show(typeCode);

                sql = "INSERT INTO Discipline (Discipline_Student_ID, Student_NWU_ID, Staff_NWU_ID, Discipline_Date, Discipline_Description, Discipline_Type_Code, Discipline_Pointsch) " +
                    "VALUES ('" + txtDIstudentID.Text + "', '" + txtStudentNum.Text + "', '" + txtStaffID.Text + "', '" + DateTime.Today.ToString("dd/MMM/yyyy") +
                    "', '"+ txtDescription.Text +"', '"+ typeCode +"', '" +txtPointschValue.Text +"')";  // Insert new Discipline record 



                conn = new SqlConnection(conStr);
                conn.Open();
                comm = new SqlCommand(sql, conn);
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("Discipline added successfully.");

                conn.Close();
            }

            if (sActionType == "AI")
            {
                sql = "INSERT INTO Infraction (Infraction_Student_ID, Student_NWU_ID, Staff_NWU_ID, Infraction_Date, Infraction_Description, Infraction_Type_Code, Infraction_Pointsch) " +
                   "VALUES ('" + txtDIstudentID.Text + "', '" + txtStudentNum.Text + "', '" + txtStaffID.Text + "', '" + DateTime.Today.ToString("dd/MMM/yyyy") +
                    "', '" + txtDescription.Text + "', '" + typeCode + "', '" + txtPointschValue.Text + "')";  // Insert new Discipline record 


                conn = new SqlConnection(conStr);
 
                conn.Open();
                comm = new SqlCommand(sql, conn);
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("Infraction added successfully.");

                conn.Close();
            }
        }

        private void btnGetStudent_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmPointschMachine_Load(object sender, EventArgs e)
        {
            string sNum = txtStudentNum.Text;
            if (sActionType == "AD")//populate drop down with Discipline
            {
                sql = "SELECT Discipline_Type FROM Discipline_Type";

                conn = new SqlConnection(conStr);
                comm = new SqlCommand(sql, conn);
                conn.Open();
                adap = new SqlDataAdapter(comm);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string ActionType = reader.GetValue(0).ToString();
                    cmbActionType.Items.Add(ActionType);
                }
            }
            else if (sActionType == "AI")//populate drop down with Infraction
            {
                sql = "SELECT Infraction_Type FROM Infraction_Type";

                conn = new SqlConnection(conStr);
                comm = new SqlCommand(sql, conn);
                conn.Open();
                adap = new SqlDataAdapter(comm);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string ActionType = reader.GetValue(0).ToString();
                    cmbActionType.Items.Add(ActionType);
                }
            }
            else
            {
                MessageBox.Show("No ActionType");
            }
        }

        private void cmbActionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sActionType == "AD")
            {
                sql = "SELECT Discipline_Type_Code FROM Discipline_Type WHERE Discipline_Type = '" + cmbActionType.SelectedItem.ToString() + "'";

                conn = new SqlConnection(conStr);
                conn.Open();
                comm = new SqlCommand(sql, conn);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    typeCode = reader.GetValue(0).ToString();
                }

                conn.Close();
            }
            else if(sActionType == "AI")
            {
                sql = "SELECT Infraction_Type_Code FROM Infraction_Type WHERE Infraction_Type = '" + cmbActionType.SelectedItem.ToString() + "'";

                conn = new SqlConnection(conStr);
                conn.Open();
                comm = new SqlCommand(sql, conn);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    typeCode = reader.GetValue(0).ToString();
                }

                conn.Close();
            }
            
        }
    }
}
