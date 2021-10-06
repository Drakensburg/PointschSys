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
        private string sql;
        private int total;


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

                /* Discipline table */
                LoadDiscipline();

                lstReport.Items.Add("------------------------------------------------------------------------------");

                /* Infraction table */
                LoadInfraction();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FormatOutput()
        {
            string header = "Pointsch Type\tPointsch Subtype\t\tTotal Previous Month\tTotal Present Month\n\n";

            lstReport.Items.Add(header);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstReport.Items.Clear();
            FormatOutput();
            LoadDiscipline();
            LoadInfraction();
        }

        private void LoadDiscipline()
        {
            sql = "SELECT Discipline_Type_Code, SUM(Discipline_Pointsch) AS Discipline_Total " +
                  "FROM Discipline";

            comm = new SqlCommand(sql, conn);
            reader = comm.ExecuteReader();

            total = 0;
            while (reader.Read())
            {
                total += Convert.ToInt32(reader.GetValue(2));
            }

            lstReport.Items.Add("Discipline\t\t" + total);

            while (reader.Read())
            {
                string output = "\t\t" + reader.GetValue(0) + "\t" + reader.GetValue(1);

                lstReport.Items.Add(output);
            }
        }

        private void LoadInfraction()
        {
            sql = "SELECT Infraction_Type_Code, SUM(Infraction_Pointsch) AS Infraction_Total " +
                  "FROM Infraction";

            comm = new SqlCommand(sql, conn);
            reader = comm.ExecuteReader();

            total = 0;
            while (reader.Read())
            {
                total += Convert.ToInt32(reader.GetValue(2));
            }

            lstReport.Items.Add("Infraction\t\t" + total);

            while (reader.Read())
            {
                string output = "\t\t" + reader.GetValue(0) + "\t" + reader.GetValue(1);

                lstReport.Items.Add(output);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
