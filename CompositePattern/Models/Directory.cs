using CompositePattern.Models;

namespace CompositePattern
{
    public class Directory : TreeComponent
    {
        public List<TreeComponent> Components { get; set; }

        public Directory()
        {
            Components = new List<TreeComponent>();
        }

        public override int GetSize()
        {
            int size = 0;
            foreach (TreeComponent component in Components)
            {
                size += component.GetSize();
            }
            return size;
        }

        public override void PrintTree(int step)
        {
            for (int i = 0; i < step; i++)
            {
                Console.Write("\t");
            }
            Console.WriteLine(Name);

            foreach (TreeComponent component in Components)
            {
                component.PrintTree(step + 1);
            }
        }
    }
}