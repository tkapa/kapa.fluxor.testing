namespace Kapa.Fluxor.Testing.Store.TodoUseCase;

public record CreateTodoListItemAction(string Title, int Order);

public record CreateTodoListItemResultAction(TodoListItem Item);