using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Administration.Models
{
    public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Joe Cravens",
                    Department = Dept.IT,
                    Email = "joe.cravens@programmer.net"

                },
                new Employee
                {
                    Id = 2,
                    Name = "Felicia",
                    Department = Dept.HR,
                    Email = "felicia@foo.bar"
                }

                );

        }
    }
}
