﻿using GradeBook.Enums;
using System;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {



        public RankedGradeBook(string name, bool IsWeight) : base(name, IsWeight)
        {
            Type = GradeBookType.Ranked;

        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (this.Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if (averageGrade >= 80)
                {
                    return 'A';
                }
                else if (averageGrade >= 60)
                {
                    return 'B';
                }
                else if (averageGrade >= 40)
                {
                    return 'C';
                }
                else if (averageGrade >= 20)
                {
                    return 'D';
                }
                else
                {
                    return 'F';
                }





            }


        }
        public override void CalculateStatistics()
        {

            if (this.Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else if (this.Students.Count >= 5)
            {
                base.CalculateStatistics();
            }
        }
        public override void CalculateStudentStatistics(string name)
        {

            if (this.Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else if (this.Students.Count >= 5)
            {
                base.CalculateStudentStatistics(name);
            }
        }


    }

}




