using CalcBlazor.Data;
using CalcBlazor.Database;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

namespace CalcBlazor
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRazorPages();
			builder.Services.AddServerSideBlazor();

			builder.Services.AddDbContext<CalculatorContext>(option =>
				option.UseSqlServer(builder.Configuration.GetConnectionString("calculatordb")));


			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
			}


			app.UseStaticFiles();

			app.UseRouting();

			app.MapBlazorHub();
			app.MapFallbackToPage("/_Host");

			app.Run();
		}
	}
}