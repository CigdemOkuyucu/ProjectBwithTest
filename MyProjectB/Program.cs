
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;

public static class Calculate
{
    public static int Add(int a,int b)
    {
        return 2*(a+b);
    }

    public static int Subtract(int a, int b)
    {
        return 2*(a-b);
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello");
        Console.WriteLine(Calculate.Add(5,7));
    }
} 