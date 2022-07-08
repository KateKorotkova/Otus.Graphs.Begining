using System.Collections.Generic;
using Otus.Graphs.Begining.Utils;

namespace Otus.Graphs.Begining.FirstGraph
{
    public class FirstGraphProcessor
    {
        private readonly GraphFileInfo _graphFileInfo;

        public FirstGraphProcessor()
        {
            _graphFileInfo = new FileReader().GetGraphPoints(Consts.FirstGraphFileName);
        }


        public int[,] GetAdjacencyMatrix()
        {
            var matrix = new int[_graphFileInfo.VertexesCount + 1, _graphFileInfo.VertexesCount + 1];

            for (var i = 0; i < _graphFileInfo.VertexesCount; i++)
            {
                var vertexToCompare = _graphFileInfo.Vertexes[i].First;
                var currentVertexPair = _graphFileInfo.Vertexes[i].Second;

                if (vertexToCompare == currentVertexPair)
                {
                    matrix[vertexToCompare, vertexToCompare] = 2;
                }
                else
                {
                    matrix[vertexToCompare, currentVertexPair] = 1;
                    matrix[currentVertexPair, vertexToCompare] = 1;
                }
            }

            return matrix;
        }

        public bool AreAdjacency(int firstVertex, int secondVertex)
        {
            var matrix = GetAdjacencyMatrix();

            return matrix[firstVertex, secondVertex] != 0;
        }

        public int[] GetAdjacencyVertexes(int vertex)
        {
            var matrix = GetAdjacencyMatrix();

            var adjacencyVertexes = new List<int>();
            for (var i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[vertex, i] != 0)
                {
                    adjacencyVertexes.Add(i);
                }
            }

            return adjacencyVertexes.ToArray();
        }
    }
}
