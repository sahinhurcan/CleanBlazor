using CleanBlazor.WebUI.Shared.TodoLists;

namespace CleanBlazor.Application.TodoLists;

public class Mapping : Profile
{
    public Mapping()
    {
        CreateMap<TodoList, TodoListDto>();
        CreateMap<TodoItem, TodoItemDto>();
    }
}
