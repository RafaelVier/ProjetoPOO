using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTodoApp.Data
{
    public interface ITodoRepository
    {
        Task<IEnumerable<TodoItem>> GetTodosAsync();
        Task<TodoItem> GetTodoByIdAsync(int id);
        Task AddTodoAsync(TodoItem todo);
        Task UpdateTodoAsync(TodoItem todo);
        Task DeleteTodoAsync(int id);
    }
}