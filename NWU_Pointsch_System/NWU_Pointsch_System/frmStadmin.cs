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

        }
    }
}
