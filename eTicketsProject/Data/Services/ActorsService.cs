<<<<<<< HEAD
﻿using eTicketsProject.Data.Base;
using eTicketsProject.Models;
=======
﻿using eTicketsProject.Models;
>>>>>>> 2dc6d8cf8efa28acac0a3b7359a0c3f2cd596130
using Microsoft.EntityFrameworkCore;

namespace eTicketsProject.Data.Services
{
<<<<<<< HEAD
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
=======
    public class ActorsService : IActorsServices
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Actor actor)
        {
           await _context.Actors.AddAsync(actor);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result =await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
>>>>>>> 2dc6d8cf8efa28acac0a3b7359a0c3f2cd596130
    }
}
