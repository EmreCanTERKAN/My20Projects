using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_EntityFrameworkStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Db3Project20Entities db = new Db3Project20Entities();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Toplam Kategori Sayısı
            int categoryCount = db.TblCategory.Count();
            lblCategoryCount.Text = categoryCount.ToString();
            //Toplam Ürün Sayısı
            int productCount = db.TblProduct.Count();
            lblProductCount.Text = productCount.ToString();
            //Toplam Müşteri Sayısı
            int customerCount = db.TblCustomer.Count();
            lblCustomerCount.Text = customerCount.ToString();
            // Toplam Sipariş Sayısı
            int orderCount = db.TblOrder.Count();
            lblOrderCount.Text = orderCount.ToString();
            //Toplam Stok Sayısı
            var totalProductStockCount = db.TblProduct.Sum(x => x.ProductStock);
            lblProductTotalStock.Text = totalProductStockCount.ToString();
            //Ortalama Ürün Fiyatı
            var AverageProductPrice = db.TblProduct.Average(x => x.ProductPrice);
            lblProductAvgPrice.Text = AverageProductPrice.ToString() + "₺";
            //Toplam Meyve Stoğu
            var totalFruitStock = db.TblProduct.Where(x => x.CategoryId == 1).Sum(x => x.ProductStock);
            lblTotalFruiteStock.Text = totalFruitStock.ToString();
            //Gazozo İsimli Ürünün Toplam İşlem Hacmi
            var totalGazozPriceGetStock = db.TblProduct.Where(x => x.ProductName == "Gazoz")
                .Select(x => x.ProductStock).FirstOrDefault();
            var totalGazozPriceGetUnit = db.TblProduct.Where(x => x.ProductName == "Gazoz")
                .Select(x => x.ProductPrice).FirstOrDefault();
            var totalPrice = totalGazozPriceGetStock * totalGazozPriceGetUnit;
            lblTotalPriceByProductGazoz.Text = totalPrice.ToString() + "₺";
            // Stok sayısı 100den az olan ürünler
            var totalCountSmallerThen100 = db.TblProduct.Where(x => x.ProductStock < 100).Count();
            lblProductCountSmaller100.Text = totalCountSmallerThen100.ToString();
            //Kategorisi sebze vve durumu aktif(true) olan ürün stok toplamı
            var productStockCountByCategoryNameIsSebzeAndStatusIsTrue = db.TblProduct
                .Where(x => x.CategoryId == (db.TblCategory.Where(y => y.CatergoryName == "Sebze").Select(z => z.CategoryId).FirstOrDefault()) && x.ProductStatus == true)
                .Sum(x => x.ProductStock);
            lblProductCountByCategoryStatusTrue.Text = productStockCountByCategoryNameIsSebzeAndStatusIsTrue.ToString();
            //Türkiyeden yapılan Siparişler.. SqlQuery
            var orderCountFromTurkiye = db.Database.SqlQuery<int>("Select count(*) From TblOrder Where CustomerId In(Select CustomerId From TblCustomer Where CustomerCountry='Türkiye')").FirstOrDefault();
            lblOrderCountFromTurkiye.Text = orderCountFromTurkiye.ToString();
            //Türkiyeden yapılan Siparişler..EF ile getirme
            var turkishCustomerIds = db.TblCustomer
                .Where(x => x.CustomerCountry == "Türkiye")
                .Select(y => y.CustomerId)
                .ToList();
            var ordercountFromTurkiyeEf = db.TblOrder.Count(z => turkishCustomerIds.Contains(z.CustomerId.Value));
            lblOrderCountFromTurkiyeEfCore.Text = ordercountFromTurkiyeEf.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
