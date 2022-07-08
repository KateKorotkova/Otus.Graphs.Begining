using NUnit.Framework;
using Otus.Graphs.Begining.Utils;

namespace Tests
{
    public class FileReaderTests
    {
        [Test]
        public void Can_Read_File_With_Graph_Points()
        {
            var graphInfo = new FileReader().GetGraphPoints(Consts.FirstGraphFileName);

            Assert.That(graphInfo.VertexesCount, Is.EqualTo(5));
            Assert.That(graphInfo.EdgesCount, Is.EqualTo(6));
            Assert.That(graphInfo.Vertexes.Length, Is.EqualTo(5));
            
            CheckEdgeInfo(graphInfo, 0, 1, 2);
            CheckEdgeInfo(graphInfo, 1, 2, 3);
            CheckEdgeInfo(graphInfo, 2, 2, 4);
            CheckEdgeInfo(graphInfo, 3, 3, 4);
            CheckEdgeInfo(graphInfo, 4, 5, 5);
        }


        #region Support Methods

        private void CheckEdgeInfo(GraphFileInfo graphInfo, int index, int firstVertex, int secondVertex)
        {
            Assert.That(graphInfo.Vertexes[index][0], Is.EqualTo(firstVertex));
            Assert.That(graphInfo.Vertexes[index][1], Is.EqualTo(secondVertex));
        }

        #endregion
    }
}