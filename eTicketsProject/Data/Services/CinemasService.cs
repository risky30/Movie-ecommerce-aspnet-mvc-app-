using eTicketsProject.Data.Base;
using eTicketsProject.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicketsProject.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context) { }
    }
}
