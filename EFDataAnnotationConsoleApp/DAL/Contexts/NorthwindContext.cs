using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDataAnnotationConsoleApp.DAL.Entities;

namespace EFDataAnnotationConsoleApp.DAL.Contexts
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base(ConfigurationManager.ConnectionStrings["EntityFrameworkWinFormApp.Properties.Settings.EFDBTestConnectionString"].ConnectionString)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
