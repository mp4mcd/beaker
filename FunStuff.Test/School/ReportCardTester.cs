using FunStuff.School;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunStuff.Test.School
{
    [TestClass]
    public class ReportCardTester
    {
        [TestMethod]
        public void ShowGoodGpaIndicator()
        {
            // Arrange
            Student janice = new Student()
            {
                FirstName = "Janice",
                LastName = "Zoomer",
                DOB = new DateTime(2007, 8, 10),
                Grades = new List<decimal> { 3, 3.6m, 4, 4 }
            };

            ReportCard reportCard = new ReportCard(janice);

            // Act
            string heading = reportCard.GenerateHeading();

            // Assert
            Assert.IsTrue(heading.EndsWith("***"));
        }

    }
}

//[TestMethod]
//public void ShowGoodGpaIndicator()
//{
//    // Arrange
//    Student janice = new Student()
//    {
//        FirstName = "Janice",
//        LastName = "Zoomer",
//        DOB = new DateTime(2007, 8, 10),
//        Grades = new List<decimal> { 3, 3.6m, 4, 4 }
//    };

//    ReportCard reportCard = new ReportCard(janice);

//    // Act
//    string heading = reportCard.GenerateHeading();

//    // Assert
//    Assert.IsTrue(heading.EndsWith("***"));
//}
