using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
     public partial class StockMain : Form
     {
          private bool control;
          public StockMain()
          {
               InitializeComponent();
               control = false;
          }

          private void productsToolStripMenuItem_Click(object sender, EventArgs e)
          {
               Products prod = new Products();
               prod.MdiParent = this;
               prod.Show();
          }

          private void StockMain_FormClosing(object sender, FormClosingEventArgs e)
          {
               Application.Exit();
          }
          private void stockToolStripMenuItem_Click(object sender, EventArgs e)
          {
               StockWindow stock = new StockWindow();
               stock.Show();
          }
          private bool FindValue()
          {

               return true;
          }
     }
}
