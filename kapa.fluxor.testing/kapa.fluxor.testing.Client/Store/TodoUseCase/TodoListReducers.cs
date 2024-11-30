using Fluxor;
using Kapa.Fluxor.Testing.Client.Store.CounterUseCase;

namespace Kapa.Fluxor.Testing.Store.TodoUseCase;

public static class Reducers
{
    [ReducerMethod]
    public static TodoListState ReduceCreateTodoListItemAction(TodoListState state, CreateTodoListItemResultAction action)
    {
        var newItems = state.TodoListItems;
        newItems.Add(action.Item);
        return new TodoListState(newItems);
    }

    [ReducerMethod]
    public static TodoListState ReduceSetTodoListItemsAction(TodoListState state, SetTodoListItemsAction action)
        => new TodoListState(action.Items);
}