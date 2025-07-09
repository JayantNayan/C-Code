// This Program is show the I am given the spacific time and system give the output.
class Program
{
    static void Main(string[] args)
    {
        DateTime DateTimeProperty = new DateTime(2016, 8, 16, 3, 57, 32, 11);
        Console.WriteLine("Day of the given data {0}:", DateTimeProperty.Day);
        Console.WriteLine("Year of the given data {0}:", DateTimeProperty.Year);
        Console.WriteLine("Month of the given data {0}:", DateTimeProperty.Month);
        Console.WriteLine(" Day of the given data {0}:", DateTimeProperty.Day);
        Console.WriteLine("Hour of the given data {0}:", DateTimeProperty.Hour);
        Console.WriteLine("Mintute of the give data {0}:", DateTimeProperty.Minute);
        Console.WriteLine("Second of the given data {0}:", DateTimeProperty.Second);
        Console.WriteLine("MiliSecond of the given data {0}:", DateTimeProperty.Millisecond);
        Console.ReadKey();
    }
}
