using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class SchoolRoll
    {
        private List<Student> _students = new List<Student>();

        //By passing in "Ienumberable", it allows all collections to be passed in since all collections inherit from ienumberable
        public void AddStudents(IEnumerable<Student> students)
        {
            _students.AddRange(students);
        }
    }
}
