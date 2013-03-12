//1.Define a class Student, which contains data  about a student – three names, SSN, permanent address, 
//    mobile phone e-mail, course, specialty, university, faculty. Use  enumeration for the specialties,
//        universities and faculties. Override standard methods, inherited by  System.Object – Equals(),
//    ToString(), GetHashCode() and operators == and !=.

//2.Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's 
//fields into a new object of type Student.

//3.Implement the  IComparable<Student> interface to compare students by names (as first criteria, in
//    lexicographic order) and by social security number (as second criteria, in increasing order).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Student
{
    public enum Specialty
    {
        MacroEconomics,
        Economics,
        Tourism,
        MIO
    }

    public enum University
    {
        UNWE,
        SU,
        Telerik,
        NBU
    }

    public enum Faculty
    {
        Informatics,
        Marketing,
        Menagement
    }

    public class Student : ICloneable, IComparable<Student>
    {

        //-------------FIELDS--------------//
        private string names;
        private int ssn;
        private string adress;
        private string mobilePhone;
        private string e_mail;
        private int course;
        public Specialty specialty;
        public University university;
        public Faculty faculty;


        //----------------PROPERTIES-----------------//
        public string Names
        {
            get { return this.names; }
            set { this.names = value; }
        }

        public int SSN
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }
        public string Adress
        {
            get { return this.adress; }
            set { this.adress = value; }
        }
        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set { this.mobilePhone = value; }
        }
        public string E_mail
        {
            get { return this.e_mail; }
            set { this.e_mail = value; }
        }
        public int Course
        {
            get { return this.course; }
            set { this.course = value; }
        }
        

        //----------CONSTRUCTORS--------------//
        public Student()
        {
            this.Names = null;
            this.SSN = 0;
            this.Adress = null;
            this.MobilePhone = null;
            this.E_mail = null;
            this.Course = 0;
            this.specialty = Specialty.Economics;
            this.university = University.Telerik;
            this.faculty = Faculty.Menagement;
        }

        public Student(string names, int ssn, string adress, string mobilePhone, string e_mail, int course, Specialty specialty, University university, Faculty faculty)
        {
            this.Names = names;
            this.SSN = ssn;
            this.Adress = adress;
            this.MobilePhone = mobilePhone;
            this.E_mail = e_mail;
            this.Course = course;
            this.specialty = specialty;
            this.university = university;
            this.faculty = faculty;
        }

        //------------OVERIDING-------------------//
        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (this.Names != student.Names
                || this.SSN != student.SSN
                || this.Adress != student.Adress
                || this.MobilePhone != student.MobilePhone
                || this.E_mail != student.E_mail
                || this.Course != student.Course
                || this.specialty != student.specialty
                || this.university != student.university
                || this.faculty != student.faculty)
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Equals(firstStudent, secondStudent));
        }

        public override int GetHashCode()
        {
            return this.Names.GetHashCode()^this.SSN.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Names);
            sb.AppendLine(this.SSN.ToString());
            sb.AppendLine(this.Adress);
            sb.AppendLine(this.MobilePhone);
            sb.AppendLine(this.E_mail);
            sb.AppendLine(this.Course.ToString());
            sb.AppendLine(this.specialty.ToString());
            sb.AppendLine(this.university.ToString());
            sb.AppendLine(this.faculty.ToString());
            return sb.ToString();
        }


        //---------------CLONNING------------------//
        public Student Clone() //implements deep clone
        {
            return new Student(this.Names, this.SSN, this.Adress, this.MobilePhone, this.E_mail, 
                                this.Course, this.specialty, this.university, this.faculty);
        }

        object ICloneable.Clone() //implicit interface implementation
        {
            return this.Clone();
        }


        //--------------COMPARISSON-------------------//
        public int CompareTo(Student secondStudent)
        {
            if (this.Names != secondStudent.Names)
            {
                return this.Names.CompareTo(secondStudent.Names); //return -1
            }
            else //if (this.SSN != secondStudent.SSN)
            {
                return this.SSN.CompareTo(secondStudent.SSN);
            }
        }
    }
}
