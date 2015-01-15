using System;

namespace ProgramExercise1
{


    public class Person
    {
        public string name;
        private int age;
        private DateTime birthday;

        public Person(string argName, string bd)
        {
            name = argName;
            birthday = DateTime.Parse(bd);
        }

        public string getAge()
        {
            age = (int) ((DateTime.Now - birthday).TotalDays / 365d);
            return age.ToString();
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            Person wyatt = new Person("Wyatt","08/19/1991");

            string output = string.Format("{0} is {1} years old today!",
                wyatt.name , wyatt.getAge());

            Console.WriteLine(output);

            Console.Read();
        }
    }
}
