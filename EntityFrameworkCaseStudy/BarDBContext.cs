﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCaseStudy
{
	public class BarDBContext:DbContext
	{
		public DbSet<Product> Products { get; set; }
	}
}
