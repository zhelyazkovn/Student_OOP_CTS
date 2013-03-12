using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Student
{
    public class StudentDemo
    {
        public static void Main()
        {
            Student st1 = new Student();
            Student st2 = new Student("Ivan Ivanov Ivanov", 112255, "Sofiq, Han Kubrat 22", "0882507781", 
                                    "ivan@abv.bg", 5, Specialty.Economics, University.UNWE, Faculty.Informatics);
            Student st3 = new Student("Petar Petrov Petrov", 112235, "Sofiq, Han Kubrat 22", "0882507781",
                                    "ivan@abv.bg", 5, Specialty.Economics, University.UNWE, Faculty.Informatics);
            Student st4 = new Student("Ivan Ivanov Ivanov", 112255, "Sofiq, Han Kubrat 22", "0882507781",
                                    "ivan@abv.bg", 5, Specialty.Economics, University.UNWE, Faculty.Informatics);

            Console.WriteLine(st2.Equals(st4));//true
            Console.WriteLine(st2 != st4);//false
            Console.WriteLine(st2.CompareTo(st1));//1
            Console.WriteLine(st2.CompareTo(st4));//0
            Console.WriteLine(st2.CompareTo(st3));//-1
        }
    }
}
