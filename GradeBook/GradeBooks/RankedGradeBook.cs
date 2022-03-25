using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    internal class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted) {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade) {
            return base.GetLetterGrade(averageGrade);
        }

        public override void CalculateStatistics() {
            base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name) {
            base.CalculateStudentStatistics(name);
        }
    }
}
