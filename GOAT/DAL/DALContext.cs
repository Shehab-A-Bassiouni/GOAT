using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;
using DAL.Models;

namespace DAL
{
    public class DALContext :DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DALContext() { } 
        public DALContext(DbContextOptions<DALContext> options) :base(options)
        {
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DALConnStr"].ConnectionString);
            }
        }
    }
}
