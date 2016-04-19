using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyBigInteger;
using System.Linq;
namespace UnitTestMyInt
{
    [TestClass]
    public class UnitTest1
    {

        MyInt mintPos, mintNeg;
        long numLong = 123;
        String numStringPos = "123";
        String numStringNeg = "-987";
        [TestInitialize]
        public void init()
        {
            mintPos = new MyInt(numStringPos);
            mintNeg = new MyInt(numStringNeg);
        }
        [TestMethod]
        public void TestCreateFromLong()
        {            
            MyInt mintPos = new MyInt(123);
            Assert.IsNotNull(mintPos);
            Assert.AreEqual("123", mintPos.ToString());
            MyInt mintNeg = new MyInt(-987);
            Assert.IsNotNull(mintNeg);
            Assert.AreEqual("-987", mintNeg.ToString());
        }
        [TestMethod]
        public void TestCreateFromString()
        {
            Assert.IsNotNull(mintPos);
            Assert.AreEqual(numStringPos, mintPos.ToString());
           Assert.IsNotNull(mintNeg);
            Assert.AreEqual(numStringNeg, mintNeg.ToString());
        }
        [TestMethod]
        public void TestToString()
        {
            Assert.AreEqual(numStringPos, mintPos.ToString());
            Assert.AreEqual(numStringNeg, mintNeg.ToString());
        }
        [TestMethod]
        public void TestToLong()
        {
            Int64 nlong = 123;
            Assert.AreEqual(nlong, mintPos.toLong());
        }
        [TestMethod]
        public void TestToArr()
        {
            byte[] b = {1,2,3};
            bool pass=false;
            if (b.SequenceEqual(mintPos.ToArr()))
                pass = true;
            Assert.AreEqual(true, pass);
            //Assert.AreEqual(numStringPos, mintNeg.ToArr());
        }
        [TestMethod]
        public void TestAbs()
        {
            mintPos = new MyInt(numStringPos);
            Assert.AreEqual("123", mintPos.abs());
            mintNeg = new MyInt(numStringNeg);
            Assert.AreEqual("987", mintNeg.abs());
        }
        [TestMethod]
        public void TestAdd()
        {
            MyInt a=new MyInt("129"),b=new MyInt("46");
            Assert.AreEqual("175", a.add(b).ToString());
        }
        /*
          [TestMethod]
         public void TestSubtract()
         {
         MyInt a = new MyInt("5"), b = new MyInt("7");
         Assert.AreEqual("-2", a.subtract(b));
         MyInt z = new MyInt("9"), x = new MyInt("4");
         Assert.AreEqual("5", z.subtract(x));
         MyInt c = new MyInt("55"), v = new MyInt("7");
         Assert.AreEqual("48", c.subtract(v));
         }
         [TestMethod]
         public void TestMyltiply()
         {
             MyInt a = new MyInt("123"), b = new MyInt("32");
             Assert.AreEqual("3936", a.myltiply(b));
         }
         [TestMethod]
         public void TestDivide()
         {
         MyInt a = new MyInt("15"), b = new MyInt("5");
         Assert.AreEqual("3", a.divide(b));
         MyInt z = new MyInt ("15",) x = new MyInt ("20");
         Assert.AreEqual("0.75", z.divide(x));
         }
         [TestMethod]
         public void TestMax()
         {
             MyInt a = new MyInt("135"), b = new MyInt("654");
             Assert.AreEqual("654", a.max(b));
         }
         [TestMethod]
         public void TestMin()
         {
             MyInt a = new MyInt("123"), b = new MyInt("14");
             Assert.AreEqual("14", a.min(b));
         }
         [TestMethod]
         public void TestCompareto()
         {
             MyInt a = new MyInt("anilam"), b = new MyInt("animal");
             Assert.AreEqual("ani", a.compareto(b));
         }
         [TestMethod]
         public void TestGcd()
         {
             MyInt a = new MyInt("70"), b = new MyInt("105");
             Assert.AreEqual("35", a.gcd(b));
         }*/
    }
}
