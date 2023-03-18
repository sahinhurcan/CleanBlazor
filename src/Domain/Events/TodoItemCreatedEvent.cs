using CleanBlazor.Domain.Common;
using CleanBlazor.Domain.Entities;

namespace CleanBlazor.Domain.Events;

public class TodoItemCreatedEvent : BaseEvent
{
    public TodoItemCreatedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
