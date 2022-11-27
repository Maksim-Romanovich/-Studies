
namespace Task112
{
    class Task112
    {
        public static void Main()
        {
            Triangle();
        }
        public static void Triangle()
        {
            Console.WriteLine("Enter number of lines:");
            if (int.TryParse(Console.ReadLine(), out var n) && n > 0)
                for (var i = "*"; i.Length <= n; i += "*")
                    Console.WriteLine(i);
            else
                throw new ArgumentException("Invalid argument. Use only positive numbers");
        }
    }
}
