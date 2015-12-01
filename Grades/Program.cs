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

            book.NameChanged = new NameChangedDelegate(OnNameChanged);
            book.Name = "Xavier";
            book.Name = "Joseph";

            book.AddGrade(90);
            book.AddGrade(85.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.computeStatistics();

            WriteResult("Average", Convert.ToString(stats.AverageGrade) );
            WriteResult("Highest", Convert.ToString( stats.HighestGrade));
            WriteResult("Lowest", Convert.ToString( stats.LowestGrade));
            WriteResult("Letter Grade", stats.LetterGrade);
            WriteResult("Description", stats.Description);
        

        }

        static void WriteResult (string description, string result)
        {
            Console.WriteLine($"{description}: {result} ", description,result);
        }

        static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($" Grades is changing the name from {existingName} to {newName}");
        }
    }
}
