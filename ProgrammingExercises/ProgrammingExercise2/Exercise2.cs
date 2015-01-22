using System;

namespace ProgrammingExercise2
{
    class Program
    {
        const string OutputStatement = "The Ohio State University has the best " +
                                       "football team in the nation";

        private static void DoWrite(int times)
        {
            for (var i = 0; i < times; i++)
            {
                Console.WriteLine(OutputStatement);
            }

        }
        
        static void Main(string[] args)
        {
            var output = 0;
            var flag = false;
            while (!flag)
            {
                Console.Write("How many times to print the statement? (1-50): ");
                var input = Console.ReadLine();
                
                var isInt = int.TryParse(input, out output);

                if (!isInt)
                {
                    Console.WriteLine("ERROR: Please enter a number\n");
                    

                }

                else if (output > 50)
                {
                    Console.WriteLine("ERROR: Please enter a number <= 50\n");
                    
                }

                else if (output == 0 || output < 0)
                {
                    Console.WriteLine("ERROR: Please enter a positive number\n");

                }
                else
                {
                    flag = true;
                    Console.WriteLine();
                }


            }
            
            DoWrite(output);

            Console.Read();

            
        }
    }

}
 
