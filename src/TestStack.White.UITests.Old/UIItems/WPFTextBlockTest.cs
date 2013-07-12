using NUnit.Framework;
using TestStack.White.UIItems;
using TestStack.White.UITests.Testing;
using Xunit;

namespace White.Core.UITests.UIItems
{
    [TestFixture, WPFCategory]
    public class WPFTextBlockTest : ControlsActionTest
    {
        protected override string CommandLineArguments
        {
            get { return WPFScenarioSet1; }
        }

        [Fact]
        public void Find()
        {
            Label label = Window.Get<Label>("textBlock1");
            Assert.NotEqual(null, label);
        }
    }
}