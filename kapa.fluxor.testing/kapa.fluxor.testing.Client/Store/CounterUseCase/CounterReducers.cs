using Fluxor;
using Kapa.Fluxor.Testing.Store;

namespace Kapa.Fluxor.Testing.Client.Store.CounterUseCase;

public static class CounterReducers
{
    [ReducerMethod(typeof(IncrementCounterAction))]
    public static CounterState ReduceIncrementCounterAction(CounterState state) =>
        new CounterState(state.ClickCount + 1);
}