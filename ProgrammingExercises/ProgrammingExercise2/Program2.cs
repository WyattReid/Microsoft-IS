using System;

namespace ProgrammingExercise2
{
    class Program
    {
        const string OutputStatement = "The Ohio State University has the best football team";

        static void Main(string[] args)
        {
            var isInt = false;
            Console.Write("How many times to print the statement? (0-50): ");
            var input = Console.ReadLine();
            int output;

            isInt = int.TryParse(input, out output);

            if (!isInt)
            {
                Console.WriteLine("ERROR: Please enter a number");
            }

            if (output > 50)
            {
                Console.WriteLine("ERROR: Please enter a number less than 50");
            }

            if (output == 0 || output < 0 )
            {
                Console.WriteLine("ERROR: Please enter a positive number");
            }

            for (var i=0; i < output; i++ )
            {
                Console.WriteLine(OutputStatement);
            }

            Console.Read();

            
        }
    }

}
 
