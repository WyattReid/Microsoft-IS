using System;

namespace ConsoleApplication1
{


    public class Person
    {
        public string Name;
        private int _age;
        private readonly DateTime _birthday;

        public Person(string argName, string bd)
        {
            Name = argName;
            _birthday = DateTime.Parse(bd);
            _age = (int)((DateTime.Now - _birthday).TotalDays / 365d);
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
