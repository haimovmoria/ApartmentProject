using Entity.Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Reposetories
{
    public class CustomerReposetory :IRepository<Custumer>
    {

       private readonly IContext context;

        public CustomerReposetory(IContext context)
        {
            this.context = context;
        }
        public Custumer AddItem(Custumer item)
        {
           context.Custumers.Add(item);
            context.save();
            return item;
        }

        public void DeleteItem(int id)
        {
            context.Custumers.Remove(id);
            context.save();
        }

        public List<Custumer> GetAll()
        {
            return context.Custumer;

        }

        public Custumer GetById(int id)
        {
            return context.Custumers.FirstOrDefault(x=> x.id == id);
        }

        public void UpdateItem(int id, Custumer item)
        {
           var customer=GetById(id);
            context.save();
        }
    }
}
