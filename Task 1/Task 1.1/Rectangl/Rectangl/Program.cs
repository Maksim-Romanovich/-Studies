
using System;
public class RectanglArea
{
    public static void Main()
    {
        Console.Write("a: ");
        int side_a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b: ");
        int side_b = Convert.ToInt32(Console.ReadLine());

        int RectanglArea = (side_a * side_b);

        Console.WriteLine("RectanglArea: {0}", RectanglArea);
        Console.ReadLine();
    }
}


