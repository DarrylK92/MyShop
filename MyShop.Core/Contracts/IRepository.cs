using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop.Core.Models;

namespace MyShop.Core.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Commit();
        void Insert(T t);
        void Update(T t);
        T Find(string Id);
        IQueryable<T> Collection();
        void Delete(string Id);
    }
}
