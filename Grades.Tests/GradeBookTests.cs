using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
  public  class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(15);
            book.AddGrade(95);

            GradeStatistics statistics = book.computeStatistics();

            Assert.AreEqual(95, statistics.HighestGrade);

        }

        [TestMethod]
        public void ComputeLowestgGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(15);
            book.AddGrade(95);

            GradeStatistics statistics = book.computeStatistics();

            Assert.AreEqual(15, statistics.LowestGrade);
        }
    }
}
