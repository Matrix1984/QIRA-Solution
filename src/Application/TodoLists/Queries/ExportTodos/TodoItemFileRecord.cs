using ProjectExample.Application.Common.Mappings;
using ProjectExample.Domain.Entities;

namespace ProjectExample.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
