﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace NWU_Pointsch_System
{
    public partial class frmLogin : Form
    {
        public string StudentNumber, StadminNumber = "";
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbPointsch.mdf;Integrated Security=True";
        SqlConnection conn;   
        SqlCommand comm;
        SqlDataReader reader;
        string sql = "";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearCredentials()
        {
            StudentNumber = "";
            StadminNumber = "";

            txtUser.Text = "";
            txtIDNumber.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tempStudentNum = txtUser.Text;
            string tempStadminNum = txtUser.Text;
            string tempID =     txtIDNumber.Text;

            bool bMis   = true;
            bool bExist = false;

            if (tempStudentNum.Length != 8 || tempStadminNum.Length != 8)   //Test Credential Validity START
            {
                MessageBox.Show("SNO must be exactly 8 digits long");
            }
            else if (tempID.Length != 13)
            {
                MessageBox.Show("ID must be exactly 13 digits long");
            }
            else if (Regex.Matches(tempID, @"[a-zA-Z]").Count > 0|| Regex.Matches(tempStadminNum, @"[a-zA-Z]").Count > 0 || Regex.Matches(tempStudentNum, @"[a-zA-Z]").Count > 0)
            {
                MessageBox.Show("ID or SNO must not contain letters!");
            }                                                               //Test Credential Validity END
            else                                                            //Check if in DB START
            {
                try
                {
                    conn = new SqlConnection(conStr);
                    conn.Open();
                    sql = "SELECT Student_NWU_ID FROM Student WHERE Student_NWU_ID = @num1";
                }
                catch (Exception)
                {
                    MessageBox.Show("Database Unavailable");
                }

                comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@num1", tempStudentNum);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string temp = reader.GetString(0);
                    if (tempStudentNum == temp)
                    {
                        bExist = true;
                        conn.Close();
                        break;
                    }
                }
                conn.Close();


                try
                {
                    conn = new SqlConnection(conStr);
                    conn.Open();
                    sql = "SELECT Staff_NWU_ID FROM Staff WHERE Staff_NWU_ID = @num1";
                }
                catch (Exception)
                {
                    MessageBox.Show("Database Unavailable");
                }

                comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@num1", tempStadminNum);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string temp = reader.GetString(0);
                    if (tempStudentNum == temp)
                    {
                        bExist = true;
                        conn.Close();
                        break;
                    }
                }
                conn.Close();

                if(bExist == true)
                {
                    try
                    {
                        conn = new SqlConnection(conStr);
                        conn.Open();
                        sql = "SELECT Student_NWU_ID FROM Student WHERE Student_NWU_ID = @num1 AND Student_ID = @num2";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Database Unavailable");
                    }

                    comm = new SqlCommand(sql, conn);
                    comm.Parameters.AddWithValue("@num1", tempStudentNum);
                    comm.Parameters.AddWithValue("@num2", tempID);
                    reader = comm.ExecuteReader();

                    while (reader.Read())
                    {
                        string temp = reader.GetString(0);
                        if (tempStudentNum == temp)
                        {
                            StudentNumber = txtUser.Text;
                            frmProfile fProfile = new frmProfile();
                            fProfile.ShowDialog();
                            conn.Close();
                            bMis = false;
                            clearCredentials();
                            break;
                        }
                    }
                    conn.Close();


                    try
                    {
                        conn = new SqlConnection(conStr);
                        conn.Open();
                        sql = "SELECT Staff_NWU_ID FROM Staff WHERE Staff_NWU_ID = @num1 AND Staff_ID = @num2";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Database Unavailable");
                    }

                    comm = new SqlCommand(sql, conn);
                    comm.Parameters.AddWithValue("@num1", tempStadminNum);
                    comm.Parameters.AddWithValue("@num2", tempID);
                    reader = comm.ExecuteReader();

                    while (reader.Read())
                    {
                        string temp = reader.GetString(0);
                        if (tempStudentNum == temp)
                        {
                            StadminNumber = txtUser.Text;
                            frmStadmin fStadmin = new frmStadmin();
                            fStadmin.ShowDialog();
                            conn.Close();
                            bMis = false;
                            clearCredentials();
                            break;
                        }
                    }
                    conn.Close();
                }
                else 
                {
                    MessageBox.Show("Person does not exist within database!");                
                }

                if (bMis == true)
                {
                    MessageBox.Show("SNO/ID Mismatch!");
                }

                bMis = true;
                bExist = false;
                tempStudentNum = "";
                tempStadminNum = "";
                tempID = "";
            }                                                             //Check if in DB END 
        }
    }
}
