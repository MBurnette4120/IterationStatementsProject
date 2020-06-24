using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0 - DONE
            int init = 0;



            // Create a do-while loop - DONE
            do
            {
                // Increment your variable by 1 - DONE
                init++;
                // Then add your variable to "numbers" -DONE
                numbers.Add(init);
            } while (init < 100);
            // While your variable is less than 100 - DONE




            // Create a while loop - DONE
            // While your variable is less than 200 - DONE
            while (init < 200)
            {
                // Increment your variable by 1 -DONE
                init++;
                // Then add your variable to "numbers" - DONE
                numbers.Add(init);
            }
            
                       
                
            

            Console.WriteLine("Increase:");

            // Create a foreach loop -DONE
            foreach (var increase in numbers)
            // Write your variable to the console
            {

            Console.WriteLine($"{increase}");
            Console.WriteLine("");
            
            }

            Console.WriteLine("Decrease:");
            
            // Create a for loop - DONE
            // in your initializer set the value of i to 199 - DONE
            for (int i = 199; i <= numbers.Count && i >=0; i--)
            {
                Console.WriteLine($"{numbers[i]}");
                Console.WriteLine("");

            }
            
            
            // in your conditional, as long as i is less than or equal to the length of "numbers" - DONE
            // and as long as i is greater than or equal to 0 - DONE
            // Decrement i by 1 - DONE
            {
                // Write to the console "numbers" at index i - DONE
            }
        }
    }
}
