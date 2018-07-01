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
            if(result == 0)
            {
                result = this.GradeLevel.CompareTo(that.GradeLevel);
            }
            return result;
        }
    }
}
