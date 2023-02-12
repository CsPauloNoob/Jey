using Jey.Domain;
using Jey.Domain.Interfaces;
using Jey.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jey.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : Commons
    {
        protected readonly JeyContext _context;

        public Repository(JeyContext context)
        {
            _context = context;
        }

        public virtual T GetById(ulong id)
        {
            var obj = _context.Set<T>().SingleOrDefault(x => x.Id == id);

            return obj;
        }


        public virtual List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }


        public virtual void Save(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChangesAsync();
        }
    }
}