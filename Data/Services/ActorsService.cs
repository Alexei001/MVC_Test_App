using Microsoft.EntityFrameworkCore;
using MVC_Test_App.Models;
using MVC_Test_App.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Test_App.Data.Services
{
    public class ActorsService : IActorsService
    {
        protected readonly ApplicationContext _context;

        public ActorsService(ApplicationContext context)
        {
            this._context = context;
        }
        public void Add(Actor actor)
        {
            
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public Actor GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int Id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
