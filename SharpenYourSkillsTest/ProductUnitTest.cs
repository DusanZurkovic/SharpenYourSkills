using NUnit.Framework;
using SharpenYourSkills.Model;

namespace SharpenYourSkillsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TaxTest()
        {
            var product = new Product("sa", 123, 20);

            //Assert
            Assert.That(product.price, Is.EqualTo(20 + (20 * 1 / 5)));
        }

        [Test]
        public void DiscountTest()
        {
            //Arrange
            var price = 20;
            var tax = 21;
            var product = new Product("sa", 123, price,15,tax);
            
            //Assert
            Assert.That(product.discount, Is.EqualTo(price * 15 / 100));
        }
    }
}