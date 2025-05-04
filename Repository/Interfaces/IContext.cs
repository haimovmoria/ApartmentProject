using Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IContext
    {
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<owner> Owners { get; set; }
        public DbSet<Custumer> Custumers  { get; set; }
        public DbSet<toRand> ToRands { get; set; }

        public void save();
    }
}
