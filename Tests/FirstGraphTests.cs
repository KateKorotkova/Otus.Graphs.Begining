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
            CheckMatrixRow(result, 1, new[] { 0, 1, 0, 0, 0 });
            CheckMatrixRow(result, 2, new[] { 1, 0, 1, 1, 0 });
            CheckMatrixRow(result, 3, new[] { 0, 1, 0, 1, 0 });
            CheckMatrixRow(result, 4, new[] { 0, 1, 1, 0, 0 });
            CheckMatrixRow(result, 5, new[] { 0, 0, 0, 0, 2 });
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
