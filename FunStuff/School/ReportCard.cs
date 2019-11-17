using System.Linq;

namespace FunStuff.School
{
    public class ReportCard
    {
        Student _student;

        public ReportCard(Student student)
        {
            _student = student;
        }

        public string GenerateHeading()
        {
            decimal gpa = GetGPA();

            string heading = _student.LastName + ", " + _student.FirstName
                + " " + _student.DOB.ToShortDateString()
                + " " + gpa.ToString()
                + " " + GetIndicator(gpa);
            return heading;
        }
        private decimal GetGPA()
        {
            return _student.Grades.Average(g => g);
        }

        private string GetIndicator(decimal gpa)
        {
            return gpa >= 3.5m ? "***" : "";
        }
    }
}


//public string GenerateHeading()
//{
//    decimal gpa = GetGPA();

//    string heading = _student.LastName + ", " + _student.FirstName 
//        + " " + _student.DOB.ToShortDateString()
//        + " " + gpa.ToString();
//    return heading;
//}


//public string GenerateHeading()
//{
//    decimal gpa = GetGPA();

//    string heading = _student.LastName + ", " + _student.FirstName 
//        + " " + _student.DOB.ToShortDateString()
//        + " " + gpa.ToString()
//        + " " + GetIndicator(gpa);
//    return heading;
//}

