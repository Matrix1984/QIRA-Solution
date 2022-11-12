using ProjectExample.Application.TodoLists.Queries.ExportTodos;

namespace ProjectExample.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
