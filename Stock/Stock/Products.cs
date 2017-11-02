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

namespace Stock
{
     public partial class Products : Form
     {
          private SqlConnection con;
          public Products()
          {
               InitializeComponent();
               con = new SqlConnection("Data Source=SUB\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
          }

          private void Products_Load(object sender, EventArgs e)
          {
               Status_ComboBox.SelectedIndex = 0;
               LoadData(con);
          }

          private void Add_Button_Click(object sender, EventArgs e)
          {               
               con.Open();
               if (IfProductExists(con, ProductCode_TextBox.Text))
               {
                    MessageBox.Show("Product already exists in Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
               }
               else
               {
                    bool status = false;
                    if (Status_ComboBox.SelectedIndex == 0)
                         status = true;
                    else
                         status = false;
                    SqlCommand cmd = new SqlCommand(@"
                         INSERT INTO[Stock].[dbo].[Products]
                         ([ProductCode]
                         ,[ProductName]
                         ,[ProductStatus])
                         VALUES
                         ('" + ProductCode_TextBox.Text + "','" + ProductName_TextBox.Text + "','" + status + "')", con);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmmd = new SqlCommand(@"
                         INSERT INTO[Stock].[dbo].[Stock]
                         ([ProductCode]
                         ,[ProductName])
                         VALUES
                         ('" + ProductCode_TextBox.Text + "','" + ProductName_TextBox.Text + "')", con);
                    cmmd.ExecuteNonQuery();
                    con.Close();
                    LoadData(con);
                    con.Close();
               }
               
          }
          public void LoadData(SqlConnection con)
          {
               SqlDataAdapter sda = new SqlDataAdapter("Select * From[Stock].[dbo].[Products]", con);
               DataTable dt = new DataTable();
               sda.Fill(dt);
               dataGridView1.Rows.Clear();
               foreach (DataRow item in dt.Rows)
               {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                    if ((bool)item["ProductStatus"])
                         dataGridView1.Rows[n].Cells[2].Value = "Active";
                    else
                         dataGridView1.Rows[n].Cells[2].Value = "Deactive";
               }
          }

          private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
          {
               ProductCode_TextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
               ProductName_TextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
               if (dataGridView1.Rows[0].Cells[2].Value.ToString() == "Active")
                    Status_ComboBox.SelectedIndex = 0;
               else
                    Status_ComboBox.SelectedIndex = 1;
          }
          private bool IfProductExists(SqlConnection con, string productCode)
          {
               SqlDataAdapter sda = new SqlDataAdapter("Select * From[Products] WHERE [ProductCode] = '"+productCode+"'", con);
               DataTable dt = new DataTable();
               sda.Fill(dt);
               if (dt.Rows.Count > 0)
                    return true;
               else
                    return false;
          }
          private void UpdateButton_Click(object sender, EventArgs e)
          {
               con.Open();
               if (IfProductExists(con, ProductCode_TextBox.Text))
               {
                    bool status = false;
                    if (Status_ComboBox.SelectedIndex == 0)
                         status = true;
                    else
                         status = false;
                    SqlCommand cmd = new SqlCommand(@"UPDATE [Products] SET [ProductName] = '" + ProductName_TextBox.Text + "',[ProductStatus] = '" + status + "' WHERE [ProductCode] = '" + ProductCode_TextBox.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmmd = new SqlCommand(@"UPDATE [Stock] SET [ProductName] = '" + ProductName_TextBox.Text + "' WHERE [ProductCode] = '" + ProductCode_TextBox.Text + "'", con);
                    cmmd.ExecuteNonQuery();
                    con.Close();
                    LoadData(con);
                    
               }
               else
               {
                    MessageBox.Show("Product does not exist in Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
               }
               
          }

          private void Delete_Button_Click(object sender, EventArgs e)
          {
               con.Open();
               if (IfProductExists(con, ProductCode_TextBox.Text))
               {
                    SqlCommand cmd = new SqlCommand(@"DELETE FROM [Products] WHERE [ProductCode] = '" + ProductCode_TextBox.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmmd = new SqlCommand(@"DELETE FROM [Stock] WHERE [ProductCode] = '" + ProductCode_TextBox.Text + "'", con);
                    cmmd.ExecuteNonQuery();
                    con.Close();
                    LoadData(con);
               }
               else
               {
                    MessageBox.Show("Product does not exist in Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
               }
          }
          private void Update_To_Stock()
          {

          }
     }
}
