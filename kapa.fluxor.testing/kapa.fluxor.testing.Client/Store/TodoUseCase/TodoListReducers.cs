using Fluxor;
using Kapa.Fluxor.Testing.Client.Store.CounterUseCase;

namespace Kapa.Fluxor.Testing.Store.TodoUseCase;

public static class Reducers
{
    [ReducerMethod]
    public static TodoListState ReduceIncrementCounterAction(TodoListState state, CreateTodoListItemResultAction action)
    {
        var currentItems = state.TodoListItems;
        currentItems.Add(action.Item);
        return new TodoListState(currentItems);
    }
}