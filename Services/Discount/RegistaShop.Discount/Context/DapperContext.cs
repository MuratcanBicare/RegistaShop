using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RegistaShop.Discount.Entities;
using System.Data;

namespace RegistaShop.Discount.Context
{
	public class DapperContext : DbContext
	{

		private readonly IConfiguration _configuration;
		private readonly string _connectionString;

		public DapperContext(IConfiguration configuration)
		{

			_configuration = configuration;
			_connectionString = _configuration.GetConnectionString("DefaultConnection");

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

			optionsBuilder.UseSqlServer("Server=DESKTOP-6S0PONQ;initial Catalog=RegistaShopDiscountDb;integrated Security=true");

		}

		public DbSet<Coupon> Coupons { get; set; }
		public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
	}
}
