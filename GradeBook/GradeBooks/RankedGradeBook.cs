using GradeBook.Enums;
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
                for (int i = 0; i < 4; i++)
                {


                }
                return base.GetLetterGrade(averageGrade);




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




