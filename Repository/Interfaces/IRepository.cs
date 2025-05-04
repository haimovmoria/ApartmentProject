﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);

        T AddItem(T item);


        void DeleteItem(int id);
        void UpdateItem(int id ,T item);
    }
}
