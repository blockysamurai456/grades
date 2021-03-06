﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRADES
{
    public class BookOfGrades
    {
        public BookOfGrades()
        {
            
            grades = new List<float>();
        }

        public int NumOfGrades()
        {
            return grades.Count;
        }

        public Gstats ComputeStatistics()
        {
            Gstats stats = new Gstats();
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

        public void AddGrade(float grade)
        {
            grades.Add(grade);

        }
        public string Name;

        private List<float> grades;
    }
}
