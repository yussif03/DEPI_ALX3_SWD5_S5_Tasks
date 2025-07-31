using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Student
    {
        #region Fields
        private int _id;
        private string _name;
        private int _age;
        private string _gender;
        private string _phone;
        private string _major;
        private float _gpa;
        #endregion

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Major
        {
            get { return _major; }
            set { _major = value; }
        }
        public float GPA
        {
            get { return _gpa; }
            set { _gpa = value; }
        }
        public string getStudentInfo()
        {
            return $"ID: {_id}, \nName: {_name}, \nAge: {_age}, \nGender: {_gender}, \nPhone: {_phone}," +
                $"\nMajor: {_major}, \nGPA: {_gpa}";
        }
        #endregion
    }
}
