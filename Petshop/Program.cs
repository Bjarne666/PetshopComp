using Microsoft.Extensions.DependencyInjection;
using Petshop;
using Petshop.Core.Appservice;
using Petshop.Core.Appservice.IMPL;
using Petshop.Core.Domainservice;
using Petshop.Infrastructure.Static.Data;
using Petshop.Infrastructure.Static.Data.Repository;

namespace PetshopComp
{
  public class Program
    {
        private static void Main()
            {

                var serviceCollection = new ServiceCollection();
                serviceCollection.AddScoped<IPetRepository, PetRepository>();
                serviceCollection.AddScoped<IPetService, PetService>();
                serviceCollection.AddScoped<IPrinter, Printer>();

                

                //then build provider 
                var serviceProvider = serviceCollection.BuildServiceProvider();
                var printer = serviceProvider.GetRequiredService<IPrinter>();

                FakeDb.InitData();
                printer.BeginUI();
            }
        }
    }
