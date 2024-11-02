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

namespace Project1_AdonetCustomerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-GRDREHV\\SQLEXPRESS; initial catalog=DbCustomer; integrated security=true");

            sqlConnection.Open();
            //Sorgu oluşturdu.
            SqlCommand command = new SqlCommand("Select * From City", sqlConnection);
            //Köprü görevi veri tabanıyla vs'nin
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            // Gride veriyi aktarmak için verileri tuttuğumuz dataTable oluşturuldu.
            DataTable dataTable = new DataTable();
            // Bu tablonun içini dolduruldu.
            adapter.Fill(dataTable);
            //Data gride bu veriler kaynak olarak referans edildi.
            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }
    }
}
