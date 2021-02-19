namespace Stryker.Core.Options.Inputs
{
    public class WithBaselineInput : OptionDefinition<bool>
    {
        public override StrykerOption Type => StrykerOption.DashboardCompare;
        public override bool DefaultValue => false;

        protected override string Description => "EXPERIMENTAL: Use results stored in stryker dashboard to only test new mutants.";

        public WithBaselineInput() { }
        public WithBaselineInput(bool? compareToDashboard)
        {
            if (compareToDashboard is { })
            {
                Value = compareToDashboard.Value;
            }
        }
    }
}
