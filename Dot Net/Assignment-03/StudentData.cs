using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class Student with fields Name and Age. Add a constructor to initialize them and display details in a separate method .

namespace Assignment_03
{
    internal class StudentData
    {


        private int Id { get; set; }
        private String Name { get; set; }
        public StudentData(int id, string name )
        {
            Id = id;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Student data \n Id : {Id}\n Name : {Name}");
        }
    }
}



