using Microsoft.VisualStudio.TestTools.UnitTesting;
using DIO.Avacloud.Entidades;

namespace DIO.Avacloud.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FullName_Test_Is_Valid()
        {
            // Arrange
            Customer customer = new Customer()
            {
                FirstName = "Marcus",
                LastName = "Campos",
            };

            string expected = "Marcus Campos";
            // Act
            string result = customer.FullName;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Lastname_is_Empty()
        {
            // Arrange
            Customer customer = new Customer()
            {
                FirstName = "Marcus",
            };

            string expected = "Marcus";
            // Act
            string result = customer.FullName;
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
