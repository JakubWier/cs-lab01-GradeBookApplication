using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    internal class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted) {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade) {
            return 'Z';
        }

        public override void CalculateStatistics() {
            if(Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");

            base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name) {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");

            base.CalculateStudentStatistics(Name);
        }
    }
}
