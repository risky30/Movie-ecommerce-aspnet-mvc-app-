using eTicketsProject.Models;

namespace eTicketsProject.Data.Base
{
    public interface IEntityBaseRepository<T> where T: class, IEntityBase, new()
<<<<<<< HEAD
    {  
=======
    {
   
>>>>>>> 2dc6d8cf8efa28acac0a3b7359a0c3f2cd596130
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task AddAsync(T entity);

<<<<<<< HEAD
        Task UpdateAsync(int id, T entity);
=======
        Task<T> UpdateAsync(int id, T entity);
>>>>>>> 2dc6d8cf8efa28acac0a3b7359a0c3f2cd596130

        Task DeleteAsync(int id);
    }
}
