using Fluxor;

namespace Blazor8AutoWithFluxor.Shared.State.Counter;

public class CounterFeature : Feature<CounterState>
{
    public override string GetName() => "ClientCounter";

    protected override CounterState GetInitialState()
    {
        return new CounterState(0);
    }
}