using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Teacher:Person
    {
        public Teacher(string name, string surname, int age) : base(name, surname, age) { }
        public void Explain()
        {
            Console.WriteLine("Explaining...");
        }
    }
}
