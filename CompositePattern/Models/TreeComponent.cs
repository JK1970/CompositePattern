namespace CompositePattern
{
    public abstract class TreeComponent
    {
        public string? Name { get; set; }
        public abstract int GetSize();
        public abstract void PrintTree(int step);
        public void PrintTree()
        {
            PrintTree(0);
        }
    }
}