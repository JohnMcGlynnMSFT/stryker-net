using Shouldly;
using Stryker.Core.Exceptions;
using Stryker.Core.Options.Inputs;
using Xunit;

namespace Stryker.Core.UnitTest.Options.Inputs
{
    public class AdditionalTimeoutMsInputTests
    {
        [Fact]
        public void ShouldAllowZero()
        {
            var target = new AdditionalTimeoutMsInput { SuppliedInput = 0 };

            var result = target.Validate();

            result.ShouldBe(0);
        }
        
        [Fact]
        public void ShouldHaveDefault()
        {
            var target = new AdditionalTimeoutMsInput { SuppliedInput = null };

            var result = target.Validate();

            result.ShouldBe(5000);
        }

        [Fact]
        public void ShouldAllowMillion()
        {
            var target = new AdditionalTimeoutMsInput { SuppliedInput = 1000000 };

            var result = target.Validate();

            result.ShouldBe(1000000);
        }

        [Fact]
        public void ShouldThrowAtNegative()
        {
            var target = new AdditionalTimeoutMsInput { SuppliedInput = -1 };

            var exception = Should.Throw<InputException>(() => target.Validate());

            exception.Message.ShouldBe("Timeout cannot be negative");
        }
    }
}
