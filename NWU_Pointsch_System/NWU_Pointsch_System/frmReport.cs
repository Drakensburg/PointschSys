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
    public partial class frmReport : Form
    {
        SqlConnection conn;
        private string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbPointsch.mdf;Integrated Security=True";
        SqlDataReader reader;
        SqlCommand comm;
        private string sqlD, sqlI;
        private int total;
        private string sort = "ASC";
        private string action = "Both";


        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);//Create a new sqlconnection instance
                conn.Open();                  

                FormatOutput();//Adding the appropriate columb headings to the listbox
                lstReport.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                /* Discipline table */
                LoadDiscipline();

                lstReport.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                /* Infraction table */
                LoadInfraction();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        /* Create columb heading for the report */
        private void FormatOutput()
        {
            string header = "Pointsch Type\tPointsch Subtype\t\tTotal\n\n";

            lstReport.Items.Add(header);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstReport.Items.Clear();
        }
        /* Load discipline data into the report */
        private void LoadDiscipline()
        {
            if (sort == "ASC")
            {
                sqlD = "SELECT Discipline_Type_Code, SUM(Discipline_Pointsch) AS Discipline_Total " +
                       "FROM Discipline GROUP BY DISCIPLINE_TYPE_CODE " +
                       "ORDER BY Discipline_Type_Code ASC";

                comm = new SqlCommand(sqlD, conn);
                reader = comm.ExecuteReader();

                total = 0;
                while (reader.Read())
                {
                    total += Convert.ToInt32(reader.GetValue(1));//Reading the discipline totals into the variable total
                }

                lstReport.Items.Add("Discipline\t\t\t\t\t\t\t\t" + total);//Adding the sub-heading "Discipline" and it's total to the report

                reader.Close();
                comm = new SqlCommand(sqlD, conn);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string output = "\t\t" + reader.GetString(0) + "\t\t\t\t\t\t" + reader.GetValue(1);//Reading the discipline types and their totals into the variable output

                    lstReport.Items.Add(output);//Adding the variable output to the report
                }

                reader.Close();
            }
            else if(sort == "DESC")
            {
                sqlD = "SELECT Discipline_Type_Code, SUM(Discipline_Pointsch) AS Discipline_Total " +
                       "FROM Discipline GROUP BY DISCIPLINE_TYPE_CODE " +
                       "ORDER BY Discipline_Type_Code DESC";

                comm = new SqlCommand(sqlD, conn);
                reader = comm.ExecuteReader();

                total = 0;
                while (reader.Read())
                {
                    total += Convert.ToInt32(reader.GetValue(1));//Reading the discipline totals into the variable total
                }

                lstReport.Items.Add("Discipline\t\t\t\t\t\t\t\t" + total);//Adding the sub-heading "Discipline" and it's total to the report

                reader.Close();
                comm = new SqlCommand(sqlD, conn);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string output = "\t\t" + reader.GetString(0) + "\t\t\t\t\t\t" + reader.GetValue(1);//Reading the discipline types and their totals into the variable output

                    lstReport.Items.Add(output);//Adding the variable output to the report
                }

                reader.Close();
            }

 
        }
        /* Load infraction data into the report */
        private void LoadInfraction()
        {
            if (sort == "ASC")
            {
                sqlI = "SELECT Infraction_Type_Code, SUM(Infraction_Pointsch) AS Infraction_Total " +
                       "FROM Infraction GROUP BY INFRACTION_TYPE_CODE " +
                       "ORDER BY Infraction_Type_Code ASC";

                comm = new SqlCommand(sqlI, conn);
                reader = comm.ExecuteReader();

                total = 0;
                while (reader.Read())
                {
                    total += Convert.ToInt32(reader.GetValue(1));//Reading the infraction totals into the variable total
                }

                lstReport.Items.Add("Infraction\t\t\t\t\t\t\t\t" + total);//Adding the sub-heading "Infraction" and it's total to the report

                reader.Close();
                comm = new SqlCommand(sqlI, conn);
                reader = comm.ExecuteReader();


                while (reader.Read())
                {
                    string output = "\t\t" + reader.GetString(0) + "\t\t\t\t\t\t" + reader.GetValue(1);//Reading the infraction types and their totals into the variable output

                    lstReport.Items.Add(output);//Adding the variable output to the report
                }

                reader.Close();
            }
            else if (sort == "DESC")
            {
                sqlI = "SELECT Infraction_Type_Code, SUM(Infraction_Pointsch) AS Infraction_Total " +
                       "FROM Infraction GROUP BY INFRACTION_TYPE_CODE " +
                       "ORDER BY Infraction_Type_Code DESC";

                comm = new SqlCommand(sqlI, conn);
                reader = comm.ExecuteReader();

                total = 0;
                while (reader.Read())
                {
                    total += Convert.ToInt32(reader.GetValue(1));//Reading the infraction totals into the variable total
                }

                lstReport.Items.Add("Infraction\t\t\t\t\t\t\t\t" + total);//Adding the sub-heading "Infraction" and it's total to the report

                reader.Close();
                comm = new SqlCommand(sqlI, conn);
                reader = comm.ExecuteReader();


                while (reader.Read())
                {
                    string output = "\t\t" + reader.GetString(0) + "\t\t\t\t\t\t" + reader.GetValue(1);//Reading the infraction types and their totals into the variable output

                    lstReport.Items.Add(output);//Adding the variable output to the report
                }

                reader.Close();
            }
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filtered();      
        }

        private void Filtered ()
        {
            conn = new SqlConnection(constr);
            conn.Open();

            lstReport.Items.Clear();//Clear the listbox
            string month = "%/Oct/%";
            string output;
            string campus = "Potchefstroom";

            if (cmbMonth.SelectedIndex.ToString() != null && cmbCampus.SelectedIndex.ToString() != null)//If both comboboxes are empty
            {
                FormatOutput();
                LoadDiscipline();
                LoadInfraction();
            }
            else if (cmbMonth.SelectedIndex.ToString() != null)//If the Combobox for the campus filter is empty
            {
                FormatOutput();
                switch (cmbMonth.SelectedIndex)//Switch to determine the month
                {
                    case 0:
                        month = "%Jan%";
                        break;
                    case 1:
                        month = "%Feb%";
                        break;
                    case 2:
                        month = "%Mar%";
                        break;
                    case 3:
                        month = "%Apr%";
                        break;
                    case 4:
                        month = "%May%";
                        break;
                    case 5:
                        month = "%Jun%";
                        break;
                    case 6:
                        month = "%Jul%";
                        break;
                    case 7:
                        month = "%Aug%";
                        break;
                    case 8:
                        month = "%Sep%";
                        break;
                    case 9:
                        month = "%Oct%";
                        break;
                    case 10:
                        month = "%Nov%";
                        break;
                    case 11:
                        month = "%Dec%";
                        break;
                }



                if (action == "Both")//Displays both action types
                {
                    if (sort == "ASC")//Sorting the values in ascending order
                    {
                        sqlD = "SELECT Discipline_Type_Code, SUM(Discipline_Pointsch) AS Discipline_Total " +
                               "FROM Discipline " +
                               "WHERE Discipline_Date = @month " +
                               "ORDER BY Discipline_Type_Code ASC";

                        sqlI = "SELECT Infraction_Type_Code, SUM(Infraction_Pointsch) AS Infraction_Total " +
                               "FROM Infraction " +
                               "WHERE Infraction_Date = @month " +
                               "ORDER BY Infraction_Type_Code ASC";
                    }
                    else if (sort == "DESC")//Sorting the values in descending order
                    {
                        sqlD = "SELECT Discipline_Type_Code, SUM(Discipline_Pointsch) AS Discipline_Total " +
                               "FROM Discipline " +
                               "WHERE Discipline_Date = @month " +
                               "ORDER BY Discipline_Type_Code DESC";

                        sqlI = "SELECT Infraction_Type_Code, SUM(Infraction_Pointsch) AS Infraction_Total " +
                               "FROM Infraction " +
                               "WHERE Infraction_Date = @month " +
                               "ORDER BY Infraction_Type_Code DESC";
                    }


                    comm = new SqlCommand(sqlD, conn);
                    comm.Parameters.AddWithValue("@month", month);
                    reader = comm.ExecuteReader();

                    /* Adding the values to the listbox */
                    while (reader.Read())
                    {
                        output = reader.GetString(0) + reader.GetValue(1).ToString();

                        lstReport.Items.Add(output);
                    }

                    reader.Close();

                    lstReport.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");



                    comm = new SqlCommand(sqlI, conn);
                    comm.Parameters.AddWithValue("@month", month);
                    reader = comm.ExecuteReader();

                    /* Adding the values to the listbox */
                    while (reader.Read())
                    {
                        output = reader.GetString(0) + reader.GetValue(1).ToString();

                        lstReport.Items.Add(output);
                    }

                    reader.Close();
                }
                else if (action == "Discipline")//Displays only the discipline action types
                {
                    if (sort == "ASC")//Sorting the values in ascending order
                    {
                        sqlD = "SELECT Discipline_Type_Code, SUM(Discipline_Pointsch) AS Discipline_Total " +
                               "FROM Discipline " +
                               "WHERE Discipline_Date = @month " +
                               "ORDER BY Discipline_Type_Code ASC";
                    }
                    else if (sort == "DESC")//Sorting the values in descending order
                    {
                        sqlD = "SELECT Discipline_Type_Code, SUM(Discipline_Pointsch) AS Discipline_Total " +
                               "FROM Discipline " +
                               "WHERE Discipline_Date = @month " +
                               "ORDER BY Discipline_Type_Code DESC";
                    }



                    comm = new SqlCommand(sqlD, conn);
                    comm.Parameters.AddWithValue("@month", month);
                    reader = comm.ExecuteReader();

                    /* Adding the values to the listbox */
                    while (reader.Read())
                    {
                        output = reader.GetString(0) + reader.GetValue(1).ToString();

                        lstReport.Items.Add(output);
                    }

                    reader.Close();
                }
                else if (action == "Infraction")//Displays only the infraction action types
                {
                    if (sort == "ASC")//Sorting the values in ascending order
                    {
                        sqlI = "SELECT Infraction_Type_Code, SUM(Infraction_Pointsch) AS Infraction_Total " +
                               "FROM Infraction " +
                               "WHERE Infraction_Date = @month " +
                               "ORDER BY Infraction_Type_Code ASC";
                    }
                    else if (sort == "DESC")//Sorting the values in descending order
                    {
                        sqlI = "SELECT Infraction_Type_Code, SUM(Infraction_Pointsch) AS Infraction_Total " +
                               "FROM Infraction " +
                               "WHERE Infraction_Date = @month " +
                               "ORDER BY Infraction_Type_Code DESC";
                    }



                    comm = new SqlCommand(sqlI, conn);
                    comm.Parameters.AddWithValue("@month", month);
                    reader = comm.ExecuteReader();

                    /* Adding the values to the listbox */
                    while (reader.Read())
                    {
                        output = reader.GetString(0) + reader.GetValue(1).ToString();

                        lstReport.Items.Add(output);
                    }

                    reader.Close();
                }


            }
            else if (cmbCampus.SelectedIndex.ToString() != null)
            {
                FormatOutput();
                switch (cmbCampus.SelectedIndex)//Switch to determine the campus
                {
                    case 0:
                        campus = "Potchefstroom";
                        break;
                    case 1:
                        campus = "Mafikeng";
                        break;
                    case 2:
                        campus = "Vaal";
                        break;
                }

                if (action == "Both")//Displays both action types
                {
                    if (sort == "ASC")//Sorting the values in ascending order
                    {
                        sqlD = "SELECT DISTINCT Discipline_Type.Discipline_Type as Type, SUM(Discipline_Pointsch) AS Discipline_Total " +
                               "FROM Discipline LEFT JOIN Staff ON Discipline.Staff_NWU_ID = Staff.Staff_NWU_ID Left join Discipline_type ON Discipline_type.Discipline_Type_Code = Discipline.Discipline_Type_Code " +
                               "WHERE Staff.Campus_Name = @campus " +
                               "GROUP BY discipline_Type.Discipline_Type " +
                               "ORDER BY Discipline_Type.Discipline_Type ASC";

                        sqlI = "SELECT DISTINCT Infraction_Type.Infraction_Type as Type, SUM(Infraction_Pointsch) AS Infraction_Total " +
                               "FROM Infraction LEFT JOIN Staff ON Infraction.Staff_NWU_ID = Staff.Staff_NWU_ID Left join Infraction_type ON Infraction_type.Infraction_Type_Code = Infraction.Infraction_Type_Code " +
                               "WHERE Staff.Campus_Name = @campus " +
                               "GROUP BY Infraction_Type.Infraction_Type " +
                               "ORDER BY Infraction_Type.Infraction_Type ASC";
                    }
                    else if (sort == "DESC")//Sorting the values in descending order
                    {
                        sqlD = "SELECT DISTINCT discipline_Type.Discipline_Type as Type, SUM(Discipline_Pointsch) AS Discipline_Total " +
                               "FROM Discipline LEFT JOIN Staff ON Discipline.Staff_NWU_ID = Staff.Staff_NWU_ID Left join Discipline_type ON Discipline_type.Discipline_Type_Code = Discipline.Discipline_Type_Code " +
                               "WHERE Staff.Campus_Name = @campus " +
                               "GROUP BY discipline_Type.Discipline_Type " +
                               "ORDER BY Discipline_Type.Discipline_Type DESC";

                        sqlI = "SELECT DISTINCT Infraction_Type.Infraction_Type_Code as Type, SUM(Infraction_Pointsch) AS Infraction_Total " +
                               "FROM Infraction LEFT JOIN Staff ON Infraction.Staff_NWU_ID = Staff.Staff_NWU_ID Left join Infraction_type ON Infraction_type.Infraction_Type_Code = Infraction.Infraction_Type_Code " +
                               "WHERE Staff.Campus_Name = @campus " +
                               "GROUP BY Infraction_Type.Infraction_Type " +
                               "ORDER BY Infraction_Type.Infraction_Type DESC";
                    }



                    comm = new SqlCommand(sqlD, conn);
                    comm.Parameters.AddWithValue("@campus", campus);
                    reader = comm.ExecuteReader();

                    /* Adding the values to the listbox */
                    while (reader.Read())
                    {
                        output = reader.GetString(0) + reader.GetValue(1).ToString();

                        lstReport.Items.Add(output);
                    }

                    reader.Close();

                    lstReport.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");



                    comm = new SqlCommand(sqlI, conn);
                    comm.Parameters.AddWithValue("@campus", campus);
                    reader = comm.ExecuteReader();

                    /* Adding the values to the listbox */
                    while (reader.Read())
                    {
                        output = reader.GetString(0) + reader.GetValue(1).ToString();

                        lstReport.Items.Add(output);
                    }

                    reader.Close();
                }
                else if (action == "Discipline")//Displays only the discipline action types
                {
                    if (sort == "ASC")//Sorting the values in ascending order
                    {
                        sqlD = "SELECT DISTINCT discipline_Type.Discipline_Type as Type, SUM(Discipline_Pointsch) AS Discipline_Total " +
                               "FROM Discipline LEFT JOIN Staff ON Discipline.Staff_NWU_ID = Staff.Staff_NWU_ID Left join Discipline_type ON Discipline_type.Discipline_Type_Code = Discipline.Discipline_Type_Code " +
                               "WHERE Staff.Campus_Name = @campus " +
                               "GROUP BY discipline_Type.Discipline_Type " +
                               "ORDER BY Discipline_Type.Discipline_Type ASC";
                    }
                    else if (sort == "DESC")//Sorting the values in descending order
                    {
                        sqlD = "SELECT DISTINCT discipline_Type.Discipline_Type as Type, SUM(Discipline_Pointsch) AS Discipline_Total " +
                               "FROM Discipline LEFT JOIN Staff ON Discipline.Staff_NWU_ID = Staff.Staff_NWU_ID Left join Discipline_type ON Discipline_type.Discipline_Type_Code = Discipline.Discipline_Type_Code " +
                               "WHERE Staff.Campus_Name = @campus " +
                               "GROUP BY discipline_Type.Discipline_Type " +
                               "ORDER BY Discipline_Type.Discipline_Type DESC";
                    }



                    comm = new SqlCommand(sqlD, conn);
                    comm.Parameters.AddWithValue("@campus", campus);
                    reader = comm.ExecuteReader();

                    /* Adding the values to the listbox */
                    while (reader.Read())
                    {
                        output = reader.GetString(0) + reader.GetValue(1).ToString();

                        lstReport.Items.Add(output);
                    }

                    reader.Close();
                }
                else if (action == "Infraction")//Displays only the infraction action types
                {
                    if (sort == "ASC")//Sorting the values in ascending order
                    {
                        sqlI = "SELECT DISTINCT Infraction_Type.Infraction_Type as Type, SUM(Infraction_Pointsch) AS Infraction_Total " +
                               "FROM Infraction LEFT JOIN Staff ON Infraction.Staff_NWU_ID = Staff.Staff_NWU_ID Left join Infraction_type ON Infraction_type.Infraction_Type_Code = Infraction.Infraction_Type_Code " +
                               "WHERE Staff.Campus_Name = @campus " +
                               "GROUP BY Infraction_Type.Infraction_Type " +
                               "ORDER BY Infraction_Type.Infraction_Type ASC";
                    }
                    else if (sort == "DESC")//Sorting the values in descending order
                    {
                        sqlI = "SELECT DISTINCT Infraction_Type.Infraction_Type as Type, SUM(Infraction_Pointsch) AS Infraction_Total " +
                               "FROM Infraction LEFT JOIN Staff ON Infraction.Staff_NWU_ID = Staff.Staff_NWU_ID Left join Infraction_type ON Infraction_type.Infraction_Type_Code = Infraction.Infraction_Type_Code " +
                               "WHERE Staff.Campus_Name = @campus " +
                               "GROUP BY Infraction_Type.Infraction_Type " +
                               "ORDER BY Infraction_Type.Infraction_Type DESC";
                    }

                    comm = new SqlCommand(sqlI, conn);
                    comm.Parameters.AddWithValue("@campus", campus);
                    reader = comm.ExecuteReader();

                    /* Adding the values to the listbox */
                    while (reader.Read())
                    {
                        output = reader.GetString(0) + reader.GetValue(1).ToString();

                        lstReport.Items.Add(output);
                    }

                    reader.Close();
                }


            }
            else
            {
                FormatOutput();
                switch (cmbMonth.SelectedIndex)//Switch to determine the month
                {
                    case 0:
                        month = "%Jan%";
                        break;
                    case 1:
                        month = "%Feb%";
                        break;
                    case 2:
                        month = "%Mar%";
                        break;
                    case 3:
                        month = "%Apr%";
                        break;
                    case 4:
                        month = "%May%";
                        break;
                    case 5:
                        month = "%Jun%";
                        break;
                    case 6:
                        month = "%Jul%";
                        break;
                    case 7:
                        month = "%Aug%";
                        break;
                    case 8:
                        month = "%Sep%";
                        break;
                    case 9:
                        month = "%Oct%";
                        break;
                    case 10:
                        month = "%Nov%";
                        break;
                    case 11:
                        month = "%Dec%";
                        break;
                }

                switch (cmbCampus.SelectedIndex)//Switch to determine the campus
                {
                    case 0:
                        campus = "Potchefstroom";
                        break;
                    case 1:
                        campus = "Mafikeng";
                        break;
                    case 2:
                        campus = "Vaal";
                        break;
                }

                if (action == "Both")//Displays both action types
                {
                    if (sort == "ASC")//Sorting the values in ascending order
                    {
                        sqlD = "SELECT DISTINCT discipline_Type.Discipline_Type as Type, SUM(Discipline_Pointsch) AS Discipline_Total " +
                               "FROM Discipline LEFT JOIN Staff ON Discipline.Staff_NWU_ID = Staff.Staff_NWU_ID Left join Discipline_type ON Discipline_type.Discipline_Type_Code = Discipline.Discipline_Type_Code " +
                               "WHERE Discipline.Discipline_Date = @month AND Staff.Campus_Name = @campus " +
                               "GROUP BY Discipline_Type.Discipline_Type " +
                               "ORDER BY Discipline_Type.Discipline_Type ASC";

                        sqlI = "SELECT DISTINCT Infraction_Type.Infraction_Type as Type, SUM(Infraction_Pointsch) AS Infraction_Total " +
                               "FROM Infraction LEFT JOIN Staff ON Infraction.Staff_NWU_ID = Staff.Staff_NWU_ID Left join Infraction_type ON Infraction_type.Infraction_Type_Code = Infraction.Infraction_Type_Code " +
                               "WHERE Infraction.Infraction_Date = @month AND Staff.Campus_Name = @campus " +
                               "GROUP BY Infraction_Type.Infraction_Type " +
                               "ORDER BY Infraction_Type.Infraction_Type ASC";
                    }
                    else if (sort == "DESC")//Sorting the values in descending order
                    {
                        sqlD = "SELECT DISTINCT discipline_Type.Discipline_Type as Type, SUM(Discipline_Pointsch) AS Discipline_Total " +
                               "FROM Discipline LEFT JOIN Staff ON Discipline.Staff_NWU_ID = Staff.Staff_NWU_ID Left join Discipline_type ON Discipline_type.Discipline_Type_Code = Discipline.Discipline_Type_Code " +
                               "WHERE Discipline.Discipline_Date = @month AND Staff.Campus_Name = @campus " +
                               "GROUP BY Discipline_Type.Discipline_Type " +
                               "ORDER BY Discipline_Type.Discipline_Type DESC";

                        sqlI = "SELECT DISTINCT Infraction_Type.Infraction_Type as Type, SUM(Infraction_Pointsch) AS Infraction_Total " +
                               "FROM Infraction LEFT JOIN Staff ON Infraction.Staff_NWU_ID = Staff.Staff_NWU_ID Left join Infraction_type ON Infraction_type.Infraction_Type_Code = Infraction.Infraction_Type_Code " +
                               "WHERE Infraction.Infraction_Date = @month AND Staff.Campus_Name = @campus " +
                               "GROUP BY Infraction_Type.Infraction_Type " +
                               "ORDER BY Infraction_Type.Infraction_Type DESC";
                    }



                    comm = new SqlCommand(sqlD, conn);
                    comm.Parameters.AddWithValue("@month", month);
                    comm.Parameters.AddWithValue("@campus", campus);
                    reader = comm.ExecuteReader();

                    /* Adding the values to the listbox */
                    while (reader.Read())
                    {
                        output = reader.GetString(0) + reader.GetValue(1).ToString();

                        lstReport.Items.Add(output);
                    }

                    reader.Close();

                    lstReport.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");



                    comm = new SqlCommand(sqlI, conn);
                    comm.Parameters.AddWithValue("@month", month);
                    comm.Parameters.AddWithValue("@campus", campus);
                    reader = comm.ExecuteReader();

                    /* Adding the values to the listbox */
                    while (reader.Read())
                    {
                        output = reader.GetString(0) + reader.GetValue(1).ToString();

                        lstReport.Items.Add(output);
                    }

                    reader.Close();
                }
                else if (action == "Discipline")//Displays only the discipline action types
                {
                    if (sort == "ASC")//Sorting the values in ascending order
                    {
                        sqlD = "SELECT DISTINCT discipline_Type.Discipline_Type as Type, SUM(Discipline_Pointsch) AS Discipline_Total " +
                               "FROM Discipline LEFT JOIN Staff ON Discipline.Staff_NWU_ID = Staff.Staff_NWU_ID Left join Discipline_type ON Discipline_type.Discipline_Type_Code = Discipline.Discipline_Type_Code " +
                               "WHERE Discipline.Discipline_Date = @month AND Staff.Campus_Name = @campus " +
                               "GROUP BY Discipline_Type.Discipline_Type " +
                               "ORDER BY Discipline_Type.Discipline_Type ASC";
                    }
                    else if (sort == "DESC")//Sorting the values in descending order
                    {
                        sqlD = "SELECT DISTINCT discipline_Type.Discipline_Type as Type, SUM(Discipline_Pointsch) AS Discipline_Total " +
                               "FROM Discipline LEFT JOIN Staff ON Discipline.Staff_NWU_ID = Staff.Staff_NWU_ID Left join Discipline_type ON Discipline_type.Discipline_Type_Code = Discipline.Discipline_Type_Code " +
                               "WHERE Discipline.Discipline_Date = @month AND Staff.Campus_Name = @campus " +
                               "GROUP BY Discipline_Type.Discipline_Type " +
                               "ORDER BY Discipline_Type.Discipline_Type DESC";
                    }



                    comm = new SqlCommand(sqlD, conn);
                    comm.Parameters.AddWithValue("@month", month);
                    comm.Parameters.AddWithValue("@campus", campus);
                    reader = comm.ExecuteReader();

                    /* Adding the values to the listbox */
                    while (reader.Read())
                    {
                        output = reader.GetString(0) + reader.GetValue(1).ToString();

                        lstReport.Items.Add(output);
                    }

                    reader.Close();
                }
                else if (action == "Infraction")//Displays only the infraction action types
                {
                    if (sort == "ASC")//Sorting the values in ascending order
                    {
                        sqlI = "SELECT DISTINCT Infraction_Type.Infraction_Type as Type, SUM(Infraction_Pointsch) AS Infraction_Total " +
                               "FROM Infraction LEFT JOIN Staff ON Infraction.Staff_NWU_ID = Staff.Staff_NWU_ID Left join Infraction_type ON Infraction_type.Infraction_Type_Code = Infraction.Infraction_Type_Code " +
                               "WHERE Infraction.Infraction_Date = @month AND Staff.Campus_Name = @campus " +
                               "GROUP BY Infraction_Type.Infraction_Type " +
                               "ORDER BY Infraction_Type.Infraction_Type ASC";
                    }
                    else if (sort == "DESC")//Sorting the values in descending order
                    {
                        sqlI = "SELECT DISTINCT Infraction_Type.Infraction_Type as Type, SUM(Infraction_Pointsch) AS Infraction_Total " +
                               "FROM Infraction LEFT JOIN Staff ON Infraction.Staff_NWU_ID = Staff.Staff_NWU_ID Left join Infraction_type ON Infraction_type.Infraction_Type_Code = Infraction.Infraction_Type_Code " +
                               "WHERE Infraction.Infraction_Date = @month AND Staff.Campus_Name = @campus " +
                               "GROUP BY Infraction_Type.Infraction_Type " +
                               "ORDER BY Infraction_Type.Infraction_Type DESC";
                    }



                    comm = new SqlCommand(sqlI, conn);
                    comm.Parameters.AddWithValue("@month", month);
                    comm.Parameters.AddWithValue("@campus", campus);
                    reader = comm.ExecuteReader();

                    /* Adding the values to the listbox */
                    while (reader.Read())
                    {
                        output = reader.GetString(0) + reader.GetValue(1).ToString();

                        lstReport.Items.Add(output);
                    }

                    reader.Close();
                }


            }
        }

        private void rbAsc_CheckedChanged(object sender, EventArgs e)
        {
            if(rbAsc.Checked == true)
            {
                sort = "ASC";
                rbDesc.Checked = false;

                Filtered();
            }
        }

        private void rbDesc_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDesc.Checked == true)
            {
                sort = "DESC";
                rbAsc.Checked = false;

                Filtered();
            }
        }

        private void rbBoth_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBoth.Checked == true)
            {
                lstReport.Items.Clear();

                action = "Both";
                rbDiscipline.Checked = false;
                rbInfraction.Checked = false;

                Filtered();
            }
        }

        private void rbDiscipline_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDiscipline.Checked == true)
            {
                lstReport.Items.Clear();

                action = "Discipline";
                rbBoth.Checked = false;
                rbInfraction.Checked = false;

                Filtered();
            }
        }

        private void rbInfraction_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInfraction.Checked == true)
            {
                lstReport.Items.Clear();

                action = "Infraction";
                rbBoth.Checked = false;
                rbDiscipline.Checked = false;

                Filtered();
            }
        }

        private void frmReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }


        /* Close the report form */
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
