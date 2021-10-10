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
  
            string sNum = lblSnoPhys.Text;
            sql = "SELECT SUM(Discipline_Pointsch) AS POINTS FROM Discipline WHERE Student_NWU_ID = @StudentNumber"; //get the accumulate Discipline pointsch

            conn = new SqlConnection(conStr);
            conn.Open();
            comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@StudentNumber", sNum);
            adap = new SqlDataAdapter(comm);
            ds = new DataSet();
            adap.Fill(ds);
            int SUM1 = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            conn.Close();

            lblPos.Text = SUM1.ToString(); //Discipline total


            sql = "SELECT SUM(Infraction_Pointsch) AS POINTS FROM Infraction WHERE Student_NWU_ID = @StudentNumber"; //get the accumulate Infraction pointsch


            conn = new SqlConnection(conStr);
            conn.Open();
            comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@StudentNumber", sNum);
            adap = new SqlDataAdapter(comm);
            ds = new DataSet();
            adap.Fill(ds);
            int SUM2 = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            conn.Close();

            lblNeg.Text = SUM2.ToString();//Infraction total
            string path;

            if (SUM1 > SUM2)//Total pointsch
            {
                lblSum.Text = (SUM1 - SUM2).ToString();
                lblSum.ForeColor = Color.Purple;
                if((SUM1 - SUM2) > 20)
                {
                    try 
                    { 
                    path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\Assets\Karmas\Good.png";
                    picbStatus.Image = Image.FromFile(@path);
                    }
                    catch (Exception Ne)
                    {
                        picbStatus.Visible = false;
                        picbSoSA.Visible = false;
                    }
                }
                else
                {
                    try
                    { 
                    path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\Assets\Karmas\Neutral.png";
                    picbStatus.Image = Image.FromFile(@path);
                    }
                    catch (Exception Ne)
                    {
                        picbStatus.Visible = false;
                        picbSoSA.Visible = false;
                    }
                }
            }
            else
            {
                lblSum.Text = (SUM2 - SUM1).ToString();
                lblSum.ForeColor = Color.DarkRed;
                if ((SUM2 - SUM1) > 20)
                {
                    try 
                    { 
                    path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\Assets\Karmas\Bad.png";
                    picbStatus.Image = Image.FromFile(@path);
                    }
                    catch (Exception Ne)
                    {
                        picbStatus.Visible = false;
                        picbSoSA.Visible = false;
                    }
                }
                else
                {
                    try 
                    { 
                    path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\Assets\Karmas\Neutral.png";
                    picbStatus.Image = Image.FromFile(@path);
                    }
                    catch (Exception Ne)
                    {
                        picbStatus.Visible = false;
                        picbSoSA.Visible = false;
                    }
                }
            }

            sql = "SELECT Infraction_Date, Infraction_Description, Infraction_Pointsch FROM Infraction WHERE (Student_NWU_ID = @StudentNumber)"; //make a lis of Infractions
            
            conn = new SqlConnection(conStr);
            conn.Open();
            comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@StudentNumber", sNum);
            adap = new SqlDataAdapter(comm);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string output = "Date: " + reader.GetValue(0);
                lbInfraction.Items.Add(output);
                output = "Description: " + reader.GetValue(1);
                lbInfraction.Items.Add(output);
                output = "Pointsch: " + reader.GetValue(2);
                lbInfraction.Items.Add(output);
                lbInfraction.Items.Add("\n");
            }

            conn.Close();

            
            sql = "SELECT Discipline_Date, Discipline_Description, Discipline_Pointsch FROM Discipline WHERE (Student_NWU_ID = @StudentNumber)"; //make a list of Discipline's

            conn = new SqlConnection(conStr);
            conn.Open();
            comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@StudentNumber", sNum);
            adap = new SqlDataAdapter(comm);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string output = "Date: " + reader.GetValue(0);
                lbDiscipline.Items.Add(output);
                output ="Description: " + reader.GetValue(1);
                lbDiscipline.Items.Add(output);
                output = "Pointsch: " + reader.GetValue(2);
                lbDiscipline.Items.Add(output);
                lbDiscipline.Items.Add("\n");
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