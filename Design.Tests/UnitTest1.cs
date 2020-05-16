using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test,Order(2)]
        public void Test1()
        {
            Assert.Pass();

        }
        
        [Test,Order(1)]
        public void Test2()
        {
           // Assert.AreEqual(2,1);
            SingleTon s1=new SingleTon();
            SingleTon s2=new SingleTon();
            Assert.AreNotEqual(s1,s2);
        }

         [Test,Order(3)]
        public void Test3()
        {
            Assert.Fail();
            
        }
    }
}