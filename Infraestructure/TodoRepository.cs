using TodoProject.Data;
using TodoProject.Models;

namespace TodoProject.Infraestructure;

public class TodoRepository : ITodoRepository
{
    private readonly TodoContext _Context;

    public TodoRepository(TodoContext context)
    {
        _Context = context;
    }

    public Task<List<Todo>> GetTodos()
    {
        throw new NotImplementedException();
    }

    public Task<Todo> GetTodoById(Guid Id)
    {
        throw new NotImplementedException();
    }

    public async Task<Todo> CreateTodo(Todo todo)
    {
        _Context.Todos.Add(todo);
        await _Context.SaveChangesAsync();
        return await _Context.Todos.FindAsync(todo.Id);
    }

    public Task DeleteTodo(Todo todo)
    {
        throw new NotImplementedException();
    }

    public Task<Todo> UpdateTodo(Todo todo)
    {
        throw new NotImplementedException();
    }
}