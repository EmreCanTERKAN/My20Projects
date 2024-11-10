using Project4_EfCodeFirstMovie.DAL.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_EfCodeFirstMovie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MovieContext context = new MovieContext();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = context.Categories.ToList();
            dataGridView1.DataSource = values;
        }
    }
}
