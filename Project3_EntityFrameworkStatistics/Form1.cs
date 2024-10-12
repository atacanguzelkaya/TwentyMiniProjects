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

		DbEntities db = new DbEntities();
		private void Form1_Load(object sender, EventArgs e)
		{
			//Category Count
			int categoryCount = db.TblCategory.Count();
			lblCategoryCount.Text = categoryCount.ToString();

			//Product Count
			int productCount = db.TblProduct.Count();
			lblProductCount.Text = productCount.ToString();

			//Customer Count
			int customerCount = db.TblCustomer.Count();
			lblCustomerCount.Text = customerCount.ToString();

			//Order Count
			int orderCount = db.TblOrder.Count();
			lblOrderCount.Text = orderCount.ToString();

			//Total Product Stock Count
			var totalProductStockCount = db.TblProduct.Sum(x=> x.ProductStock);
			lblTotalProductStockCount.Text = totalProductStockCount.ToString();

			//Average Product Price
			var averageProductPrice = db.TblProduct.Average(x => x.ProductPrice);
			lblAverageProductPrice.Text = averageProductPrice.ToString() + " ₺";
			//Total Product Stock By Categories Fruit
			var totalProductStockByCategoriesFruit = db.TblProduct.Where(x => x.CategoryId ==1).Sum(x => x.ProductStock);
			lblTotalProductStockByCategoriesFruit.Text = totalProductStockByCategoriesFruit.ToString();

			//Tota lPrice By Product Name Is Gazoz
			var totalPriceByProductNameIsGazozGetStock = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(y => y.ProductStock).FirstOrDefault();
			var totalPriceByProductNameIsGazozGetPrice = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(y => y.ProductPrice).FirstOrDefault();
			var totalPriceByProductNameIsGazoz = totalPriceByProductNameIsGazozGetStock * totalPriceByProductNameIsGazozGetPrice;
			lblTotalPriceByProductNameIsGazoz.Text = totalPriceByProductNameIsGazoz.ToString() + " ₺";

			//Product Count By Stock Count Smaller Then 100
			var productCountByStockCountSmallerThen100 = db.TblProduct.Where(x => x.ProductStock <100).Count();
			lblProductCountByStockCountSmallerThen100.Text = productCountByStockCountSmallerThen100.ToString();

			//Product Stock Count By Category Vegetable And Status True
			var productStockCountByCategoryNameIsVegetableAndStatusTrue = db.TblProduct.
				Where(x => x.CategoryId == (db.TblCategory.Where(c => c.CategoryName == "Sebze").
				Select(ca => ca.CategoryId).FirstOrDefault()) && x.ProductStatus == true).Sum(y=>y.ProductStock);
			lblProductStockCountByCategoryVegetableAndStatusTrue.Text = productStockCountByCategoryNameIsVegetableAndStatusTrue.ToString();

			//Order Count From Turkiye SQL Query
			var orderCountFromTurkiye = db.Database.SqlQuery<int>("Select count(*) From TblOrder Where CustomerId In (Select CustomerId From TblCustomer Where CustomerCountry='Türkiye')").FirstOrDefault();
			lblOrderCountFromTurkiyeBySQL.Text = orderCountFromTurkiye.ToString();

			//Order Count From Turkiye EF method
			var turkishCustomerIds = db.TblCustomer.Where(x => x.CustomerCountry == "Türkiye")
												 .Select(y => y.CustomerId)
												 .ToList();
			var orderCountFromTurkiyeWithEf = db.TblOrder.Count(z => turkishCustomerIds.Contains(z.CustomerId.Value));
			lblOrderCountFromTurkiyeByEf.Text = orderCountFromTurkiyeWithEf.ToString();

			//Total sales price of products with fruit category in orders SQL query
			var orderTotalPriceByCategoriesFruit = db.Database.SqlQuery<decimal>("Select Sum(o.TotalPrice) From TblOrder o Join TblProduct p On o.ProductId=p.ProductId Join TblCategory c On p.CategoryId=c.CategoryId Where c.CategoryName='Meyve'").FirstOrDefault();
			lblOrderTotalPriceByCategoriesFruit.Text = orderTotalPriceByCategoriesFruit.ToString() + "₺";

			//Total sales price of products with fruit category in orders Entity Framework Method
			var orderTotalPriceByCategoriesFruitWithEf = (from o in db.TblOrder
														  join p in db.TblProduct on o.ProductId equals p.ProductId
														  join c in db.TblCategory on p.CategoryId equals c.CategoryId
														  where c.CategoryName == "Meyve"
														  select o.TotalPrice).Sum();
			lblOrderTotalPriceByCategoriesFruitByEf.Text = orderTotalPriceByCategoriesFruitWithEf.ToString() + "₺";

			//Name of the last added product
			var lastProductName = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.ProductName).FirstOrDefault();
			lblLastProductName.Text = lastProductName.ToString();

			//Category name of the last added product
			var lastProductCategoryId = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.CategoryId).FirstOrDefault();
			var lastProductCategoryName = db.TblCategory.Where(x => x.CategoryId == lastProductCategoryId).Select(y => y.CategoryName).FirstOrDefault();
			lblLastProductCategoryName.Text = lastProductCategoryName.ToString();

			//Active Product Count
			var activeProductCount = db.TblProduct.Where(x => x.ProductStatus == true).Count();
			lblActiveProductCount.Text = activeProductCount.ToString();

			//Total Money Earned from Cola Stock Sales
			var colaStock = db.TblProduct.Where(x => x.ProductName == "Kola").Select(y => y.ProductStock).FirstOrDefault();
			var colaPrice = db.TblProduct.Where(x => x.ProductName == "Kola").Select(y => y.ProductPrice).FirstOrDefault();
			var totalColaStockPrice = colaStock * colaPrice;
			lblTotalPriceWithStockByCola.Text = totalColaStockPrice + "₺";

			//Last ordering customer name
			var lastCustomerId = db.TblOrder.OrderByDescending(x => x.OrderId).Select(y => y.CustomerId).FirstOrDefault();
			var lastCustomerName = db.TblCustomer.Where(x => x.CustomerId == lastCustomerId).Select(y => y.CustomerName).FirstOrDefault();
			lblLastCustomerName.Text = lastCustomerName.ToString();

			//Number of country diversity
			var countryDifferentCount = db.TblCustomer.Select(x => x.CustomerCountry).Distinct().Count();
			lblCountryDifferentCount.Text = countryDifferentCount.ToString();
		}
	}
}
