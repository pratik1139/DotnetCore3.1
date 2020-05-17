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
        //    // Assert.AreEqual(2,1);
        //     SingleTon s1=new SingleTon();
        //     SingleTon s2=new SingleTon();
            int a=SingleTon.Instance.a;
            int b=SingleTon.Instance.a;
            SingleTon.Instance.a=50;
            
            Assert.AreEqual(a,b);
            Assert.AreEqual(a,10);
            Assert.AreEqual(b,10);
        }

         [Ignore("test "),Order(3)]
        public void Test3()
        {
            Assert.Fail();
            
        }
    }
}