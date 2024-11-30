using Fluxor;

namespace Kapa.Fluxor.Testing.Store.TodoUseCase;

public class TodoListEffects(IState<TodoListState> state)
{
    private readonly IState<TodoListState> _state = state;

    [EffectMethod]
    public async Task HandleCreateTodoListItemAction(CreateTodoListItemAction action, IDispatcher dispatcher)
    {
        await Task.CompletedTask;
        var newTodoItem = new TodoListItem(action.Title, action.Order)
        {
            Id = Guid.NewGuid(),
            Status = TodoListItemStatus.Todo
        };
        dispatcher.Dispatch(new CreateTodoListItemResultAction(newTodoItem));
    }
    
    [EffectMethod]
    public async Task HandleUpdateTodoListItemAction(UpdateTodoListItemAction action, IDispatcher dispatcher)
    {
        await Task.CompletedTask;
        var newItems = _state.Value.TodoListItems;
        var itemToUpdate = newItems.FirstOrDefault(item => item.Id == action.UpdatedItem.Id);
        newItems.Remove(itemToUpdate);
        newItems.Add(action.UpdatedItem);
        newItems = newItems.OrderBy(o => o.Order).ToList();
        
        dispatcher.Dispatch(new SetTodoListItemsAction(newItems));
    }
    
    [EffectMethod]
    public async Task HandleDeleteTodoListItemAction(DeleteTodoListItemAction action, IDispatcher dispatcher)
    {
        await Task.CompletedTask;
        var newItems = _state.Value.TodoListItems;
        var itemToDelete = newItems.First(item => item.Id == action.Id);
        foreach (var item in newItems.Where(i => i.Order > itemToDelete.Order))
        {
            item.Order--;
        }
        newItems.Remove(itemToDelete);
        
        dispatcher.Dispatch(new SetTodoListItemsAction(newItems));
    }
}