using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jey.Domain.Interfaces
{
    public interface IRepository<T>
    {
        public T GetById(ulong id);

        public List<T> GetAll();

        public void Save(T obj);
    }
}