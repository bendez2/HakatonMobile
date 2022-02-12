using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Xamarin.Essentials;

namespace App6
{
    internal class ApplicationContext : DbContext
    {
        private string _databasePath { get; }
        public DbSet<User> Users { get; set; }

        public ApplicationContext()
        {
            

            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=s.anosov.ru;user=OrlovA;password=pEEwT@7#;database=OrlovA;"
            );
        }
    }
}
