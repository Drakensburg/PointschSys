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
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbPointsch.mdf;Integrated Security=True";
        SqlConnection conn;   //all my public statements
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader reader;
        string sql = "";

        private void frmProfile_Load(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();

            string sNum = loginForm.StudentNumber;
            sql = "SELECT SUM(dt.Discipline_Pointsch) As Points, s.Student_ID, s.Student_Name " +
                "FROM Student s LEFT JOIN Discipline d on d.Student_NWU_ID = s.Student_ID LEFT JOIN Discipline_Type dt on dt.Discipline_Type_Code = d.Discipline_Type_Code " +
                "WHERE s.Student_ID = @StudentNumber GROUP BY s.Student_ID, s.Student_Name"; //display all


            conn = new SqlConnection(conStr);
            comm = new SqlCommand(sql);
            comm.Parameters.AddWithValue("@StudentNumber", sNum);
            conn.Open();
            adap = new SqlDataAdapter(comm);
            ds = new DataSet();
            adap.Fill(ds);
            int SUM1 = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            conn.Close();

            lblDiscipline.Text = SUM1.ToString(); //Discipline total


            sql = "SELECT SUM(dt.Infraction_Pointsch) As Points, s.Student_ID, s.Student_Name " +
                "FROM Student s LEFT JOIN Infraction d on d.Student_NWU_ID = s.Student_ID LEFT JOIN Infraction_Type dt on dt.Infraction_Type_Code = d.Infraction_Type_Code " +
                "WHERE s.Student_ID = @StudentNumber GROUP BY s.Student_ID, s.Student_Name"; //display all


            conn = new SqlConnection(conStr);
            comm = new SqlCommand(sql);
            comm.Parameters.AddWithValue("@StudentNumber", sNum);
            conn.Open();
            adap = new SqlDataAdapter(comm);
            ds = new DataSet();
            adap.Fill(ds);
            int SUM2 = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            conn.Close();

            lblInfraction.Text = SUM2.ToString();//Infraction total

            if (SUM1 > SUM2)//Total
            {
                lblTotal.Text = (SUM1 - SUM2).ToString();
                lblTotal.ForeColor = Color.Purple;
                if((SUM1 - SUM2) > 20)
                {
                    picbStatus.Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Good.png");
                }
                else
                {
                    picbStatus.Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Neutral.png");
                }
            }
            else
            {
                lblTotal.Text = (SUM2 - SUM1).ToString();
                lblTotal.ForeColor = Color.DarkRed;
                if ((SUM2 - SUM1) > 20)
                {
                    picbStatus.Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Bad.png");
                }
                else
                {
                    picbStatus.Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Neutral.png");
                }
            }


            sql = "SELECT Infraction_Date, Infraction_Discription, Infraction_Pointsch FROM Infraction WHERE (Student_NWU_ID = @StudentNumber)"; //display all
            
            conn = new SqlConnection(conStr);
            comm = new SqlCommand(sql);
            comm.Parameters.AddWithValue("@StudentNumber", sNum);
            conn.Open();
            adap = new SqlDataAdapter(comm);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string output = reader.GetValue(0) + "\n" + reader.GetValue(1) + "\n" + reader.GetValue(2)+ "\n\n";
                lblInfraction.Text = (output);
            }

            conn.Close();

            
            sql = "SELECT Discipline_Date, Discipline_Discription, Discipline_Pointsch FROM Discipline WHERE (Student_NWU_ID = @StudentNumber)"; //display all

            conn = new SqlConnection(conStr);
            comm = new SqlCommand(sql);
            comm.Parameters.AddWithValue("@StudentNumber", sNum);
            conn.Open();
            adap = new SqlDataAdapter(comm);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string output = reader.GetValue(0) + "\n" + reader.GetValue(1) + "\n" + reader.GetValue(2) + "\n\n";
                lblInfraction.Text = (output);
            }

            conn.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                frmProfile fsa = (frmProfile)Application.OpenForms["frmProfile"];
                fsa.Close();
            }
            catch (NullReferenceException ne)
            {
                //FORM IS NOT OPEN
            }
        }
    }
}