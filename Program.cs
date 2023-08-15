using System;

namespace Person
{
    public class Person
    {
        public string name;
        public string surname;
        public int age;

        public Person(string name, string surname,int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher("Arif","Orucov",30);
            teacher.Explain();
            var student = new Student("Isa","Imanov",19);
            student.Learn();
        }
    }
}
