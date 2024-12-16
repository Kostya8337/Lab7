using System;

class Program
{
    // Універсальний метод для обміну значеннями
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void Main(string[] args)
    {
        double x = 5.5, y = 10.2;
        Console.WriteLine($"До обміну: x = {x}, y = {y}");
        Swap(ref x, ref y);
        Console.WriteLine($"Після обміну: x = {x}, y = {y}\n");

        string str1 = "Hello", str2 = "World";
        Console.WriteLine($"До обміну: str1 = {str1}, str2 = {str2}");
        Swap(ref str1, ref str2);
        Console.WriteLine($"Після обміну: str1 = {str1}, str2 = {str2}");
    }
}
