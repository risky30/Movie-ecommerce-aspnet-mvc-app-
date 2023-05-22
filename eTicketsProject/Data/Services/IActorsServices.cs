using eTicketsProject.Models;

namespace eTicketsProject.Data.Services
{
    public interface IActorsServices
    {
        //get all the Actor from the database
        Task<IEnumerable<Actor>> GetAllAsync();

        //to return a single actor
        Task<Actor> GetByIdAsync(int id);

        //To add data to the database; we are not going to return any data to the user
        Task AddAsync(Actor actor);

        //the functionality to update data in the database
        Task<Actor> UpdateAsync(int id, Actor newActor);

        //delete data
        Task DeleteAsync(int id);
    }
}
