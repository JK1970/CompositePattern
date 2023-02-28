namespace CompositePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Directory directory1 = new()
            {
                Name = "Directory1"
            };

            Directory directory2 = new()
            {
                Name = "Directory2"
            };

            Directory directory3 = new()
            {
                Name = "Directory3"
            };

            Directory directory4 = new()
            {
                Name = "Directory4"
            };

            File file1 = new(10)
            {
                Name = "File1"
            };

            File file2 = new(20)
            {
                Name = "File2"
            };

            File file3 = new(30)
            {
                Name = "File3"
            };

            File file4 = new(40)
            {
                Name = "File4"
            };

            directory1.Components.Add(directory2);
            directory1.Components.Add(directory3);
            directory1.Components.Add(file1);

            directory2.Components.Add(file2);
            directory2.Components.Add(directory4);

            directory3.Components.Add(file3);

            directory4.Components.Add(file4);

            Console.WriteLine("\n{0} : {1}\n", directory1.Name, directory1.GetSize());
            directory1.PrintTree();

            Console.WriteLine("\n{0} : {1}\n", directory2.Name, directory2.GetSize());
            directory2.PrintTree();

            Console.WriteLine("\n{0} : {1}\n", directory3.Name, directory3.GetSize());
            directory3.PrintTree();

            Console.WriteLine("\n{0} : {1}\n", directory4.Name, directory4.GetSize());
            directory4.PrintTree();
        }
    }
}
