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

        private void lblWorth_Click(object sender, EventArgs e)
        {

        }

        private void btnPIAdd_Click(object sender, EventArgs e)
        {
            string cbDI = cbPosition.SelectedItem.ToString();


            if (cbDI.Equals("D"))//adding new Discipline type
            {
  
                sql = "INSERT INTO Discipline_Type(Discipline_Type, Discipline_Pointsch_Min, Discipline_Pointsch_Min) VALUES (@type, @min, @max)";

                conn = new SqlConnection(conStr);
                comm.Parameters.AddWithValue("@type", txtTypeName.Text);
                comm.Parameters.AddWithValue("@min", Int32.Parse(txtMin.Text));
                comm.Parameters.AddWithValue("@max", Int32.Parse(txtMax.Text));
                conn.Open();
                comm = new SqlCommand(sql, conn);
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();

                conn.Close();

            }
            else if (cbDI.Equals("I"))//adding new Infraction type
            {
          
                sql = "INSERT INTO Infraction_Type(Infraction_Type, Infraction_Pointsch_Min, Infraction_Pointsch_Min) VALUES (@type, @min, @max)";

                conn = new SqlConnection(conStr);
                comm.Parameters.AddWithValue("@type", txtTypeName.Text);
                comm.Parameters.AddWithValue("@min", Int32.Parse(txtMin.Text));
                comm.Parameters.AddWithValue("@max", Int32.Parse(txtMax.Text));
                conn.Open();
                comm = new SqlCommand(sql, conn);
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();

                conn.Close();
               
            }
            else
            {
                MessageBox.Show("Could not add D/I");
            }
        }

        private void btnPIRemove_Click(object sender, EventArgs e)
        {
            if (cbDI.Equals("D"))//remove Discipline type
            {
                sql = "DELETE FROM Discipline_Type WHERE Discipline_Type = @type";

                conn = new SqlConnection(conStr);
                comm.Parameters.AddWithValue("@type", txtTypeName.Text);
                conn.Open();
                comm = new SqlCommand(sql, conn);
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();

                conn.Close();

            }
            else if (cbDI.Equals("I"))//remove Infraction type
            {

                sql = "DELETE FROM Infraction_Type WHERE Infraction_Type = @type";

                conn = new SqlConnection(conStr);
                comm.Parameters.AddWithValue("@type", txtTypeName.Text);
                conn.Open();
                comm = new SqlCommand(sql, conn);
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();

                conn.Close();

            }
            else
            {
                MessageBox.Show("Could not delete D/I");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cbResult = cbPosition.SelectedItem.ToString();


                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    if (cbResult.Equals("Student"))//remove student
                    {

                        {
                            SqlCommand cmd = new SqlCommand(
                                                          "       DELETE FROM Student WHERE " +
                                                          "       Student_NWU_ID = @Student_NWU_ID AND Student_ID = @Student_ID AND Student_Name = @Student_Name AND" +
                                                          "       Student_Surname = @Student_Surname AND Campus_Name = @Campus_Name");

                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = connection;
                            cmd.Parameters.AddWithValue("@Student_NWU_ID", txtSNO.Text);
                            cmd.Parameters.AddWithValue("@Student_ID", txtID.Text);
                            cmd.Parameters.AddWithValue("@Student_Name", txtName.Text);
                            cmd.Parameters.AddWithValue("@Student_Surname", txtSurname.Text);
                            cmd.Parameters.AddWithValue("@Campus_Name", cbCampus.SelectedItem.ToString());

                            connection.Open();
                        }

                    }
                    else if (cbResult.Equals("Staff"))//remove staff
                    {

                        SqlCommand cmd = new SqlCommand(
                                                          "       DELETE FROM Staff WHERE " +
                                                          "       Staff_NWU_ID = @Staff_NWU_ID AND Staff_ID = @Staff_ID AND Staff_Name = @Staff_Name AND" +
                                                          "       Staff_Surname = @Staff_Surname AND Staff_Admin = @Staff_Admin AND Campus_Name = @Campus_Name");
                        cmd.Connection = connection;
                        cmd.Parameters.AddWithValue("@Staff_NWU_ID", txtSNO.Text);
                        cmd.Parameters.AddWithValue("@Staff_ID", txtID.Text);
                        cmd.Parameters.AddWithValue("@Staff_Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Staff_Surname", txtSurname.Text);
                        cmd.Parameters.AddWithValue("@Staff_Admin", false);
                        cmd.Parameters.AddWithValue("@Campus_Name", cbCampus.SelectedItem.ToString());

                        connection.Open();
                    }
                    else if (cbResult.Equals("Admin"))//remove admin
                    {
                        SqlCommand cmd = new SqlCommand(
                                                          "       DELETE FROM Staff WHERE " +
                                                          "       Staff_NWU_ID = @Staff_NWU_ID AND Staff_ID = @Staff_ID AND Staff_Name = @Staff_Name AND" +
                                                          "       Staff_Surname = @Staff_Surname AND Staff_Admin = @Staff_Admin AND Campus_Name = @Campus_Name");
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connection;
                        cmd.Parameters.AddWithValue("@Staff_NWU_ID", txtSNO.Text);
                        cmd.Parameters.AddWithValue("@Staff_ID", txtID.Text);
                        cmd.Parameters.AddWithValue("@Staff_Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Staff_Surname", txtSurname.Text);
                        cmd.Parameters.AddWithValue("@Staff_Admin", true);
                        cmd.Parameters.AddWithValue("@Campus_Name", cbCampus.SelectedItem.ToString());

                        connection.Open();
                    }

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }

            System.Windows.Forms.MessageBox.Show("Successfully added user!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cbResult = cbPosition.SelectedItem.ToString();


                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    if (cbResult.Equals("Student"))//add new student
                    {

                        {
                            SqlCommand cmd = new SqlCommand(
                                                          "       INSERT INTO Student(Student_NWU_ID, Student_ID, Student_Name, Student_Surname, Campus_Name)" +
                                                          "       VALUES(@Student_NWU_ID, @Student_ID, @Student_Name, @Student_Surname, @Campus_Name)");
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = connection;
                            cmd.Parameters.AddWithValue("@Student_NWU_ID", txtSNO.Text);
                            cmd.Parameters.AddWithValue("@Student_ID", txtID.Text);
                            cmd.Parameters.AddWithValue("@Student_Name", txtName.Text);
                            cmd.Parameters.AddWithValue("@Student_Surname", txtSurname.Text);
                            cmd.Parameters.AddWithValue("@Campus_Name", cbCampus.SelectedItem.ToString());

                            connection.Open();
                        }

                    }
                    else if (cbResult.Equals("Staff"))//add new staff
                    {

                        SqlCommand cmd = new SqlCommand(
                                                          "       INSERT INTO Staff(Staff_NWU_ID, Staff_ID, Staff_Name, Staff_Surname, Staff_Admin Campus_Name)" +
                                                          "       VALUES(@Staff_NWU_ID, @Staff_ID, @Staff_Name, @Staff_Surname, @Staff_Admin @Campus_Name)");
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connection;
                        cmd.Parameters.AddWithValue("@Staff_NWU_ID", txtSNO.Text);
                        cmd.Parameters.AddWithValue("@Staff_ID", txtID.Text);
                        cmd.Parameters.AddWithValue("@Staff_Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Staff_Surname", txtSurname.Text);
                        cmd.Parameters.AddWithValue("@Staff_Admin", false);
                        cmd.Parameters.AddWithValue("@Campus_Name", cbCampus.SelectedItem.ToString());

                        connection.Open();
                    }
                    else if (cbResult.Equals("Admin"))//add new admin
                    {
                        SqlCommand cmd = new SqlCommand(
                                                          "       INSERT INTO Staff(Staff_NWU_ID, Staff_ID, Staff_Name, Staff_Surname, Staff_Admin Campus_Name)" +
                                                          "       VALUES(@Staff_NWU_ID, @Staff_ID, @Staff_Name, @Staff_Surname, @Staff_Admin @Campus_Name)");
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connection;
                        cmd.Parameters.AddWithValue("@Staff_NWU_ID", txtSNO.Text); 
                        cmd.Parameters.AddWithValue("@Staff_ID", txtID.Text);
                        cmd.Parameters.AddWithValue("@Staff_Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Staff_Surname", txtSurname.Text);
                        cmd.Parameters.AddWithValue("@Staff_Admin", true);
                        cmd.Parameters.AddWithValue("@Campus_Name", cbCampus.SelectedItem.ToString());

                        connection.Open();
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
