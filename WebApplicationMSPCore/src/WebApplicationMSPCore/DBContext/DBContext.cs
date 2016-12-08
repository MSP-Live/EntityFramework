using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationMSPCore.Entities;

namespace WebApplicationMSPCore.DBContext
{
    public class DBContext : DbContext
    {
        public DbSet<Log> LogsCollection { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=aspnet-WebApplicationMSPCore;Integrated Security=True");
        }
    }
}
