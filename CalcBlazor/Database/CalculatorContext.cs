using CalcBlazor.Model;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace CalcBlazor.Database
{
	public class CalculatorContext : DbContext
	{
		public DbSet<Operation> Operations { get; set; }
		public CalculatorContext()
		{
		}
		public CalculatorContext(DbContextOptions<CalculatorContext> options) : base(options)
		{
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = C:\\USERS\\4MATE\\SOURCE\\REPOS\\CALCBLAZOR\\DB\\CALCDATABASE.MDF; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");

		}
	}
}
