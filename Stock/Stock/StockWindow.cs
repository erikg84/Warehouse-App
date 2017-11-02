using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
     public partial class StockWindow : Form
     {
          private SqlConnection con;
          public StockWindow()
          {
               con = new SqlConnection("Data Source=SUB\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");               
               InitializeComponent();
               LoadData();  
          }
          public void LoadData()
          {
               SqlDataAdapter sda = new SqlDataAdapter("Select * From[Stock].[dbo].[Stock]", con);
               DataTable dt = new DataTable();
               sda.Fill(dt);
               dataGridView1.Rows.Clear();
               foreach (DataRow item in dt.Rows)
               {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["TransDate"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["Quantity"].ToString();
               }
          }
          private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
          {
               ProductCode_TextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
               Quantity_TextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
          }

          private void RefreshButton_Click(object sender, EventArgs e)
          {
               LoadData();
          }
          public void Actualize()
          {
               SqlDataAdapter sda = new SqlDataAdapter("Select * From[Stock].[dbo].[Stock]", con);
               DataTable dt = new DataTable();
               sda.Fill(dt);
               dataGridView1.Rows.Clear();
               foreach (DataRow item in dt.Rows)
               {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["TransDate"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["Quantity"].ToString();
               }
          }
          private void Quantity_Button_Click(object sender, EventArgs e)
          {
               
               con.Open();
               if (IfProductExists(con, ProductCode_TextBox.Text))
               {
                    DateTime localDate = DateTime.Now;
                    SqlCommand cmd = new SqlCommand(@"UPDATE [Stock] SET [Quantity] = '" + Quantity_TextBox.Text + "', [TransDate] = '" + localDate.ToString() + "' WHERE [ProductCode] = '" + ProductCode_TextBox.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Actualize();
               }
               else
               {
                    MessageBox.Show("Product does not exist in Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
               }
          }
          private bool IfProductExists(SqlConnection con, string productCode)
          {
               SqlDataAdapter sda = new SqlDataAdapter("Select * From[Products] WHERE [ProductCode] = '" + productCode + "'", con);
               DataTable dt = new DataTable();
               sda.Fill(dt);
               if (dt.Rows.Count > 0)
                    return true;
               else
                    return false;
          }
     }
}
