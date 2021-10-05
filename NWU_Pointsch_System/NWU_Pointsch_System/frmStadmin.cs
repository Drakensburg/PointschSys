using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NWU_Pointsch_System
{
    public partial class frmStadmin : Form
    {
        public bool bIsAdmin = true;

        public frmStadmin()
        {
            InitializeComponent();
        }

        private void frmStadmin_Load(object sender, EventArgs e)
        {
            if (bIsAdmin)
            {
                btnEditDB.Visible = true;
            }
            else
            {
                btnEditDB.Visible = false;
            }
        }

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
            fPM.sActionType = "AD";
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
    }
}
