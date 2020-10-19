using System;
using System.Dynamic;

namespace YearValidater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year are you born in?");
            string userInput;
            userInput = Console.ReadLine();
         //   int Age;
         //   Age = Int32.Parse(userInput);
         //   int Year = 2020 - Age;
          //  Console.WriteLine("You are born in " + Year);
          if(Validate(userInput))
            {

            }
        }
        public static bool Validate(string YearInput)
        {
            if (YearInput.Length == 4)
            {
                try
                {
                    Int32.Parse(YearInput);
                    return true;
                } catch (Exception error)
                {
                    Console.WriteLine(error);
                    return false;

                }
            } else
            {
                Console.WriteLine("Wrong Format");
                return false;
            }
            
              
                 
                
         
        }
    }
}
