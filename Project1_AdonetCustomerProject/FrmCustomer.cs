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

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            //Sorgu oluşturdu.
            SqlCommand command = new SqlCommand("Select * From City", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cmbCitiation.ValueMember = "CityId";
            cmbCitiation.DisplayMember = "CityName";
            cmbCitiation.DataSource = dataTable;
            sqlConnection.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Insert Into Customer (CustomerName,CustomerSurname,CustomerCity,CustomerBalance,CustomerStatus) values(@customerName,@customerSurname,@customerCity,@customerBalance,@customerStatus)",sqlConnection);
            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@customerCity", cmbCitiation.SelectedValue);
            command.Parameters.AddWithValue("@customerBalance", txtCustomerAmount.Text);
            if (rdbActive.Checked)
            {
                command.Parameters.AddWithValue("@customerStatus", true);
            }
            if (rdbPassive.Checked)
            {
                command.Parameters.AddWithValue("@customerStatus", false);
            }
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri Başarıyla Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Delete From Customer Where CustomerId=@customerId", sqlConnection);
            command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri Başarılı bir Şekilde Silindi", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("YourConnectionString"))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("UPDATE Customer SET CustomerName=@customerName, CustomerSurname=@customerSurname, CustomerCity=@customerCity, CustomerBalance=@customerBalance, CustomerStatus=@customerStatus WHERE CustomerId=@customerId", sqlConnection);

                command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
                command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
                command.Parameters.AddWithValue("@customerCity", cmbCitiation.SelectedValue);
                command.Parameters.AddWithValue("@customerBalance", txtCustomerAmount.Text);
                command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);

                if (rdbActive.Checked)
                {
                    command.Parameters.AddWithValue("@customerStatus", true);
                }
                else if (rdbPassive.Checked)
                {
                    command.Parameters.AddWithValue("@customerStatus", false);
                }
                else
                {
                    // Eğer hiçbir radio button seçilmediyse, default bir değer atanabilir.
                    command.Parameters.AddWithValue("@customerStatus", false); // Veya başka bir değer.
                }

                command.ExecuteNonQuery();
                MessageBox.Show("Müşteri Başarıyla Güncellendi");
            } // using bloğu burada bağlantıyı otomatik kapatır.
        }

    }
}
