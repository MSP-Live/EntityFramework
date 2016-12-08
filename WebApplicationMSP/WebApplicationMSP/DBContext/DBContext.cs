using System.Data.Entity;
using WebApplicationMSP.Entities;

namespace WebApplicationMSP.DBContext
{
    public class DBContext : DbContext
    {
        public DbSet<Log> LogsCollection { get; set; }
    }
}