using eTicketsProject.Data.Base;
using eTicketsProject.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicketsProject.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context) { }
    }
}
