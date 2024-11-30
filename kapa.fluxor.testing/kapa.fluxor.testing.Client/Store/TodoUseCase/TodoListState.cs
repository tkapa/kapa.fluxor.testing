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

public class TodoListItem(string title, int order)
{
    public string Title { get; set; } = title;
    public int Order { get; set; } = order;
    
    public Guid Id { get; set; }
    public TodoListItemStatus Status { get; set; }
};

public enum TodoListItemStatus
{
    Todo = 1,
    InProgress = 2,
    Done = 3
}
