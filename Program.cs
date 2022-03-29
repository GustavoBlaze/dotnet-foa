using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using banca.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
  public static void Main(string[] args)
  {
    var host = CreateHostBuilder(args).Build();
  }

  public static IHostBuilder CreateHostBuilder(string[] args)
  {

    return Host.CreateDefaultBuilder(args).ConfigureServices((hostContext, services) =>
      {
        String connectionString = "Server=localhost;DataBase=dotnet_pt1;Uid=root;Pwd=docker";
        MySqlServerVersion version = new MySqlServerVersion(new Version(5, 7, 35));

        services.AddDbContext<BancaContext>(options => options.UseMySql(connectionString, version));
      });
  }
}