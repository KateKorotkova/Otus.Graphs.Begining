namespace Otus.Graphs.Begining.Utils
{
    public class WeightedGraphFileInfo
    {
        public int VertexesCount { get; set; }

        public int EdgesCount { get; set; }

        public VertexWithWeight[] Vertexes { get; set; }
    }

    public class VertexWithWeight : Vertex
    {
        public int Weight { get; set; }

        public VertexWithWeight(int first, int second, int weight)
            : base(first, second)
        {
            Weight = weight;
        }
    }
}
