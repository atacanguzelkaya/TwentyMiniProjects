using System;
using System.Linq;

namespace Project11_TriggerOrderStock
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Db11Project20Entities context = new Db11Project20Entities();

			string number;
			Console.WriteLine("#### Order Stock System #### \n");
			Console.WriteLine("1 - Product List");
			Console.WriteLine("2 - Order List");
			Console.WriteLine("3 - Cash Status");
			Console.WriteLine("4 - New Product Sales");
			Console.WriteLine("5 - Transaction Counter");
			Console.WriteLine("\n------------------------- \n");

			Console.Write("Please select the operation you want to process: ");
			number = Console.ReadLine();

			if (number == "1")
			{
				Console.WriteLine("---- Product List ----");

				var values = context.TblProduct.ToList();
				foreach (var item in values)
				{
					Console.WriteLine(item.ProductId + "-" + item.ProductName + " Stok: " + item.ProductStock + " Price:" + item.ProductPrice + " TRY");
				}
			}

			if (number == "2")
			{
				Console.WriteLine("---- Order List ----");

				var values = context.TblOrder.ToList();
				foreach (var item in values)
				{
					Console.WriteLine(item.OrderId + "-" + item.TblProduct.ProductName + " Unit Price: " + item.UnitPrice + " Quantity:" + item.Quantity + " Total Price: " + item.TotalPrice);
				}
			}
			if (number == "3")
			{
				Console.WriteLine("---- Cash Status ----");

				var values = context.TblCashRegister.Select(x => x.Balance).FirstOrDefault();
				Console.Write("Total Amount in Cash: " + values + " TRY");
			}
			if (number == "4")
			{
				Console.WriteLine("---- New Product Sales ----");

				Console.Write("Customer Name: ");
				string customer = Console.ReadLine();

				Console.Write("Product Id: ");
				int productId = int.Parse(Console.ReadLine());

				Console.Write("Quantity: ");
				int quantity = int.Parse(Console.ReadLine());

				Console.WriteLine("\n ---- Product Information ---- \n");

				var productName = context.TblProduct.Where(x => x.ProductId == productId).Select(y => y.ProductName).FirstOrDefault();
				Console.WriteLine("Product Name: " + productName);

				var productUnitPrice = context.TblProduct.Where(x => x.ProductId == productId).Select(y => y.ProductPrice).FirstOrDefault();
				Console.WriteLine("Unit Price: " + productUnitPrice);

				decimal totalPrice = quantity * decimal.Parse(productUnitPrice.ToString());
				Console.WriteLine("Total Price: " + totalPrice);

				Console.WriteLine("\n ---- Product Information ---- \n");

				TblOrder tblOrder = new TblOrder();
				tblOrder.Customer = customer;
				tblOrder.ProductId = productId;
				tblOrder.Quantity = quantity;
				tblOrder.UnitPrice = productUnitPrice;
				tblOrder.TotalPrice = totalPrice;

				context.TblOrder.Add(tblOrder);
				context.SaveChanges();
			}
			if (number == "5")
			{
				var value = context.TblProcess.Select(x => x.Process).FirstOrDefault();
				Console.WriteLine("Total Process Count: " + value);
			}
			Console.Read();
		}
	}
}
