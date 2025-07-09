// Some differnt
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Your name:");
        string name = "Jayant";
        string name2 = "Nayan";
        string name3 = " Mayar";
        if (name == "Jayant"  && name!= null)
        {
            Console.WriteLine("Hii Jayant Hou are You");
        }
        else if (name == "Nayan") 
        {
            Console.WriteLine("Hello Nayan How are You ");


        }
        else if (name == "Mayur") 
        {
            Console.WriteLine("Hello , Mayur hou are you");
        }
        else
        {
            Console.WriteLine(" Your name is not match:");
        }
        Console.WriteLine();
        Console.ReadLine();

    }
}
