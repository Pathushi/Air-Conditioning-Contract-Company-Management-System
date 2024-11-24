using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace createAbargraph
{
    public partial class customerFeedback : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr = null;
        DataTable dt = new DataTable();

        public customerFeedback()
        {
            InitializeComponent();
            LoadBarChart();
            LoadPieChart();
        }

        private void LoadBarChart()
        {
            string connectionString = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            string query = "SELECT Feedback_Id, Ratings FROM FeedbackChart";

            using (SqlConnection connection1 = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection1);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                chart1.Series.Clear();
                chart1.Series.Add("data");
                chart1.Series["data"].XValueMember = "Feedback_ID";
                chart1.Series["data"].YValueMembers = "Ratings";
                chart1.DataSource = dt;
                chart1.DataBind();
            }
        }

        private void LoadPieChart()
        {
            string connectionString = "Data Source=hp\\mssqlserver01;Initial Catalog=Air_Conditioning_Company;Integrated Security=True";
            string query = @"
            SELECT Ratings, COUNT(*) AS RatingCount FROM FeedbackChart GROUP BY Ratings";

            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection2);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                int totalCount = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    totalCount += Convert.ToInt32(row["RatingCount"]);
                }

                chart2.Series.Clear();
                chart2.Series.Add("Ratings");
                chart2.Series["Ratings"].ChartType = SeriesChartType.Pie;

                foreach (DataRow row in dataTable.Rows)
                {
                    int rating = Convert.ToInt32(row["Ratings"]);
                    int count = Convert.ToInt32(row["RatingCount"]);
                    double percentage = (double)count / totalCount * 100;

                    string label;
                    switch (rating)
                    {
                        case -1:
                            label = "Bad";
                            break;
                        case 0:
                            label = "Neutral";
                            break;
                        case 1:
                            label = "Good";
                            break;
                        default:
                            label = "Unknown";
                            break;
                    }
                    chart2.Series["Ratings"].Points.AddXY(label, percentage);
                }

                // Optional: Show percentages on the chart slices
                chart2.Series["Ratings"].IsValueShownAsLabel = true;
                chart2.Series["Ratings"].LabelFormat = "0.##\"%\"";  // Format label as percentage

                // Enable 3D if needed
                chart2.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
        }
    }
}