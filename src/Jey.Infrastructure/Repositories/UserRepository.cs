using Jey.Domain;
using Jey.Domain.Interfaces;
using Jey.Domain.Models;
using Jey.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jey.Infrastructure.Repositories
{
    public class UserRepository : IRepository<User> 
    {
        private readonly JeyContext _context;

        public UserRepository(JeyContext context)
        {
            _context = context;
        }

        public async Task Create(User user)
        {
            await _context.User.AddAsync(user);

            await _context.SaveChangesAsync();
        }


        public async Task<User>? GetById(ulong id)
        {
            try
            {
                var user = _context.User.Where(x => x.Id == id).FirstOrDefaultAsync().Result;

                return user;
            }

            catch (Exception)
            {

                throw;
            }
        }
    }
}