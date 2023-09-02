using HotelFinder.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess
{
    public class HotelFinderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=true ; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
