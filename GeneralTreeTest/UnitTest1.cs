using System;
using Xunit;
using GeneralTree;

namespace GeneralTreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddNodeTest()
        {
            var node = new Node<String>("a");
            Assert.Equal("a", node.Data);
            Assert.Empty(node.Children);

            var node2 = new Node<String>("a");
            node2.Add("b");
            Assert.Single(node2.Children);
            Assert.Empty(node2.Children[0].Children);
        }

        [Fact]
        public void RemoveNodeTest()
        {
            var node = new Node<String>("a");
            node.Add("b");
            Assert.Single(node.Children);
            Assert.Empty(node.Children[0].Children);

            node.Remove("b");
            Assert.Empty(node.Children);
        }
    }
}
