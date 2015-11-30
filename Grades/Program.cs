using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {


            SpeechSynthesizer synt = new SpeechSynthesizer();
            synt.Speak("Hello, this is a C# course");

            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(85.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.computeStatistics();

            Console.WriteLine("Average = " + stats.AverageGrade);
            Console.WriteLine("Highest = " + stats.HighestGrade);
            Console.WriteLine("Lowest = " + stats.LowestGrade);


        }
    }
}
