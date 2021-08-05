using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework
{
   public class BarkodYazıcıContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BarkodYazıcı;Trusted_Connection=True");

        }
        public DbSet<Makara> Makaralar { get; set; }
        public DbSet<Barkod> Barkodlar { get; set; }

    }
}
