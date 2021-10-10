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
        DataSet ds;
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
            if (sActionType == "AD")
            {
                sql = "INSERT INTO Discipline(Discipline_Date, Discipline_Discription, Discipline_Pointsch) VALUES (@Date, @Discription, @Pointsch) WHERE (Student_NWU_ID = @StudentNumber)";  // Isert new Discipline record ///////////////////////ek dink die sal werk maar maak net seker asb emile want dis oor versilende tables
                sql2 = "INSERT INTO Discipline_type(Discipline_type) VALUES (@Type) WHERE (Student_NWU_ID = @StudentNumber)";

                conn = new SqlConnection(conStr);
                comm.Parameters.AddWithValue("@StudentNumber", txtStudentNum.Text);
                comm.Parameters.AddWithValue("@Type", cmbActionType.SelectedItem);
                comm.Parameters.AddWithValue("@Date", DateTime.Now);
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
                comm.Parameters.AddWithValue("@Type", cmbActionType.SelectedItem);
                comm.Parameters.AddWithValue("@Date", DateTime.Now);
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
            comm = new SqlCommand(sql);
            comm.Parameters.AddWithValue("@StudentNumber", txtStudentNum.Text);
            conn.Open();
            adap = new SqlDataAdapter(comm);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string sNameSurname = reader.GetValue(2) +" "+ reader.GetValue(3);
                lblStudentDetail.Text = sNameSurname + " WILL BE AFFECTED BY THIS REQUEST";
            }

            conn.Close();
        }

        private void frmPointschMachine_Load(object sender, EventArgs e)
        {
            string sNum = txtStudentNum.Text;
            if (sActionType == "AD")//populate drop down with Discipline
            {
                sql = "SELECT Discipline_Type FROM Discipline_Type";

                conn = new SqlConnection(conStr);
                comm = new SqlCommand(sql);
                conn.Open();
                adap = new SqlDataAdapter(comm);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string ActionType = reader.GetValue(1).ToString();
                    cmbActionType.Items.Add(ActionType);
                }
            }


            if (sActionType == "AI")//populate drop down with Infraction
            {
                sql = "SELECT Infraction_Type FROM Infraction_Type";

                conn = new SqlConnection(conStr);
                comm = new SqlCommand(sql);
                conn.Open();
                adap = new SqlDataAdapter(comm);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string ActionType = reader.GetValue(1).ToString();
                    cmbActionType.Items.Add(ActionType);
                }
            }

            if (sActionType == "RD")//populate drop down with Discipline of student
            {
                sql = "SELECT Discipline_Discription, Discipline_Date FROM Discipline WHERE (Student_NWU_ID = @StudentNumber)";

                conn = new SqlConnection(conStr);
                comm = new SqlCommand(sql);
                comm.Parameters.AddWithValue("@StudentNumber", sNum);
                conn.Open();
                adap = new SqlDataAdapter(comm);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string ActionType = reader.GetValue(4).ToString();
                    cmbActionType.Items.Add(ActionType);
                }
            }

            if (sActionType == "RI")//populate drop down with Infractions of student
            {
                sql = "SELECT Infraction_Discription, Infraction_Date FROM Infraction WHERE (Student_NWU_ID = @StudentNumber)";

                conn = new SqlConnection(conStr);
                comm = new SqlCommand(sql);
                comm.Parameters.AddWithValue("@StudentNumber", sNum);
                conn.Open();
                adap = new SqlDataAdapter(comm);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string ActionType = reader.GetValue(4).ToString();
                    cmbActionType.Items.Add(ActionType);
                }
            }
        }

        private void cmbActionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sActionType == "RI")//populate rtb with Infraction  date of selected discription
            {
                sql = "SELECT Infraction_Discription, Infraction_Date FROM Infraction WHERE (Infraction_Discription = @discription)";

                conn = new SqlConnection(conStr);
                comm = new SqlCommand(sql);
                comm.Parameters.AddWithValue("@discription", cmbActionType.SelectedItem);
                conn.Open();
                adap = new SqlDataAdapter(comm);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string ActionType = reader.GetValue(3).ToString() + "\n" + reader.GetValue(4).ToString();
                    rtbDiscription.Text = ActionType;
                }
            }

            if (sActionType == "RI")//populate rtb with Discipline date of selected discription
            {
                sql = "SELECT Discipline_Discription, Discipline_Date FROM Discipline WHERE (Discipline_Discription = @discription)";

                conn = new SqlConnection(conStr);
                comm = new SqlCommand(sql);
                comm.Parameters.AddWithValue("@discription", cmbActionType.SelectedItem);
                conn.Open();
                adap = new SqlDataAdapter(comm);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string ActionType = reader.GetValue(3).ToString() + "\n" + reader.GetValue(4).ToString();
                    rtbDiscription.Text = ActionType;
                }
            }
        }
    }
}
