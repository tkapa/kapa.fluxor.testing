using Fluxor;
using Fluxor.Blazor.Web.Components;
using Kapa.Fluxor.Testing.Store.TodoUseCase;
using Microsoft.AspNetCore.Components;

namespace Kapa.Fluxor.Testing.Client.Pages;

public partial class TodoList : FluxorComponent 
{
    [Inject] public required IState<TodoListState> TodoListState { get; set; }
    [Inject] public required IDispatcher Dispatcher { get; set; }
    
    private void AddTodo(string todoName) =>
        Dispatcher.Dispatch(new CreateTodoListItemAction(todoName, TodoListState.Value.TodoListItems.Count + 1));
}