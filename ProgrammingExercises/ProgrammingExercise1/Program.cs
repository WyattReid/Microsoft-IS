using System;

namespace ProgrammingExercise1
{


    public class Person
    {
        public string Name;
        private readonly int _age;

        public Person(string argName, string bd)
        {
            Name = argName;
            var birthday = DateTime.Parse(bd);
            _age = (int)((DateTime.Now - birthday).TotalDays / 365d);
        }

        public string GetAge()
        {
            return _age.ToString();
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            var wyatt = new Person("Wyatt","08/19/1991");
            var output = string.Format("{0} is {1} years old today!",
                wyatt.Name , wyatt.GetAge());

            Console.WriteLine(output);

            Console.Read();
        }
    }
}
