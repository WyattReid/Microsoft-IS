using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramExercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "";
            string yearsOld = "";
            string output = String.Format("{0} is {1} years old today!", name, yearsOld);

            Console.WriteLine(output);

            Console.Read();
        }
    }

    public class GetAge
    {
        public string name { get; set; }
        public DateTime birthdate { get; set; }
        public DateTime age { get; set; }

        public string name = "Wyatt Reid";
        birthdate = DateTime.Parse("08/19/1991");
        DateTime age = ((DateTime.Now - birthdate).TotalDays / 365d);

        public string getAge() { return age; }

        

        
    }
}
