using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController _controller;

        [SetUp]
        public void SetUp()
        {
            _controller = new CustomerController();
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var result = _controller.GetCustomer(0);
            
            //Exactly NotFound
            Assert.That(result, Is.TypeOf<NotFound>());
            
            //NotFound or or one of its derivatives
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }
        
        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {   
            var result = _controller.GetCustomer(1);
            
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}