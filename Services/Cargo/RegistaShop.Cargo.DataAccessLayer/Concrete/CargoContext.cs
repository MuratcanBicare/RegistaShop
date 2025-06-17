﻿using Microsoft.EntityFrameworkCore;
using RegistaShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.Cargo.DataAccessLayer.Concrete
{
	public class CargoContext : DbContext
	{

		override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost,1441;initial Catalog=RegistaShopCargoDB;User=sa;Password=123456aA*;");
		}

		public DbSet<CargoCompany> CargoCompanies { get; set; }
		public DbSet<CargoDetail> CargoDetails { get; set; }
		public DbSet<CargoCustomer> CargoCustomers { get; set; }
		public DbSet<CargoOperation> CargoOperations { get; set; }

	}
}
