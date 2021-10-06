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
    public partial class frmLogin : Form
    {
        public string StudentNumber, StadminNumber = "";
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbPointsch.mdf;Integrated Security=True";
        SqlConnection conn;   //all my public statements
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader reader;
        string sql = "";

        //hello die is n toets

        //====DELETE
        private bool bDev = true;
        //====DELETE

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //====DELETE
            if (bDev == true)
            {
                btnStaff.Visible = true;
                btnStud.Visible = true;
            }
            //====DELETE
        }

        private void checkDetails()
        {
            //====Toets x
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tempStudentNum = txtUser.Text;
            string tempStadminNum = txtUser.Text;

            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                sql = "SELECT Student_NWU_ID FROM Student WHERE Student_NWU_ID = @num";
            }
            catch(Exception)
            {
                MessageBox.Show("Database Unavailable");
            }

            comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@num", tempStudentNum);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string temp = reader.GetString(0);
                if (tempStudentNum == temp)   //Testing whether the user entered matches any data in the database
                {
                    StudentNumber = txtUser.Text;
                    frmProfile fProfile = new frmProfile();
                    fProfile.ShowDialog();
                    break;
                }
            }
            conn.Close();

            conn = new SqlConnection(conStr);
            conn.Open();
            sql = "SELECT Staff_NWU_ID FROM Staff WHERE Staff_NWU_ID = @num";

            comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@num", tempStadminNum);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string temp = reader.GetString(0);
                if (tempStudentNum == temp)   //Testing whether the user entered matches any data in the database
                {
                    StadminNumber = txtUser.Text;
                    frmStadmin fStadmin = new frmStadmin();
                    fStadmin.ShowDialog();
                    break;
                }
                else
                {
                    MessageBox.Show("Invalid Student/Staff number");
                }
            }
        }

        //====DELETE
        private void btnStud_Click(object sender, EventArgs e)
        {
            frmProfile fProfile = new frmProfile();
            fProfile.ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            frmStadmin fStadmin = new frmStadmin();
            fStadmin.ShowDialog();
        }
        //====DELETE
    }
}
