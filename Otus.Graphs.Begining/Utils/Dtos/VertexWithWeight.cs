namespace Otus.Graphs.Begining.Utils.Dtos
{
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