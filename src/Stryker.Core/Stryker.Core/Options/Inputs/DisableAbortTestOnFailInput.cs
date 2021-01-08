namespace Stryker.Core.Options.Inputs
{
    public class DisableAbortTestOnFailInput : OptionDefinition<bool, OptimizationModes>
    {
        public override StrykerOption Type => StrykerOption.DisableAbortTestOnFail;
        public override bool DefaultInput => false;
        public override OptimizationModes DefaultValue => new DisableAbortTestOnFailInput(DefaultInput).Value;

        protected override string Description => "Disable abort unit testrun as soon as any one unit test fails.";

        public DisableAbortTestOnFailInput() { }
        public DisableAbortTestOnFailInput(bool? disableAbortTestOnFail)
        {
            if (disableAbortTestOnFail is { })
            {
                Value = disableAbortTestOnFail.Value ? OptimizationModes.DisableAbortTestOnKill : OptimizationModes.NoOptimization;
            }
        }
    }
}
