﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook: BaseGradeBook
    {
        //public GradeBookType Ranked;

        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");

            var threshold = (int)Math.Ceiling(Students.Count * 0.2);//20% of the student count
            var grades = Students.OrderByDescending(e=> e.AverageGrade).Select(e=> e.AverageGrade).ToList();
           
            if (grades[threshold - 1]<= averageGrade)
                return 'A';
            else if(grades[(threshold*2) - 1] <= averageGrade)
                return 'B';
            else if (grades[(threshold*3) - 1] <= averageGrade)
                return 'C';
            else if (grades[(threshold*4)- 1] <= averageGrade)
                return 'D';

            return 'F';

        }
        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
              base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
              base.CalculateStudentStatistics(name);
        }

        /*
                public double[] OrderByDescendingAverageGrade()
                {
                    double[] gradeList = new double[Students.Count];
                   // double maxGrade = double.MinValue;
                    var i = 0;
                    foreach (var student in Students)
                    {
                        gradeList[i++] = student.AverageGrade;
                    }
                    // Sort array in ascending order. 
                    Array.Sort(gradeList);

                    // reverse array 
                    Array.Reverse(gradeList);

                    return gradeList;
                }
                */
    }
}
