using NUnit.Framework;
using Otus.Graphs.Begining.Utils;
using Otus.Graphs.Begining.Utils.Dtos;

namespace Tests
{
    public class FileReaderTests
    {
        [Test]
        public void Can_Read_File_With_Graph_Points()
        {
            var graphInfo = new FileReader().GetGraphPoints(Consts.FirstGraphFileName);

            Assert.That(graphInfo.VertexesCount, Is.EqualTo(5));
            Assert.That(graphInfo.EdgesCount, Is.EqualTo(5));
            Assert.That(graphInfo.Vertexes.Length, Is.EqualTo(5));
            
            CheckEdgeInfo(graphInfo, 0, 1, 2);
            CheckEdgeInfo(graphInfo, 1, 2, 3);
            CheckEdgeInfo(graphInfo, 2, 2, 4);
            CheckEdgeInfo(graphInfo, 3, 3, 4);
            CheckEdgeInfo(graphInfo, 4, 5, 5);
        }

        [Test]
        public void Can_Read_File_With_Weighted_Graph_Points()
        {
            var graphInfo = new FileReader().GetWeightedGraphPoints(Consts.FifthGraphFileName);

            Assert.That(graphInfo.VertexesCount, Is.EqualTo(7));
            Assert.That(graphInfo.EdgesCount, Is.EqualTo(10));
            Assert.That(graphInfo.Vertexes.Length, Is.EqualTo(10));

            CheckEdgeInfo(graphInfo, 0, 1, 2, 7);
            CheckEdgeInfo(graphInfo, 1, 2, 3, 2);
            CheckEdgeInfo(graphInfo, 2, 2, 7, 9);
            CheckEdgeInfo(graphInfo, 3, 2, 4, 10);
            CheckEdgeInfo(graphInfo, 4, 3, 7, 1);
            CheckEdgeInfo(graphInfo, 5, 4, 7, 3);
            CheckEdgeInfo(graphInfo, 6, 4, 5, 5);
            CheckEdgeInfo(graphInfo, 7, 5, 6, 4);
            CheckEdgeInfo(graphInfo, 8, 6, 7, 6);
            CheckEdgeInfo(graphInfo, 9, 6, 2, 8);
        }


        #region Support Methods

        private void CheckEdgeInfo(GraphFileInfo graphInfo, int index, int firstVertex, int secondVertex)
        {
            Assert.That(graphInfo.Vertexes[index].First, Is.EqualTo(firstVertex));
            Assert.That(graphInfo.Vertexes[index].Second, Is.EqualTo(secondVertex));
        }

        private void CheckEdgeInfo(WeightedGraphFileInfo graphInfo, int index, int firstVertex, int secondVertex, int weight)
        {
            Assert.That(graphInfo.Vertexes[index].First, Is.EqualTo(firstVertex));
            Assert.That(graphInfo.Vertexes[index].Second, Is.EqualTo(secondVertex));
            Assert.That(graphInfo.Vertexes[index].Weight, Is.EqualTo(weight));
        }

        #endregion
    }
}