using Fluxor;
using Kapa.Fluxor.Testing.Store.TodoUseCase;
using Microsoft.AspNetCore.Components;

namespace Kapa.Fluxor.Testing.Client.Components.TodoList;

public partial class TodoListItemDisplay : ComponentBase
{
    [Parameter, EditorRequired] public TodoListItem Item { get; set; }
    [Inject] public required IDispatcher Dispatcher { get; set; }

    private void UpdateItemStatus()
    {
        if (Item.Status == TodoListItemStatus.Done)
        {
            Dispatcher.Dispatch(new DeleteTodoListItemAction(Item.Id));
            return;
        }

        var updatedItem = new TodoListItem(Item.Title, Item.Order)
        {
            Id = Item.Id,
            Status = Item.Status + 1,
        };
        
        Dispatcher.Dispatch(new UpdateTodoListItemAction(updatedItem));
    }
}