namespace Kapa.Fluxor.Testing.Store.TodoUseCase;

public record SetTodoListItemsAction(List<TodoListItem> Items);

public record CreateTodoListItemAction(string Title, int Order);
public record CreateTodoListItemResultAction(TodoListItem Item);

public record UpdateTodoListItemAction(TodoListItem UpdatedItem);
public record UpdateTodoListItemResultAction(List<TodoListItem> Items);

public record DeleteTodoListItemAction(Guid Id);
public record DeleteTodoListItemResultAction(List<TodoListItem> Items);