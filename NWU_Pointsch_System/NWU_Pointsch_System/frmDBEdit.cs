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
    public partial class frmDBEdit : Form
    {

        public string StudentNumber, StadminNumber = "";
        string conStr = @"";
        SqlConnection conn;   //all my public statements
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader reader;
        string sql = "";

        public frmDBEdit()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                frmDBEdit fsa = (frmDBEdit)Application.OpenForms["frmDBEdit"];
                fsa.Close();
            }
            catch (NullReferenceException ne)
            {
                //FORM IS NOT OPEN
            }
        }

        private void frmDBEdit_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Threading.Thread.Sleep(10);

                //Add Entity if NOT exist
                //--------------------------------------------------
                string ID = txtID.Text;
                string Name = txtName.Text;
                string Surname = txtSurname.Text;
                string SNO = txtSNO.Text;
                string cbResult = cbPosition.SelectedIndex.ToString();


                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    if (!cbResult.Equals("STUDENT"))
                    {

                        {
                            SqlCommand cmd = new SqlCommand(
                                                          "       INSERT INTO STUDENT(Student_NWU_ID, Student_ID, Student_Name, Student_Surname, Campus_Name)" +
                                                          "       VALUES(@Student_NWU_ID, @Student_ID, @Student_Name, @Student_Surname, @Campus_Name)");
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = connection;
                            cmd.Parameters.AddWithValue("@Student_NWU_ID", ""); //NEED to pass the StudentNum to this form
                            cmd.Parameters.AddWithValue("@Student_ID", txtID.Text);
                            cmd.Parameters.AddWithValue("@Student_Name", txtName.Text);
                            cmd.Parameters.AddWithValue("@Student_Surname", txtSurname.Text);
                            cmd.Parameters.AddWithValue("@Campus_Name", cbCampus.SelectedItem.ToString());

                            connection.Open();
                        }

                    }
                    else if (!cbResult.Equals("Staff"))
                    {
                        if (cbAdmin.Checked)
                        {
                            SqlCommand cmd = new SqlCommand(
                                                              "       INSERT INTO STUDENT(Staff_NWU_ID, Staff_ID, Staff_Name, Staff_Surname, Staff_Admin Campus_Name)" +
                                                              "       VALUES(@Staff_NWU_ID, @Staff_ID, @Staff_Name, @Staff_Surname, @Staff_Admin @Campus_Name)");
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = connection;
                            cmd.Parameters.AddWithValue("@Staff_NWU_ID", ""); //NEED to pass the StudentNum to this form
                            cmd.Parameters.AddWithValue("@Staff_ID", txtID.Text);
                            cmd.Parameters.AddWithValue("@Staff_Name", txtName.Text);
                            cmd.Parameters.AddWithValue("@Staff_Surname", txtSurname.Text);
                            cmd.Parameters.AddWithValue("@Staff_Admin", true);
                            cmd.Parameters.AddWithValue("@Campus_Name", cbCampus.SelectedItem.ToString());

                            connection.Open();
                        }
                        else if (!cbAdmin.Checked)
                        {
                            SqlCommand cmd = new SqlCommand(
                                                              "       INSERT INTO STUDENT(Staff_NWU_ID, Staff_ID, Staff_Name, Staff_Surname, Staff_Admin Campus_Name)" +
                                                              "       VALUES(@Staff_NWU_ID, @Staff_ID, @Staff_Name, @Staff_Surname, @Staff_Admin @Campus_Name)");
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = connection;
                            cmd.Parameters.AddWithValue("@Staff_NWU_ID", ""); //NEED to pass the StudentNum to this form
                            cmd.Parameters.AddWithValue("@Staff_ID", txtID.Text);
                            cmd.Parameters.AddWithValue("@Staff_Name", txtName.Text);
                            cmd.Parameters.AddWithValue("@Staff_Surname", txtSurname.Text);
                            cmd.Parameters.AddWithValue("@Staff_Admin", false);
                            cmd.Parameters.AddWithValue("@Campus_Name", cbCampus.SelectedItem.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }

            System.Windows.Forms.MessageBox.Show("Successfully added user!");
        }
    }
}
