using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectInt
{
    [TestClass]
    public class DoesDoubleExists_Test
    {
        [TestMethod]
        public void Check_Double_ReturnsTrue()
        {
            //Arrange
            var sut = new DoesDoubleExist();
            //var input = new int[] {3,1,7,11};//for false result
            var input = new int[] { 10, 2, 5, 3 }; //true
            var expect = true;
            //Act
            var actual = sut.Check(input);
            //Assert
            Assert.AreEqual(expect, actual);
        }
    }
}
