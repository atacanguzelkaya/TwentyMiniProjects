using Project9_MongoDbOrder.Entities;
using Project9_MongoDbOrder.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project9_MongoDbOrder
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		OrderOperation orderOperation = new OrderOperation();

		private void btnCreate_Click(object sender, EventArgs e)
		{
			var order = new Order
			{
				CustomerName = txtCustomerName.Text,
				District = txtDistrict.Text,
				City = txtCity.Text,
				TotalPrice = decimal.Parse(txtTotalPrice.Text),
			};
			orderOperation.AddOrder(order);
			MessageBox.Show("Added Order");
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			List<Order> orderList = orderOperation.GetAllOrders();
			dataGridView1.DataSource = orderList;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string orderId = txtId.Text;
			orderOperation.DeleteOrder(orderId);
			MessageBox.Show("Deleted Order");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string id = txtId.Text;
			var updateOrder = new Order
			{
				City = txtCity.Text,
				CustomerName = txtCustomerName.Text,
				District = txtDistrict.Text,
				OrderId = id,
				TotalPrice = decimal.Parse(txtTotalPrice.Text),
			};
			orderOperation.UpdateOrder(updateOrder);
			MessageBox.Show("Updated Order");
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			string id = txtId.Text;
			Order orders = orderOperation.GetOrderById(id);
			dataGridView1.DataSource = new List<Order> { orders };
		}
	}
}