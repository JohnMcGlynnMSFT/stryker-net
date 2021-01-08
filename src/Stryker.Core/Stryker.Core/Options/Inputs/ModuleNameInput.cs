using Stryker.Core.Exceptions;

namespace Stryker.Core.Options.Inputs
{
    public class ModuleNameInput : OptionDefinition<string>
    {
        public override StrykerOption Type => StrykerOption.ModuleName;

        protected override string Description => "Module name used by reporters. Usually a project in your solution would be a module.";

        public ModuleNameInput() { }
        public ModuleNameInput(string moduleName)
        {
            if (moduleName is { })
            {
                if (moduleName.IsNullOrEmptyInput())
                {
                    throw new StrykerInputException("Module name cannot be empty. Either fill the option or leave it out.");
                }
                Value = moduleName;
            }
        }
    }
}
