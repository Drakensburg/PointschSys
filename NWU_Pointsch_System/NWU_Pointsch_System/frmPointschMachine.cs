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
            DateTime currentDateTime = DateTime.Now;
            //MessageBox.Show(currentDateTime.ToString());
            if (sActionType == "AD")
            {
                sql = "INSERT INTO Discipline(Discipline_Date, Discipline_Discription, Discipline_Pointsch) VALUES (@Date, @Discription, @Pointsch) WHERE (Student_NWU_ID = @StudentNumber)";  // Isert new Discipline record ///////////////////////ek dink die sal werk maar maak net seker asb emile want dis oor versilende tables
                sql2 = "INSERT INTO Discipline_type(Discipline_type) VALUES (@Type) WHERE (Student_NWU_ID = @StudentNumber)";

                conn = new SqlConnection(conStr);
                comm.Parameters.AddWithValue("@StudentNumber", txtStudentNum.Text);
                comm.Parameters.AddWithValue("@Type", cmbActionType.SelectedItem.ToString());
                comm.Parameters.AddWithValue("@Date", currentDateTime.ToString());
                comm.Parameters.AddWithValue("@Discription", rtbDiscription.Text);
                comm.Parameters.AddWithValue("@Pointsch", txtPointschValue.Text);
                conn.Open();
                comm = new SqlCommand(sql, conn);
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();
                comm2 = new SqlCommand(sql2, conn);
                adap.InsertCommand = comm2;
                adap.InsertCommand.ExecuteNonQuery();

                conn.Close();
            }

            if (sActionType == "AI")
            {
                sql = "INSERT INTO Infraction(Infraction_Date, Infraction_Discription, Infraction_Pointsch) VALUES (@Date, @Discription, @Pointsch) WHERE (Student_NWU_ID = @StudentNumber)";  // Isert new Infraction record ///////////////////////ek dink die sal werk maar maak net seker asb emile want dis oor versilende tables
                sql2 = "INSERT INTO Infraction(Infraction_type) VALUES (@Type) WHERE (Student_NWU_ID = @StudentNumber)";

                conn = new SqlConnection(conStr);
                comm.Parameters.AddWithValue("@StudentNumber", txtStudentNum.Text);
                comm.Parameters.AddWithValue("@Type", cmbActionType.SelectedItem.ToString());
                comm.Parameters.AddWithValue("@Date", currentDateTime);
                comm.Parameters.AddWithValue("@Discription", rtbDiscription.Text);
                comm.Parameters.AddWithValue("@Pointsch", txtPointschValue.Text);
                conn.Open();
                comm = new SqlCommand(sql, conn);
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();
                comm2 = new SqlCommand(sql2, conn);
                adap.InsertCommand = comm2;
                adap.InsertCommand.ExecuteNonQuery();

                conn.Close();
            }
        }

        private void btnGetStudent_Click(object sender, EventArgs e)
        {
            sql = "SELECT Student_Name, Student_Surname FROM Student WHERE (Student_NWU_ID = @StudentNumber)"; // Find student name surname acording to student num filled in

            conn = new SqlConnection(conStr);
            comm = new SqlCommand(sql, conn);
            conn.Open();
            comm.Parameters.AddWithValue("@StudentNumber", txtStudentNum.Text);
            adap = new SqlDataAdapter(comm);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string sNameSurname = reader.GetValue(0) +" "+ reader.GetValue(1);
                lblStudentDetail.Text = sNameSurname + " WILL BE AFFECTED BY THIS REQUEST";
            }

            conn.Close();
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
            
      
            
        }
    }
}
