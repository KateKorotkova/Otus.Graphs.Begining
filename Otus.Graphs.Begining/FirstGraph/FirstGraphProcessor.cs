using Otus.Graphs.Begining.Utils;

namespace Otus.Graphs.Begining.FirstGraph
{
    public class FirstGraphProcessor
    {
        private GraphFileInfo _graphFileInfo;

        public FirstGraphProcessor()
        {
            _graphFileInfo = new FileReader().GetGraphPoints(Consts.FirstGraphFileName);
        }


        public int[,] GetAdjacencyMatrix()
        {
            var matrix = new int[_graphFileInfo.VertexesCount + 1, _graphFileInfo.VertexesCount + 1];

            for (var i = 0; i < _graphFileInfo.VertexesCount - 1; i++)
            {
                var vertexToCompare = _graphFileInfo.Vertexes[i][0];
                matrix[vertexToCompare, _graphFileInfo.Vertexes[i][1]] = 1;

                for (var j = i + 1; j < _graphFileInfo.VertexesCount; j++)
                {
                    var currentFromVertex = _graphFileInfo.Vertexes[j][0];
                    var currentToVertex = _graphFileInfo.Vertexes[j][1];
                    if (vertexToCompare == currentFromVertex)
                    {
                        matrix[vertexToCompare, currentFromVertex] = 1;
                    }
                    if (vertexToCompare == currentToVertex)
                    {
                        matrix[vertexToCompare, currentToVertex] = 1;
                    }
                }
            }

            return matrix;
        }
    }
}
