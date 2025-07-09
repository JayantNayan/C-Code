class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Enter the any number number");
        string a = Console.ReadLine();

        

        int n1 = Convert.ToInt32(a);
        

        if (n1 % 2 == 0)
        {
            Console.WriteLine("This is Even number");

        }
        else
        {
            Console.WriteLine(" This is odd number");
        }

        Console.ReadKey();
            

    }
    
}
