using System;
class Hero
{
    private string name
    {
        get { return name; }
        set { name = value; }
    }
    
    private int phone_number
    {
        get { return phone_number; }
        set { phone_number = value; }
    }
    private string city
    {
        get { return city; }
        set { city = value; }

    }

    public string Name;
    public string City;
    public int PhoneNumber;

    
        static void Main(string[] args)
        {
            Hero newHero = new Hero();
            newHero.name = "Jayant";
            Console.WriteLine(newHero.name);
            newHero.city = "London";
            Console.WriteLine(newHero.city);
            newHero.phone_number = 256;
            Console.WriteLine(newHero.phone_number);


            Hero avatar= new Hero();
            avatar.Name = "Rolex";
            Console.WriteLine(avatar.Name);
            avatar.City = "Hon-Kon";
            Console.WriteLine(avatar.City);
            avatar.PhoneNumber = 07;
            Console.WriteLine(avatar.PhoneNumber);
            Console.WriteLine();
            Console.ReadKey();
        }
    }

