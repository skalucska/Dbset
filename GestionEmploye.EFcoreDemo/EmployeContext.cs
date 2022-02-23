using GestionEmploye.Common;
using GestionEmploye.Common.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace GestionEmploye.EFcoreDemo
{
    public class EmployeContext : DbContext
    {
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= (local)\\MSSQLLocalDB; Initial Catalog=GestionEmploye")
                .LogTo(Console.WriteLine, new[] 
                { 
                    DbLoggerCategory.Database.Command.Name 
                }, LogLevel.Information)
                .EnableSensitiveDataLogging();
        }


    }

}
