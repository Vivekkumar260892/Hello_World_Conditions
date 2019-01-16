using System;

namespace Hello_World_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age : ");
            try
            {
                string TestInput = Console.ReadLine();
                int age = int.Parse(TestInput);
                if  (age <= 18)
                {
                    Console.WriteLine("You are a minor");
                }
                else if (age >18 && age<=65)
               {
                    Console.WriteLine("You are an adult");
                }
                else {
                    Console.WriteLine("You are a senior");
                }
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);

                if (age <= 18)
                {
                    Console.WriteLine("Which is your favourite sport");
                    string sport=Console.ReadLine();
                    Console.WriteLine("Your favourite sport is " + sport);
                }
                else if (age > 18 && age <= 65)
                {
                    Console.WriteLine("Which is your favourite vacation destination");
                    string sport= Console.ReadLine();
                    Console.WriteLine("Your favourite sport is " + sport);
                }
                else
                {
                    Console.WriteLine("Which is your favourite TV show");
                    string sport = Console.ReadLine();
                    Console.WriteLine("Your favourite sport is " + sport);
                }
               
                Console.ReadKey(true);
            }//end of try
            catch
            {
                Console.WriteLine("Invalid Age");
            }//end of catch
        }//end of main
    }
}
