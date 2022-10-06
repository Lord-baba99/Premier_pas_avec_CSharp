using System;

namespace start

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu sur ma priemière app en c#");

            Console.Write("Quel est ton nom ? ");
            string name = Console.ReadLine();

            Console.Write("Quel est votre age ? ");
            string age = Console.ReadLine();

            Console.WriteLine("Hello, votre nom est " + name + ", vous avez " + age + "ans.");
        }
    }


}