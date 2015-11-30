using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void UppercaseStrings()
        {
            string name = "caroline";
            name = name.ToUpper();

            Assert.AreEqual("CAROLINE", name);

        }

        [TestMethod]
        public void ValueTypesPassedByValueRefKeyword()
        {
            int y = 45;
            IncrementValueRefKeyWord(ref y);
            Assert.AreEqual(47, y);
        }

        private void IncrementValueRefKeyWord(ref int number) {
            number += 2;

        }

        [TestMethod]
        public void ValueTypesPassedByValue()
        {
            int x = 46;
            IncrementValue(x);

            Assert.AreEqual(46, x);
        }

        private void IncrementValue(int number)
        {
            number += 1;

        }

        [TestMethod]
        public void ReferenceTypesPassedByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
            GiveBookAName(book2);

            Assert.AreEqual("A Gradebook", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A Gradebook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Valeria";
            string name2 = "valeria";

            bool result = String.Equals(name1, name2,StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);

        }


        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 40;

            Assert.AreNotEqual(x1, x2);

        }

        [TestMethod]
        public void GradesBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "What a wonderful day!";

            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
