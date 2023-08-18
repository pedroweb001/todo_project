using TodoProject.Infraestructure;
using TodoProject.Models;

namespace TodoProject.Application;

public class TodoService : ITodoServices
{
    private readonly ITodoRepository _repository;

    public TodoService(ITodoRepository repository)
    {
        _repository = repository;
    }

    public Task<List<Todo>> GetTodos()
    {
        return _repository.GetTodos();
    }

    public Task<Todo> CreateTodo(Todo todo)
    {
        todo.Id = Guid.NewGuid();
        return _repository.CreateTodo(todo);
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