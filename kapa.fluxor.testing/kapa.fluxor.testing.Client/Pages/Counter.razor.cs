using Fluxor;
using Fluxor.Blazor.Web.Components;
using Kapa.Fluxor.Testing.Client.Store.CounterUseCase;
using Kapa.Fluxor.Testing.Store;
using Microsoft.AspNetCore.Components;

namespace Kapa.Fluxor.Testing.Client.Pages;

public partial class Counter : FluxorComponent
{
    [Inject] public required IState<CounterState> CounterState { get; set; }
    [Inject] public required IDispatcher Dispatcher { get; set; }
    
    private void IncrementCount() =>
        Dispatcher.Dispatch(new IncrementCounterAction());
}