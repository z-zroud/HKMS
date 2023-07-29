using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKMS.DBModels
{
    public class MSDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\BookStoreContext.db;");
        }

        public DbSet<Epoch> Epochs { get; set; }
        public DbSet<TemaBets> TemaBets { get; set; }
        public DbSet<ZodiacBets> ZodiacBets { get; set; }
    }
}
