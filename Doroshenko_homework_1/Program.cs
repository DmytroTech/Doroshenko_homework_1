using System;
using System.Collections.Generic;
using System.Linq;

namespace Doroshenko_homework_1
{

    class Student
    {
        private string firstName;
        private int course;
                
        public string FirstName { get => firstName; set => firstName = value; }
        public int Course { get => course; set => course = value; }
        public Dictionary<string, int> dictionary = new Dictionary<string, int>();
    }

    class Program
    {
        static void Main()
        {
            
            Student a1 = new Student()
            {
                FirstName = "Dmytro Doroshenko",
                Course = 4,
                dictionary = new Dictionary<string, int>
            {
                {"BD", 65 },
                {"OOP", 81 },
                {"MMOZ", 90 },
                {"Android", 100 },
                {"JAVA", 85 },
                {".NET", 91 }
            },

            };


            Student a2 = new Student()
            {
                FirstName = "Dmytro Petrishin",
                Course = 4,
                dictionary = new Dictionary<string, int>
            {
                {"BD", 61 },
                {"OOP", 61 },
                {"MMOZ", 71 },
                {"Android", 75 },
                {"JAVA", 71 },
                {".NET", 71 }
            },

            };


            Student a3 = new Student()
            {
                FirstName = "Kladko Yaroslav",
                Course = 4,
                dictionary = new Dictionary<string, int>
            {
                {"BD", 91 },
                {"OOP", 93 },
                {"MMOZ", 95 },
                {"Android", 85 },
                {"JAVA", 86 },
                {".NET", 79 }
            },

            };


            Student a4 = new Student()
            {
                FirstName = "Dmytro Dehtiarenko",
                Course = 4,
                dictionary = new Dictionary<string, int>
            {
                {"BD", 65 },
                {"OOP", 71 },
                {"MMOZ", 73 },
                {"Android", 68 },
                {"JAVA", 85 },
                {".NET", 81 }
            },

            };


            Student a5 = new Student()
            {
                FirstName = "Anna Yeremchenko",
                Course = 4,
                dictionary = new Dictionary<string, int>
            {
                {"BD", 60 },
                {"OOP", 61 },
                {"MMOZ", 61 },
                {"Android", 61 },
                {"JAVA", 61 },
                {".NET", 61 }
            },

            };


            List<Student> students = new List<Student>()
            {
                a1, a2, a3, a4, a5
            };

      

            IEnumerable<Student> sorted = students.OrderByDescending(a => {
                double avgr = 0;
                foreach (var x in a.dictionary.Keys)
                {
                    avgr += a.dictionary[x];
                }
                return avgr / a.dictionary.Count;
            });


            
            foreach (var student in sorted)
            {

                Console.WriteLine($"{student.FirstName} Average mark {student.dictionary.Average(x => x.Value)}");

                foreach (var num in student.dictionary) {
                    Console.WriteLine($"{num.Key} mark is  {num.Value}");
                };                

            }

            Console.ReadLine();
        }
    }
}