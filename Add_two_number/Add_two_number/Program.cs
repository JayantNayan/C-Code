class program
{
    static void Main(String[] arys)
    {
        Console.WriteLine("Enter the first number");
        string a = Console.ReadLine();

        Console.WriteLine("Enter the second number");
        string b = Console.ReadLine();

        int u = Convert.ToInt32(a);
        int v = Convert.ToInt32(b);
        int c = u + v;
        Console.Write("Your answer is:" +c);
        Console.ReadKey();

        

    }
    
}