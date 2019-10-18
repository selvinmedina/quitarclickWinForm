using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
            using (NorthwindEntities db = new NorthwindEntities())
            {
                productsBindingSource.DataSource = db.Products.ToList();
                categoriesBindingSource.DataSource = db.Categories.ToList();
            }
           // dataGridView1.CurrentCell.Selected = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //funciona
           // dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
            //dataGridView1.CurrentCell.Selected = true;
            //MessageBox.Show("ff");
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        }

        private void dataGridView1_MouseHover(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        }

        private void dataGridView1_Move(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Layout(object sender, LayoutEventArgs e)
        {
           // dataGridView1.CurrentCell.Selected = true;
           // MessageBox.Show("dff");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //dataGridView1.CurrentCell.Selected = true;
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //dataGridView1.CurrentCell.Selected = true;
        }
    }
}
