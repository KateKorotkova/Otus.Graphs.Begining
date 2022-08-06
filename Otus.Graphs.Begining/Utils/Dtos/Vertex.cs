namespace Otus.Graphs.Begining.Utils.Dtos
{
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