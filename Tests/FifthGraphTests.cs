using NUnit.Framework;
using Otus.Graphs.Begining.FifthGraph;

namespace Tests
{
    [TestFixture]
    public class FifthGraphTests
    {
        [Test]
        public void Can_Get_Adjacency_Matrix()
        {
            var graph = new FifthGraphAdjacencyMatrixProcessor();

            var result = graph.Matrix;

            Assert.That(result.GetLength(0), Is.EqualTo(8));
            Assert.That(result.GetLength(1), Is.EqualTo(8));
            CheckMatrixRow(result, 1, new[] { 0, 1, 0, 0, 0, 0, 0 });
            CheckMatrixRow(result, 2, new[] { 0, 0, 1, 1, 0, 0, 0 });
            CheckMatrixRow(result, 3, new[] { 0, 0, 0, 0, 0, 0, 1 });
            CheckMatrixRow(result, 4, new[] { 0, 0, 0, 0, 1, 0, 1 });
            CheckMatrixRow(result, 5, new[] { 0, 0, 0, 0, 0, 1, 0 });
            CheckMatrixRow(result, 6, new[] { 0, 1, 0, 0, 0, 0, 1 });
            CheckMatrixRow(result, 7, new[] { 0, 0, 0, 0, 0, 0, 0 });
        }

        [TestCase(1, 1, ExpectedResult = false)]
        [TestCase(1, 2, ExpectedResult = true)]
        [TestCase(2, 1, ExpectedResult = false)]
        public bool Can_Check_Adjacency(int firstVertex, int secondVertex)
        {
            var graph = new FifthGraphAdjacencyMatrixProcessor();

            return graph.AreAdjacency(firstVertex, secondVertex);
        }

        [Test]
        public void Can_Get_Adjacency_Vertexes()
        {
            var graph = new FifthGraphAdjacencyMatrixProcessor();

            var result = graph.GetAdjacencyVertexes(2);

           Assert.That(result.Length, Is.EqualTo(3));
           Assert.That(result[0], Is.EqualTo(3));
           Assert.That(result[1], Is.EqualTo(4));
           Assert.That(result[2], Is.EqualTo(7));
        }

        [Test]
        public void Can_Get_Vertex_Degree()
        {
            var graph = new FifthGraphAdjacencyMatrixProcessor();

            var result = graph.GetVertexDegree(4);

            Assert.That(result, Is.EqualTo(2));
        }


        #region Support Methods

        private static void CheckMatrixRow(int[,] matrix, int rowIndex, int[] expectedValues)
        {
            Assert.AreEqual(expectedValues[0], matrix[rowIndex, 1]);
            Assert.AreEqual(expectedValues[1], matrix[rowIndex, 2]);
            Assert.AreEqual(expectedValues[2], matrix[rowIndex, 3]);
            Assert.AreEqual(expectedValues[3], matrix[rowIndex, 4]);
            Assert.AreEqual(expectedValues[4], matrix[rowIndex, 5]);
        }

        #endregion
    }
}
