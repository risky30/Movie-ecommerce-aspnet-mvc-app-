using eTicketsProject.Data;
using eTicketsProject.Data.Services;
using eTicketsProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTicketsProject.Controllers
{
    public class ActorsController : Controller
    {
<<<<<<< HEAD
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
=======
        private readonly IActorsServices _service;
        public ActorsController(IActorsServices service)
>>>>>>> 2dc6d8cf8efa28acac0a3b7359a0c3f2cd596130
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        
        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio ")] Actor actor)
        {
            if (!ModelState.IsValid) return View(actor);
            await _service.AddAsync(actor);
<<<<<<< HEAD

            return RedirectToAction(nameof(Details), new { id = actor.Id });
=======
            
            return RedirectToAction(nameof(Index));
>>>>>>> 2dc6d8cf8efa28acac0a3b7359a0c3f2cd596130
        }

        //Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        //Get: Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
       
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio ")] Actor actor)
        {
            if (!ModelState.IsValid) return View(actor);
<<<<<<< HEAD
            if (id == actor.Id)
            {
                await _service.UpdateAsync(id, actor);
                return RedirectToAction(nameof(Details), new { id = actor.Id });
            }
            return View(actor);     
=======
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
>>>>>>> 2dc6d8cf8efa28acac0a3b7359a0c3f2cd596130
        }


        //Get: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);

        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
          
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
