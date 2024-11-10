using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Business_Logic_Layer
{
    internal class Student
    {
        int studentNumber;
        string firstName;
        string lastName;
        DateTime dateOfBirth;
        int age;
        string gender;
        string phone;
        string address;
        string course;

        public Student()
        {
            
        }

        public Student(int stdNum)
        {
            this.StudentNumber = stdNum;
        }

        public Student(int studentNumber, string firstName, string lastName, DateTime dateOfBirth, int age, string gender, string phone, string address, string course)
        {
            this.studentNumber = studentNumber;
            this.age = age;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.course = course;
            this.phone = phone;
            this.address = address;
            this.dateOfBirth = dateOfBirth;
        }

        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public int Age { get => age; set => age = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Course { get => course; set => course = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
    }
}
