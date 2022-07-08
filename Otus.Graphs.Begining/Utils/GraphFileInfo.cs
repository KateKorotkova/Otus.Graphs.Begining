namespace Otus.Graphs.Begining.Utils
{
    public class GraphFileInfo
    {
        public int VertexesCount { get; set; }

        public int EdgesCount { get; set; }

        public Vertex[] Vertexes { get; set; }
    }


    public class Vertex
    {
        public int First { get; set; }
        public int Second { get; set; }

        public Vertex(int first, int second)
        {
            First = first;
            Second = second;
        }
    }
}
