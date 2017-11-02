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
     public partial class Login : Form
     {
          private SqlConnection con;
          public Login()
          {
               InitializeComponent();
               con = new SqlConnection("Data Source=SUB\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
          }
          private void ClearButton_Click(object sender, EventArgs e)
          {
               UserName_TextBox.Clear();
               Password_TextBox.Clear();
               UserName_TextBox.Focus();
          }
          private void LoginButton_Click(object sender, EventArgs e)
          {
                
               SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
               FROM [dbo].[Login] Where UserName='"+UserName_TextBox.Text+"' and Password='"+Password_TextBox.Text+"'", con);
               DataTable dt = new DataTable();
               sda.Fill(dt);
               if (dt.Rows.Count == 1)
               {
                    this.Hide();
                    StockMain main = new StockMain();
                    main.Show();
               }
               else
               {
                    MessageBox.Show("Invalid User & Password!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearButton_Click(sender, e);
               }
          }

          private void Password_TextBox_KeyDown(object sender, KeyEventArgs e)
          {
               if (e.KeyCode == Keys.Enter)
               {
                    LoginButton_Click(this, new EventArgs());
               }
          }
          private bool IfUserExists()
          {
               SqlDataAdapter sda = new SqlDataAdapter("Select * From[Login] WHERE [UserName] = '" + UserName_TextBox.Text + "'", con);
               DataTable dt = new DataTable();
               sda.Fill(dt);
               if (dt.Rows.Count > 0)
                    return true;
               else
                    return false;
          }
          private void Register_Button_Click(object sender, EventArgs e)
          {
               con.Open();
               if (IfUserExists())
               {
                    MessageBox.Show("User already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearButton_Click(sender, e);
                    con.Close();
               }
               else
               {
                    SqlCommand cmd = new SqlCommand(@"
                         INSERT INTO[Stock].[dbo].[Login]
                         ([UserName]
                         ,[Password])
                         VALUES
                         ('" + UserName_TextBox.Text + "','" + Password_TextBox.Text +"')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User registered succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }
          }
     }
}
