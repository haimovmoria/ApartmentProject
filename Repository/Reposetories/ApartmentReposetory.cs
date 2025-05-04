using Entity.Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Reposetories
{
    public class ApartmentReposetory : IRepository<Apartment>
    {

        private readonly IContext context;
        public ApartmentReposetory(IContext context)
        {
            this.context = context;
        }
        public Apartment AddItem(Apartment item)
        {
            context.Apartment.Add(item);
            context.save();
            return item;
        }

        public void DeleteItem(int id)
        {
            context.Apartment.Remove(id);
            context.save();
        }

        public List<Apartment> GetAll()
        {
            return context.Apartment;

        }

        public Apartment GetById(int id)
        {
            return context.Apartment.FirstOrDefault(x => x.id == id);
        }
        public void UpdateItem(int id, Apartment item)
        {
            var Apartment = GetById(id);
            Apartment.roomNum = item.roomNum;
            Apartment.flor = item.flor;
            Apartment.side = item.side;
            Apartment.view = item.view;
            Apartment.porch = item.porch;
            Apartment.status = item.status;
            Apartment.Shetach = item.Shetach; 
            



        }
    }
}
