using Microsoft.EntityFrameworkCore;
using Ordering.Domain.Models;

namespace Ordering.Infrastructure.Persistence
{
    public class OrderContextSeed
    {
        public static async Task Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order() 
                {
                    Id = 1,
                    UserName = "saikat@gmail.com",
                    FirstName = "Saikat",
                    LastName = "Rahman",
                    EmailAddress = "saikat@gmail.com",
                    Address = "Dhaka",
                    TotalPrice = 100,
                    City = "Dhaka"
                }
                );
        }
    }
}
