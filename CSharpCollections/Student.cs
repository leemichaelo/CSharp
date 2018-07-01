using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int GradeLevel { get; set; }

        public int CompareTo(Student that)
        {
            //Compare names first
            int result = this.Name.CompareTo(that.Name);

            //If names are the same, compare against gradelevel
            if (result == 0)
            {
                result = this.GradeLevel.CompareTo(that.GradeLevel);
            }
            return result;
        }

        //Override hashcode so that students with the same name and grade level arent duplicated
        public override int GetHashCode()
        {
            return Name.GetHashCode() + GradeLevel.GetHashCode();
        }

        //Override equals so that students with the same name and gradelevel are not equal
        public override bool Equals(object obj)
        {
            bool valueToReturn = true;
            Student that = obj as Student;

            if (that == null)
            {
                valueToReturn = false;
            }
            else
            {
                valueToReturn = this.Name == that.Name && this.GradeLevel == that.GradeLevel;
            }

            return valueToReturn;
        }
    }
}
