using eTicketsProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicketsProject.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Home()
        {
            var allMovies = await _context.Movies.OrderBy(n => n.Name).ToListAsync();
            return View(allMovies);
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.OrderBy(n => n.Name).ToListAsync();
            return View(allMovies);
        }
        public async Task<IActionResult> Index2()
        {
            var allMovies = await _context.Movies.Include(n => n.Producer).OrderBy(n => n.Name).ToListAsync();
            return View(allMovies);
        }
    }
}
