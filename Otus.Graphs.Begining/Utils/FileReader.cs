using System.IO;
using System.Linq;

namespace Otus.Graphs.Begining.Utils
{
    public class FileReader
    {
        public GraphFileInfo GetGraphPoints(string fileName)
        {
            var allLines = File.ReadAllLines(fileName);

            var vertexes = GetVertexes(allLines);

            var firstLineInFile = allLines[0].Split().Select(int.Parse).ToArray();
            return new GraphFileInfo
            {
                VertexesCount = firstLineInFile[0],
                EdgesCount = firstLineInFile [1],
                Vertexes = vertexes
            };
        }


        #region SupportMethods

        private static int[][] GetVertexes(string[] allLines)
        {
            var vertexesCounter = 0;
            var vertexes = new int[allLines.Length - 1][];

            for (var i = 1; i < allLines.Length; i++)
            {
                var currentEdgeInfo = allLines[i].Split(' ').Select(int.Parse).ToArray();
                vertexes[vertexesCounter++] = currentEdgeInfo;
            }

            return vertexes;
        }

        #endregion
    }
}
