using System;

namespace Howoldareyou
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. App greets the user
             * 2. App asks the user´s name
             * 3. App greets the user by their name
             * 4. App asks the user´s year of birth
             * 5. App calculates the age of the user
             * 6. The app displays the result (the user´s age)
             */

            Console.WriteLine("good morning");
            Console.WriteLine("what is your name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello, " + Name);
            Console.WriteLine("What is your year of birth?");
            string Userinput;
            Userinput = Console.ReadLine();
            int YearOfBirth;
            //parsing string to interger (number)
            YearOfBirth = Int32.Parse(Userinput);
            int age = 2020 - YearOfBirth;
            Console.WriteLine("You are " + age + " old ");



               

        
       
            
           
     
        }  
    }
}
