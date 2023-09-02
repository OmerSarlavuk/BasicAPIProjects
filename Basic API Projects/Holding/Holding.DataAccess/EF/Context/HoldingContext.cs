using Holding.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holding.DataAccess.EF.Context
{
    public class HoldingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=Holding;Integrated Security=true ; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Student>Students { get; set; }
    }
}
