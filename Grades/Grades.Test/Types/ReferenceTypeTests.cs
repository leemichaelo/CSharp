using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void ValueTypesPassbyValue()
        {
            int x = 46;

            IncrementNumber(x);
            Assert.AreEqual(46, x);
        }
        private void IncrementNumber(int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookName(book2);
            Assert.AreEqual("A Gradebook.", book1.Name);

        }
        private void GiveBookName(GradeBook book)
        {
            book.Name = "A Gradebook.";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Lee";
            string name2 = "lee";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }
        // testm is a snippit for test method
        [TestMethod]
        public void IntVariablesHoldaValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldaReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Lee's Grade Book";
            Assert.AreEqual(g1.Name, g2.Name);
       
        }
    }
}
