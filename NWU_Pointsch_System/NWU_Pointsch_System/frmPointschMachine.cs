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
    public partial class frmPointschMachine : Form
    {
        public string sActionType = "";

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
            if (cbDeclare.Checked)
            {
                //===Complete Action
            }
            else 
            { 
                //===Warm that they have not confirmed            
            }
        }
    }
}
