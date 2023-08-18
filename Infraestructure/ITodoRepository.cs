using TodoProject.Models;

namespace TodoProject.Infraestructure;

public interface ITodoRepository
{
    Task<List<Todo>> GetTodos();
    Task<Todo> GetTodoById(Guid Id);
    Task<Todo> CreateTodo(Todo todo);
    Task<Todo> UpdateTodo(Todo todo);
    Task DeleteTodo(Todo todo);
}