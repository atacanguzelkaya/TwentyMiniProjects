using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_EntityFrameworkDBFirstProduct
{
	public partial class FrmMap : Form
	{
		public FrmMap()
		{
			InitializeComponent();
		}

		private void btnOpenCategoryForm_Click(object sender, EventArgs e)
		{
			FrmCategory frmCategory = new FrmCategory();
			frmCategory.Show();
		}

		private void btnOpenProductForm_Click(object sender, EventArgs e)
		{
			FrmProduct frmProduct = new FrmProduct();
			frmProduct.Show();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}