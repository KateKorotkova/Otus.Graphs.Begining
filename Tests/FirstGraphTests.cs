using NUnit.Framework;
using Otus.Graphs.Begining.FirstGraph;

namespace Tests
{
    [TestFixture]
    public class FirstGraphTests
    {
        [Test]
        public void Can_Get_Adjacency_Matrix()
        {
            var graph = new FirstGraphProcessor();

            var result = graph.GetAdjacencyMatrix();

            Assert.That(result.GetLength(0), Is.EqualTo(6));
            Assert.That(result.GetLength(1), Is.EqualTo(6));
            //new[] {0, 1, 0, 0, 0}
            Assert.AreEqual(result[1, 1], 0);
            Assert.AreEqual(result[1, 2], 1);
            Assert.AreEqual(result[1, 3], 0);
            Assert.AreEqual(result[1, 4], 0);
            Assert.AreEqual(result[1, 5], 0);
        }
    }
}
