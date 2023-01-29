using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jey.Domain
{
    public interface IRepository<T>
    {
        public T GetById(int id);

        public IEnumerable<T> GetAll();

        public void Save(T entity);
    }
}