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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-GRDREHV\\SQLEXPRESS; initial catalog=DbCustomer; integrated security=true");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            //Sorgu oluşturdu.
            SqlCommand command = new SqlCommand("select CustomerId,CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CityName From Customer Inner Join City On City.CityId = Customer.CustomerCity", sqlConnection);
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

        private void btnProsedure_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            //Sorgu oluşturdu.
            SqlCommand command = new SqlCommand("Execute CustomerListWithCity", sqlConnection);
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
