using CompositePattern.Models;

namespace CompositePattern
{
    public class File : TreeComponent
    {
        public int Size { get; set; }
        public File(int size)
        {
            Size = size;
        }
        public override int GetSize()
        {
            return Size;
        }
        public override void PrintTree(int step)
        {
            for (int i = 0; i < step; i++)
            {
                Console.Write("\t");
            }
            Console.WriteLine(Name);
        }
    }
}