﻿using Microsoft.EntityFrameworkCore;
using RegistaShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.Order.Persistence.Context
{
	public  class OrderContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

			optionsBuilder.UseSqlServer("Server=localhost,1440;initial Catalog=RegistaShopOrderDb;User=sa;Password=123456aA*");

		}

		public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Ordering> Orderings { get; set; }
    }
}
