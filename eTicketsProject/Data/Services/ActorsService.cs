using eTicketsProject.Data.Base;
using eTicketsProject.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicketsProject.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
