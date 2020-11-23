using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Project.Entities;
using Microsoft.EntityFrameworkCore;


namespace Asp_Project.DataBase
{
	public class ExchangesDbContext : DbContext
	{
		public ExchangesDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<ItemEntity> Items { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{

		}
	}
}
