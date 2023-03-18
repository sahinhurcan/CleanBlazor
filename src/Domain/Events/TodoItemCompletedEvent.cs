using CleanBlazor.Domain.Common;
using CleanBlazor.Domain.Entities;

namespace CleanBlazor.Domain.Events;

public class TodoItemCompletedEvent : BaseEvent
{
    public TodoItemCompletedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
