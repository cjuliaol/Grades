﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
   public class GradeBook
    {

        
        public string Name {

            get {
                return _name;
            } 
            set
            {
                if ( !String.IsNullOrEmpty(value) )
                {
                    if ( _name != value)
                    {
                        NameChanged(_name, value);
                    }

                    _name = value;
                }
                
            }
        }

        public NameChangedDelegate NameChanged;


        private string _name;

        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades;

        public GradeStatistics computeStatistics ()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }
    }
}
