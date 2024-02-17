using Fluxor;

namespace Blazor8AutoWithFluxor.Shared.State.Counter;

public static class CounterActionsReducers
{
    [ReducerMethod]
    public static CounterState OnIncrementClientCounterAction(CounterState state, IncrementCounterAction action)
    {
        return state with
        {
            CurrentCount = state.CurrentCount + 1
        };
    }
}