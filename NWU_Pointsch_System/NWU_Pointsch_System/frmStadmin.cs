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
    public partial class frmStadmin : Form
    {
        public frmStadmin()
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                frmStadmin fsa = (frmStadmin)Application.OpenForms["frmStadmin"];
                fsa.Close();
            }
            catch (NullReferenceException ne)
            {
                //FORM IS NOT OPEN
            }
        }

        private void btnEditDB_Click(object sender, EventArgs e)
        {
            frmDBEdit fDBE = new frmDBEdit();
            fDBE.ShowDialog();
        }

        private void btnAddDiscipline_Click(object sender, EventArgs e)
        {
            frmPointschMachine fPM = new frmPointschMachine();
            fPM.ShowDialog();
        }

        private void btnAddInfraction_Click(object sender, EventArgs e)
        {
            frmPointschMachine fPM = new frmPointschMachine();
            fPM.ShowDialog();
            fPM.sActionType = "AI";
        }

        private void btnRemoveDiscipline_Click(object sender, EventArgs e)
        {
            frmPointschMachine fPM = new frmPointschMachine();
            fPM.ShowDialog();
            fPM.sActionType = "RD";
        }

        private void btnRemoveInfraction_Click(object sender, EventArgs e)
        {
            frmPointschMachine fPM = new frmPointschMachine();
            fPM.ShowDialog();
            fPM.sActionType = "RI";
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport fRep = new frmReport();
            fRep.Show();
        }

        private void frmStadmin_Load(object sender, EventArgs e)
        {
            try 
            {
                string path;
                
                if (btnEditDB.Visible == true)
                {
                    path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\Assets\Person_Types\Admin.png";
                    picbSoSA.Image = Image.FromFile(@path);
                }
                else
                {
                    path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\Assets\Person_Types\Staff.png";
                    picbSoSA.Image = Image.FromFile(@path);
                }
            }
            catch(Exception Ne)
            {
                picbSoSA.Visible = false;
            }

            string sNum = lblSnoPhys.Text;
            sql = "SELECT SUM(dt.Discipline_Pointsch) As Points, s.Staff_ID, s.Staff_Name " +
                "FROM Staff s LEFT JOIN Discipline d on d.Staff_NWU_ID = s.Staff_ID LEFT JOIN Discipline_Type dt on dt.Discipline_Type_Code = d.Discipline_Type_Code " +
                "WHERE s.Staff_ID = @StaffNumber GROUP BY s.Staff_ID, s.Staff_Name"; //get the acumilated Discipline pointsch


            conn = new SqlConnection(conStr);
            comm = new SqlCommand(sql);
            comm.Parameters.AddWithValue("@StaffNumber", sNum);
            conn.Open();
            adap = new SqlDataAdapter(comm);
            ds = new DataSet();
            adap.Fill(ds);
            int SUM1 = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            conn.Close();

            lblDiscipline.Text = SUM1.ToString(); //Discipline total


            sql = "SELECT SUM(dt.Infraction_Pointsch) As Points, s.Staff_ID, s.Staff_Name " +
                "FROM Staff s LEFT JOIN Infraction d on d.Staff_NWU_ID = s.Staff_ID LEFT JOIN Infraction_Type dt on dt.Infraction_Type_Code = d.Infraction_Type_Code " +
                "WHERE s.Staff_ID = @StaffNumber GROUP BY s.Staff_ID, s.Staff_Name"; ////get the acumilated Infraction pointsch


            conn = new SqlConnection(conStr);
            comm = new SqlCommand(sql);
            comm.Parameters.AddWithValue("@StaffNumber", sNum);
            conn.Open();
            adap = new SqlDataAdapter(comm);
            ds = new DataSet();
            adap.Fill(ds);
            int SUM2 = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            conn.Close();

            lblInfraction.Text = SUM2.ToString();//Infraction total

            if (SUM1 > SUM2)//Total pointsch
            {
                lblTotal.Text = (SUM1 - SUM2).ToString();
                lblTotal.ForeColor = Color.Purple;
            }
            else
            {
                lblTotal.Text = (SUM2 - SUM1).ToString();
                lblTotal.ForeColor = Color.DarkRed;
            }

            sql = "SELECT Infraction_Date, Infraction_Discription, Infraction_Pointsch FROM Infraction WHERE (Staff_NWU_ID = @StaffNumber)"; //make a list of Infractions

            conn = new SqlConnection(conStr);
            comm = new SqlCommand(sql);
            comm.Parameters.AddWithValue("@StaffNumber", sNum);
            conn.Open();
            adap = new SqlDataAdapter(comm);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string output = reader.GetValue(0) + "\n" + reader.GetValue(1) + "\n" + reader.GetValue(2) + "\n\n";
                lblInfraction.Text = (output);
            }

            conn.Close();


            sql = "SELECT Discipline_Date, Discipline_Discription, Discipline_Pointsch FROM Discipline WHERE (Staff_NWU_ID = @StaffNumber)"; //make a list of Discipline's

            conn = new SqlConnection(conStr);
            comm = new SqlCommand(sql);
            comm.Parameters.AddWithValue("@StaffNumber", sNum);
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
    }
}
