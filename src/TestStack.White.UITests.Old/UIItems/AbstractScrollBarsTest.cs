using NUnit.Framework;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.TreeItems;
using TestStack.White.UITests.Testing;
using Xunit;

namespace White.Core.UITests.UIItems
{
    [TestFixture, WPFCategory]
    public class AbstractScrollBarsTest : ControlsActionTest
    {
        [Fact]
        public void CanScroll()
        {
            var controlWithVScrollBar = Window.Get<ListBox>("listBoxWithVScrollBar");
            Assert.Equal(true, controlWithVScrollBar.ScrollBars.CanScroll);
            var controlWithHorizontalScrollBar = Window.Get<MultilineTextBox>("textBox1");
            Assert.Equal(true, controlWithHorizontalScrollBar.ScrollBars.CanScroll);
        }

        [Fact]
        public void CannotScroll()
        {
            var controlWithScrollBar = Window.Get<Tree>("treeViewLaunchesModal");
            Assert.Equal(false, controlWithScrollBar.ScrollBars.CanScroll);
        }
    }
}
