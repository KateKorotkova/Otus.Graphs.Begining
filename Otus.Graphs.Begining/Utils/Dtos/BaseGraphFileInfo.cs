namespace Otus.Graphs.Begining.Utils.Dtos
{
    public abstract class BaseGraphFileInfo<T> where T : Vertex
    {
        public int VertexesCount { get; set; }

        public int EdgesCount { get; set; }

        public T[] Vertexes { get; set; }
    }
}
