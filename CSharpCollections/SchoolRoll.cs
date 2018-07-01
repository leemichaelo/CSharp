using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class SchoolRoll
    {
        private HashSet<Student> _students = new HashSet<Student>();

        //IEnumberable makes the list read only
        public IEnumerable<Student> Students { get { return _students; } }

        //By passing in "Ienumberable", it allows all collections to be passed in since all collections inherit from ienumberable
        public void AddStudents(IEnumerable<Student> students)
        {
            _students.UnionWith(students);
        }
    }
}
