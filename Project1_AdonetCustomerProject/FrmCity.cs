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
    public partial class FrmCity : Form
    {
        public FrmCity()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-GRDREHV\\SQLEXPRESS; initial catalog=DbCustomer; integrated security=true");
        private void btnList_Click(object sender, EventArgs e)
        {
            

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-GRDREHV\\SQLEXPRESS; initial catalog=DbCustomer; integrated security=true");


            sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into City (CityName,CityCountry) values (@cityName,@cityCountry)", sqlConnection);
            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
            command.Parameters.AddWithValue("@cityCountry", txtCountry.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir başarılı bir şekilde eklendi.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Delete From City Where CityId=@cityId", sqlConnection);
            command.Parameters.AddWithValue("@cityId", txtCityId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir Başarılı bir Şekilde Silindi", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("update City Set CityName=@cityName,CityCountry=@cityCountry where CityId=@cityId", sqlConnection);
            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
            command.Parameters.AddWithValue("@cityCountry", txtCountry.Text);
            command.Parameters.AddWithValue("@cityId", txtCityId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir Başarılı bir Şekilde Güncellendi", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("Select * From City Where CityName=@cityName", sqlConnection);
            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();

        }
    }
}
