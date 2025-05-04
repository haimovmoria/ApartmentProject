using Entity.Model;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Database : DbContext, IContext
    {
        public DbSet<Apartment> Apartments { get; set ; }
        public DbSet<owner> Owners { get ; set; }
        public DbSet<Custumer> Custumers { get ; set ; }
        public DbSet<toRand> ToRands { get ; set ; }

        public void save()
        {
           SaveChanges();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=sqlsrv;database=myApartmentDb;trusted_connection=true;TrustServerCertificate=true");
        }
    }
}
