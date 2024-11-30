using Fluxor;

namespace Kapa.Fluxor.Testing.Store.TodoUseCase;

[FeatureState]
public class TodoListState
{
    public List<TodoListItem> TodoListItems { get; } = [];
    
    private TodoListState() {}

    public TodoListState(List<TodoListItem> todoListItems)
    {
        TodoListItems = todoListItems;
    }
}

public record TodoListItem(Guid Id, string Title, int Order, TodoListItemStatus IsCompleted);

public enum TodoListItemStatus
{
    Todo,
    InProgress,
    Done
}
