using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp4.EF.Entities;

namespace Tp4.EF.Logic
{
    interface ILogic<T>{
        List<T> GetAll();
        void Add(T newLogic);
        void Delete(int id);
        void Update(T logic);
    }
}
