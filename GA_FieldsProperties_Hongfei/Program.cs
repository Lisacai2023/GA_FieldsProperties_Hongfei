using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_FieldsProperties_Hongfei
{
    internal class Program
    {
        //Hongfei
        //week2-Fields and Properties
        //2024-1-13
        static void Main(string[] args)
        {
            Console.WriteLine("Week2 Assignment Fields and Properties");

            Student student1 = new Student();
            Student student2 = new Student();
            student1.Name = "Sam Lee";
            student1.Id = 30;
            student2.Id = 150;
            Console.WriteLine("The student name is " + (student1.Name) + " and ID is "+ (student1.Id));
            Console.WriteLine(student1.ReadOnlyName);
            Console.WriteLine(student2.ReadOnlyID);

            Console.ReadKey();

        }
    }
}
