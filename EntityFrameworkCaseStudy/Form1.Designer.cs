namespace EntityFrameworkCaseStudy
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grdProducts = new System.Windows.Forms.DataGridView();
			this.grbAdd = new System.Windows.Forms.GroupBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.tbxStockAmount = new System.Windows.Forms.TextBox();
			this.lblStockAmount = new System.Windows.Forms.Label();
			this.tbxUnitPrice = new System.Windows.Forms.TextBox();
			this.lblUnitPrice = new System.Windows.Forms.Label();
			this.tbxName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxNameUpdate = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnRemove = new System.Windows.Forms.Button();
			this.lblSearch = new System.Windows.Forms.Label();
			this.tbxSearch = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
			this.grbAdd.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grdProducts
			// 
			this.grdProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdProducts.Location = new System.Drawing.Point(42, 41);
			this.grdProducts.Name = "grdProducts";
			this.grdProducts.Size = new System.Drawing.Size(592, 126);
			this.grdProducts.TabIndex = 0;
			this.grdProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducts_CellClick);
			// 
			// grbAdd
			// 
			this.grbAdd.Controls.Add(this.btnAdd);
			this.grbAdd.Controls.Add(this.tbxStockAmount);
			this.grbAdd.Controls.Add(this.lblStockAmount);
			this.grbAdd.Controls.Add(this.tbxUnitPrice);
			this.grbAdd.Controls.Add(this.lblUnitPrice);
			this.grbAdd.Controls.Add(this.tbxName);
			this.grbAdd.Controls.Add(this.lblName);
			this.grbAdd.Location = new System.Drawing.Point(42, 192);
			this.grbAdd.Name = "grbAdd";
			this.grbAdd.Size = new System.Drawing.Size(274, 160);
			this.grbAdd.TabIndex = 1;
			this.grbAdd.TabStop = false;
			this.grbAdd.Text = "Add a Product";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(193, 130);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 24);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// tbxStockAmount
			// 
			this.tbxStockAmount.Location = new System.Drawing.Point(103, 102);
			this.tbxStockAmount.Name = "tbxStockAmount";
			this.tbxStockAmount.Size = new System.Drawing.Size(128, 20);
			this.tbxStockAmount.TabIndex = 5;
			// 
			// lblStockAmount
			// 
			this.lblStockAmount.AutoSize = true;
			this.lblStockAmount.Location = new System.Drawing.Point(32, 105);
			this.lblStockAmount.Name = "lblStockAmount";
			this.lblStockAmount.Size = new System.Drawing.Size(71, 13);
			this.lblStockAmount.TabIndex = 4;
			this.lblStockAmount.Text = "StockAmount";
			// 
			// tbxUnitPrice
			// 
			this.tbxUnitPrice.Location = new System.Drawing.Point(103, 62);
			this.tbxUnitPrice.Name = "tbxUnitPrice";
			this.tbxUnitPrice.Size = new System.Drawing.Size(128, 20);
			this.tbxUnitPrice.TabIndex = 3;
			// 
			// lblUnitPrice
			// 
			this.lblUnitPrice.AutoSize = true;
			this.lblUnitPrice.Location = new System.Drawing.Point(32, 65);
			this.lblUnitPrice.Name = "lblUnitPrice";
			this.lblUnitPrice.Size = new System.Drawing.Size(50, 13);
			this.lblUnitPrice.TabIndex = 2;
			this.lblUnitPrice.Text = "UnitPrice";
			// 
			// tbxName
			// 
			this.tbxName.Location = new System.Drawing.Point(103, 29);
			this.tbxName.Name = "tbxName";
			this.tbxName.Size = new System.Drawing.Size(128, 20);
			this.tbxName.TabIndex = 1;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(32, 32);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnUpdate);
			this.groupBox1.Controls.Add(this.tbxStockAmountUpdate);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tbxUnitPriceUpdate);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbxNameUpdate);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(360, 192);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(274, 160);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add a Product";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(193, 130);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 24);
			this.btnUpdate.TabIndex = 6;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// tbxStockAmountUpdate
			// 
			this.tbxStockAmountUpdate.Location = new System.Drawing.Point(103, 102);
			this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
			this.tbxStockAmountUpdate.Size = new System.Drawing.Size(128, 20);
			this.tbxStockAmountUpdate.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "StockAmount";
			// 
			// tbxUnitPriceUpdate
			// 
			this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(103, 62);
			this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
			this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(128, 20);
			this.tbxUnitPriceUpdate.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "UnitPrice";
			// 
			// tbxNameUpdate
			// 
			this.tbxNameUpdate.Location = new System.Drawing.Point(103, 29);
			this.tbxNameUpdate.Name = "tbxNameUpdate";
			this.tbxNameUpdate.Size = new System.Drawing.Size(128, 20);
			this.tbxNameUpdate.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Name";
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(632, 13);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(94, 23);
			this.btnRemove.TabIndex = 3;
			this.btnRemove.Text = "Delete";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Location = new System.Drawing.Point(190, 13);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(41, 13);
			this.lblSearch.TabIndex = 4;
			this.lblSearch.Text = "Search";
			// 
			// tbxSearch
			// 
			this.tbxSearch.Location = new System.Drawing.Point(237, 10);
			this.tbxSearch.Name = "tbxSearch";
			this.tbxSearch.Size = new System.Drawing.Size(127, 20);
			this.tbxSearch.TabIndex = 5;
			this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(732, 349);
			this.Controls.Add(this.tbxSearch);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grbAdd);
			this.Controls.Add(this.grdProducts);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
			this.grbAdd.ResumeLayout(false);
			this.grbAdd.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView grdProducts;
		private System.Windows.Forms.GroupBox grbAdd;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox tbxStockAmount;
		private System.Windows.Forms.Label lblStockAmount;
		private System.Windows.Forms.TextBox tbxUnitPrice;
		private System.Windows.Forms.Label lblUnitPrice;
		private System.Windows.Forms.TextBox tbxName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox tbxStockAmountUpdate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxNameUpdate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.TextBox tbxSearch;
	}
}