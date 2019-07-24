using GradeBook;
using System;
using Xunit;


namespace Gradebook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var book = new Book();
            book.AddGrade(89.1);
            book.AddGrade(90.6);
            book.AddGrade(67.9);

            //act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(82.5, result.Average, 1);
            Assert.Equal(90.6, result.High, 1);
            Assert.Equal(67.9, result.Low,1 );
        }
    }
}
