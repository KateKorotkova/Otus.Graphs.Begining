using System.Collections.Generic;
using Otus.Graphs.Begining.Utils;
using Otus.Graphs.Begining.Utils.Dtos;

namespace Otus.Graphs.Begining.FifthGraph
{
    public class FifthGraphAdjacencyMatrixProcessor
    {
        public int[,] Matrix { get; }


        public FifthGraphAdjacencyMatrixProcessor()
        {
            var graphFileInfo = new FileReader().GetWeightedGraphPoints(Consts.FifthGraphFileName);

            Matrix = GetAdjacencyMatrix(graphFileInfo);
        }


        public bool AreAdjacency(int firstVertex, int secondVertex)
        {
            return Matrix[firstVertex, secondVertex] != 0;
        }

        public int[] GetAdjacencyVertexes(int vertex)
        {
            var adjacencyVertexes = new List<int>();
            for (var i = 0; i < Matrix.GetLength(1); i++)
            {
                if (Matrix[vertex, i] != 0)
                {
                    adjacencyVertexes.Add(i);
                }
            }

            return adjacencyVertexes.ToArray();
        }

        public int GetVertexDegree(int vertex)
        {
            return GetAdjacencyVertexes(vertex).Length;
        }


        #region Support Methods

        private int[,] GetAdjacencyMatrix(WeightedGraphFileInfo graphFileInfo)
        {
            var matrix = new int[graphFileInfo.VertexesCount + 1, graphFileInfo.VertexesCount + 1];

            for (var i = 0; i < graphFileInfo.EdgesCount; i++)
            {
                var vertexToCompare = graphFileInfo.Vertexes[i].First;
                var currentVertexPair = graphFileInfo.Vertexes[i].Second;

                if (vertexToCompare == currentVertexPair)
                {
                    matrix[vertexToCompare, vertexToCompare] = 2;
                }
                else
                {
                    matrix[vertexToCompare, currentVertexPair] = 1;
                }
            }

            return matrix;
        }

        #endregion
    }
}
