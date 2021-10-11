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
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbPointsch.mdf;Integrated Security=True";
        SqlConnection conn;   //all my public statements
        SqlCommand comm;
        SqlDataAdapter adap;
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
                MessageBox.Show(ne.ToString());
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
            string sDI = cbDI.SelectedItem.ToString();


            if (sDI.Equals("DISCIPLINE"))//adding new Discipline type
            {



                sql = "INSERT INTO Discipline_Type(Discipline_Type, Discipline_Pointsch_Min, Discipline_Pointsch_Min) VALUES (@type, @min, @max)";

                conn = new SqlConnection(conStr);
                conn.Open();
                comm = new SqlCommand(sql, conn);
                adap = new SqlDataAdapter();
                comm.Parameters.AddWithValue("@type", txtTypeName.Text);
                comm.Parameters.AddWithValue("@min", Int32.Parse(txtMin.Text));
                comm.Parameters.AddWithValue("@max", Int32.Parse(txtMax.Text));
                
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();

                conn.Close();

            }
            else if (sDI.Equals("INFRACTION"))//adding new Infraction type
            {
          
                sql = "INSERT INTO Infraction_Type(Infraction_Type, Infraction_Pointsch_Min, Infraction_Pointsch_Max) VALUES (@type, @min, @max)";

                conn = new SqlConnection(conStr);
                conn.Open();
                comm = new SqlCommand(sql, conn);
                adap = new SqlDataAdapter();
                comm.Parameters.AddWithValue("@type", txtTypeName.Text);
                comm.Parameters.AddWithValue("@min", Int32.Parse(txtMin.Text));
                comm.Parameters.AddWithValue("@max", Int32.Parse(txtMax.Text));
                
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
                conn.Open();
                comm = new SqlCommand(sql, conn);
                adap = new SqlDataAdapter();
                comm.Parameters.AddWithValue("@type", txtTypeName.Text);
                
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();

                conn.Close();

            }
            else if (cbDI.Equals("I"))//remove Infraction type
            {

                sql = "DELETE FROM Infraction_Type WHERE Infraction_Type = @type";

                conn = new SqlConnection(conStr);
                conn.Open();
                comm = new SqlCommand(sql, conn);
                adap = new SqlDataAdapter();
                comm.Parameters.AddWithValue("@type", txtTypeName.Text);
               
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

                {
                    if (cbResult.Equals("Student"))//remove student
                    {

                        {
                            sql =                         "       DELETE FROM Student WHERE " +
                                                          "       Student_NWU_ID = @Student_NWU_ID AND Student_ID = @Student_ID AND Student_Name = @Student_Name AND" +
                                                          "       Student_Surname = @Student_Surname AND Campus_Name = @Campus_Name";

                            conn = new SqlConnection(conStr);
                            conn.Open();
                            comm = new SqlCommand(sql, conn);
                            adap = new SqlDataAdapter();
                            comm.Parameters.AddWithValue("@Student_NWU_ID", txtSNO.Text);
                            comm.Parameters.AddWithValue("@Student_ID", txtID.Text);
                            comm.Parameters.AddWithValue("@Student_Name", txtName.Text);
                            comm.Parameters.AddWithValue("@Student_Surname", txtSurname.Text);
                            comm.Parameters.AddWithValue("@Campus_Name", cbCampus.SelectedItem.ToString());
                            
                            adap.InsertCommand = comm;
                            adap.InsertCommand.ExecuteNonQuery();

                            conn.Close();

                        }

                    }
                    else if (cbResult.Equals("Staff"))//remove staff
                    {

                        sql =                             "       DELETE FROM Staff WHERE " +
                                                          "       Staff_NWU_ID = @Staff_NWU_ID AND Staff_ID = @Staff_ID AND Staff_Name = @Staff_Name AND" +
                                                          "       Staff_Surname = @Staff_Surname AND Staff_Admin = @Staff_Admin AND Campus_Name = @Campus_Name";
                        conn = new SqlConnection(conStr);
                        conn.Open();
                        comm = new SqlCommand(sql, conn);
                        adap = new SqlDataAdapter();
                        comm.Parameters.AddWithValue("@Staff_NWU_ID", txtSNO.Text);
                        comm.Parameters.AddWithValue("@Staff_ID", txtID.Text);
                        comm.Parameters.AddWithValue("@Staff_Name", txtName.Text);
                        comm.Parameters.AddWithValue("@Staff_Surname", txtSurname.Text);
                        comm.Parameters.AddWithValue("@Staff_Admin", false);
                        comm.Parameters.AddWithValue("@Campus_Name", cbCampus.SelectedItem.ToString());
                        
                        adap.InsertCommand = comm;
                        adap.InsertCommand.ExecuteNonQuery();

                        conn.Close();

                    }
                    else if (cbResult.Equals("Admin"))//remove admin
                    {
                        sql =                             "       DELETE FROM Staff WHERE " +
                                                          "       Staff_NWU_ID = @Staff_NWU_ID AND Staff_ID = @Staff_ID AND Staff_Name = @Staff_Name AND" +
                                                          "       Staff_Surname = @Staff_Surname AND Staff_Admin = @Staff_Admin AND Campus_Name = @Campus_Name";
                        conn = new SqlConnection(conStr);
                        conn.Open();
                        comm = new SqlCommand(sql, conn);
                        adap = new SqlDataAdapter();
                        comm.Parameters.AddWithValue("@Staff_NWU_ID", txtSNO.Text);
                        comm.Parameters.AddWithValue("@Staff_ID", txtID.Text);
                        comm.Parameters.AddWithValue("@Staff_Name", txtName.Text);
                        comm.Parameters.AddWithValue("@Staff_Surname", txtSurname.Text);
                        comm.Parameters.AddWithValue("@Staff_Admin", true);
                        comm.Parameters.AddWithValue("@Campus_Name", cbCampus.SelectedItem.ToString());

                        adap.InsertCommand = comm;
                        adap.InsertCommand.ExecuteNonQuery();

                        conn.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }

            System.Windows.Forms.MessageBox.Show("Successfully deleted user!");
        }

        private void btnGridStudents_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr); // connecting to the databse
            conn.Open();

            adap = new SqlDataAdapter();
            DataSet ds = new DataSet();

            sql = "SELECT * FROM Student"; //display all

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "Student");

            conn.Close();
            conn.Open();

            dgvPointsch.DataSource = ds;
            dgvPointsch.DataMember = "Student";

            conn.Close();
        }

        private void btnGridStaff_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr); // connecting to the databse
            conn.Open();

            adap = new SqlDataAdapter();
            DataSet ds = new DataSet();

            sql = "SELECT * FROM Staff"; //display all

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "Staff");

            conn.Close();
            conn.Open();

            dgvPointsch.DataSource = ds;
            dgvPointsch.DataMember = "Staff";

            conn.Close();
        }

        private void btnGridDis_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr); // connecting to the databse
            conn.Open();

            adap = new SqlDataAdapter();
            DataSet ds = new DataSet();

            sql = "SELECT * FROM Discipline_type"; //display all

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "Discipline_type");

            conn.Close();
            conn.Open();

            dgvPointsch.DataSource = ds;
            dgvPointsch.DataMember = "Discipline_type";

            conn.Close();
        }

        private void btnGridInf_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr); // connecting to the databse
            conn.Open();

            adap = new SqlDataAdapter();
            DataSet ds = new DataSet();

            sql = "SELECT * FROM Infraction_type"; //display all

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "Infraction_type");

            conn.Close();
            conn.Open();

            dgvPointsch.DataSource = ds;
            dgvPointsch.DataMember = "Infraction_type";

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cbResult = cbPosition.SelectedItem.ToString();

                {
                    if (cbResult.Equals("Student"))//add new student
                    {

                        {
                            sql =                         "       INSERT INTO Student(Student_NWU_ID, Student_ID, Student_Name, Student_Surname, Campus_Name)" +
                                                          "       VALUES(@Student_NWU_ID, @Student_ID, @Student_Name, @Student_Surname, @Campus_Name)";
                            conn = new SqlConnection(conStr);
                            conn.Open();
                            comm = new SqlCommand(sql, conn);
                            adap = new SqlDataAdapter();
                            comm.Parameters.AddWithValue("@Student_NWU_ID", txtSNO.Text);
                            comm.Parameters.AddWithValue("@Student_ID", txtID.Text);
                            comm.Parameters.AddWithValue("@Student_Name", txtName.Text);
                            comm.Parameters.AddWithValue("@Student_Surname", txtSurname.Text);
                            comm.Parameters.AddWithValue("@Campus_Name", cbCampus.SelectedItem.ToString());

                            adap.InsertCommand = comm;
                            adap.InsertCommand.ExecuteNonQuery();

                            conn.Close();
                            System.Windows.Forms.MessageBox.Show("Successfully added user!");
                        }

                    }
                    else if (cbResult.Equals("Staff"))//add new staff
                    {
                        sql =                             "       INSERT INTO Staff(Staff_NWU_ID, Staff_ID, Staff_Name, Staff_Surname, Staff_Admin, Campus_Name)" +
                                                          "       VALUES(@Staff_NWU_ID, @Staff_ID, @Staff_Name, @Staff_Surname, @Staff_Admin, @Campus_Name)";
                        conn = new SqlConnection(conStr);
                        conn.Open();
                        comm = new SqlCommand(sql, conn);
                        adap = new SqlDataAdapter();
                        comm.Parameters.AddWithValue("@Staff_NWU_ID", txtSNO.Text);
                        comm.Parameters.AddWithValue("@Staff_ID", txtID.Text);
                        comm.Parameters.AddWithValue("@Staff_Name", txtName.Text);
                        comm.Parameters.AddWithValue("@Staff_Surname", txtSurname.Text);
                        comm.Parameters.AddWithValue("@Staff_Admin", false);
                        comm.Parameters.AddWithValue("@Campus_Name", cbCampus.SelectedItem.ToString());

                        adap.InsertCommand = comm;
                        adap.InsertCommand.ExecuteNonQuery();

                        conn.Close();
                        System.Windows.Forms.MessageBox.Show("Successfully added user!");
                    }
                    else if (cbResult.Equals("Admin"))//add new admin
                    {
                        sql =                             "       INSERT INTO Staff(Staff_NWU_ID, Staff_ID, Staff_Name, Staff_Surname, Staff_Admin, Campus_Name)" +
                                                          "       VALUES(@Staff_NWU_ID, @Staff_ID, @Staff_Name, @Staff_Surname, @Staff_Admin, @Campus_Name)";
                        conn = new SqlConnection(conStr);
                        conn.Open();
                        comm = new SqlCommand(sql, conn);
                        adap = new SqlDataAdapter();
                        comm.Parameters.AddWithValue("@Staff_NWU_ID", txtSNO.Text);
                        comm.Parameters.AddWithValue("@Staff_ID", txtID.Text);
                        comm.Parameters.AddWithValue("@Staff_Name", txtName.Text);
                        comm.Parameters.AddWithValue("@Staff_Surname", txtSurname.Text);
                        comm.Parameters.AddWithValue("@Staff_Admin", true);
                        comm.Parameters.AddWithValue("@Campus_Name", cbCampus.SelectedItem.ToString());

                        adap.InsertCommand = comm;
                        adap.InsertCommand.ExecuteNonQuery();

                        conn.Close();
                        System.Windows.Forms.MessageBox.Show("Successfully added user!");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }


        }
    }
}
