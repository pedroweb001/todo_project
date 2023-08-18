using TodoProject.Models;

namespace TodoProject.Application;

public interface ITodoServices
{
    Task<List<Todo>> GetTodos();
    Task<Todo> CreateTodo(Todo todo);
    Task<Todo> UpdateTodo(Todo todo);
    Task DeleteTodo(Todo todo);

}