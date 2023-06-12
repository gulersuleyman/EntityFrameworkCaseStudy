using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkCaseStudy
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		ProductDal _productDal = new ProductDal();
		private void Form1_Load(object sender, EventArgs e)
		{
			LoadProducts();
		}
		void LoadProducts()
		{
			grdProducts.DataSource = _productDal.GetAll();
		}
		void SearchProducts(string key)
		{
			//var result= _productDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower)).ToList();
			var result=_productDal.GetByName(key);
			grdProducts.DataSource = result; 
		}



		private void btnAdd_Click(object sender, EventArgs e)
		{
			_productDal.Add(new Product
			{
				Name = tbxName.Text,
				UnitPrice=Convert.ToDecimal(tbxUnitPrice.Text),
				StockAmount=(int)Convert.ToInt32(tbxStockAmount.Text)
			});
			LoadProducts();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			_productDal.Update(new Product
			{
				Id=(int)Convert.ToInt32(grdProducts.CurrentRow.Cells[0].Value),
				Name = tbxNameUpdate.Text,
				UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
				StockAmount = (int)Convert.ToInt32(tbxStockAmountUpdate.Text)
			});
			LoadProducts();
		}

		private void grdProducts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			tbxNameUpdate.Text = grdProducts.CurrentRow.Cells[1].Value.ToString();
			tbxUnitPriceUpdate.Text = grdProducts.CurrentRow.Cells[2].Value.ToString();
			tbxStockAmountUpdate.Text = grdProducts.CurrentRow.Cells[3].Value.ToString();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			_productDal.Delete(new Product
			{
				Id=(int)Convert.ToInt32(grdProducts.CurrentRow.Cells[0].Value)
			});
			LoadProducts();

		}

		private void tbxSearch_TextChanged(object sender, EventArgs e)
		{
			SearchProducts(tbxSearch.Text);
		}
	}
}
