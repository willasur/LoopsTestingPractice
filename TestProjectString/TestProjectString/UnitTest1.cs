using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectString
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var sut = new ReturnStringReversed();
            var input = new string[] { "hello", "h", "great race"};
            
            var expect = true;

            //Act
            var actual = sut.Check(input);
            //Assert
            Assert.AreEqual(expect, actual);

        }
    }
}
