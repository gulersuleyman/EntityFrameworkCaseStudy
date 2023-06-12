using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCaseStudy
{
	public class ProductDal
	{
		public List<Product> GetAll()
		{
			using (BarDBContext context = new BarDBContext())
			{
				return  context.Products.ToList();
			}
			
		}
		public List<Product> GetByName(string key)
		{
			using (BarDBContext context = new BarDBContext())
			{
				return context.Products.Where(p=>p.Name.Contains(key)).ToList();
			}

		}


		//May be necessary!!!!!!!!!!!
		public List<Product> GetByUnitPrice(decimal price)
		{
			using (BarDBContext context = new BarDBContext())
			{
				return context.Products.Where(p => p.UnitPrice>=price).ToList();
			}

		}
		public List<Product> GetByUnitPrice(decimal min,decimal max)
		{
			using (BarDBContext context = new BarDBContext())
			{
				return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice<=max).ToList();
			}

		}
		public Product GetById(int id)
		{
			using (BarDBContext context = new BarDBContext())
			{
				//return context.Products.FirstOrDefault(p=>p.Id==id);
				return context.Products.SingleOrDefault(p => p.Id == id);
			}

		}
		public void Add(Product product)
		{
			using (BarDBContext context = new BarDBContext())
			{
				//context.Products.Add(product);
				var entity = context.Entry(product);
				entity.State = System.Data.Entity.EntityState.Added;
				context.SaveChanges();
			}

		}
		public void Update(Product product)
		{
			using (BarDBContext context = new BarDBContext())
			{
				
				var entity = context.Entry(product);
				entity.State = System.Data.Entity.EntityState.Modified;
				context.SaveChanges();
			}
		}
		public void Delete(Product product)
		{
			using (BarDBContext context = new BarDBContext())
			{

				var entity = context.Entry(product);
				entity.State = System.Data.Entity.EntityState.Deleted;
				context.SaveChanges();
			}
		}


	}
}
