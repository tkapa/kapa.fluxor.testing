using Fluxor;

namespace Kapa.Fluxor.Testing.Store.TodoUseCase;

public class TodoListEffects
{
    [EffectMethod]
    public async Task HandleCreateTodoListItemAction(CreateTodoListItemAction action, IDispatcher dispatcher)
    {
        await Task.CompletedTask;
        var newTodoItem = new TodoListItem(Guid.NewGuid(), action.Title, action.Order, TodoListItemStatus.Todo);
        dispatcher.Dispatch(new CreateTodoListItemResultAction(newTodoItem));
    }
}