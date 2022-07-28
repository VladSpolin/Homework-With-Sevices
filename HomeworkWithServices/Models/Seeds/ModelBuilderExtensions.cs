using HomeworkWithServices.Models.DataBaseModels;
using Microsoft.EntityFrameworkCore;
namespace HomeworkWithServices.Models.Seeds
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(new Company { Id = 1, Name = "BrusHouse", Adress = "Minsk, Belarus" });
            modelBuilder.Entity<Worker>().HasData(new Worker[]
            {
                new Worker{Id=1, Name="Alex", Position="Manager", Number=29231111, CompanyId=1},
                new Worker{Id=2, Name="John", Position="Engineer", Number=29781311, CompanyId=1},
                new Worker{Id=3, Name="Mary", Position="Programmer", Number=334467234, CompanyId=1},
                new Worker{Id=4, Name="Kate", Position="Sales Manager", Number=29231261, CompanyId=1},
                new Worker{Id=5, Name="Bob", Position="Boss", Number=29231641, CompanyId=1},
            });
        }
    }
}
