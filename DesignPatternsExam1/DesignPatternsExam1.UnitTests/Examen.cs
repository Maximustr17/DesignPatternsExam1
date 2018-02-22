using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsExam1.ConsoleApp;

namespace DesignPatternsExam1.UnitTests
{
    [TestClass]
    public class Examen
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, ProcesadorRomano.Convierte(""));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
            "It should throw an exeption when is IIII")]
        public void TestMethod2()
        {
            Assert.AreEqual(1, ProcesadorRomano.Convierte("I"));
            Assert.AreEqual(2, ProcesadorRomano.Convierte("II"));
            Assert.AreEqual(3, ProcesadorRomano.Convierte("III"));
            Assert.AreEqual(5, ProcesadorRomano.Convierte("V"));
            Assert.AreEqual(10, ProcesadorRomano.Convierte("X"));
            Assert.AreEqual(50, ProcesadorRomano.Convierte("L"));
            Assert.AreEqual(100, ProcesadorRomano.Convierte("C"));
            Assert.AreEqual(500, ProcesadorRomano.Convierte("D"));
            Assert.AreEqual(1000, ProcesadorRomano.Convierte("M"));
            ProcesadorRomano.Convierte("IIII");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception),
            "It should throw an exeption when more than 3 I")]
        public void TestMethod3()
        {
            ProcesadorRomano.Convierte("IIII");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception),
            "It should throw an exeption when more than a L")]
        public void TestMethod4()
        {
            ProcesadorRomano.Convierte("LL");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception),
            "It should throw an exeption when more than a D")]
        public void TestMethod5()
        {
            ProcesadorRomano.Convierte("DD");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception),
            "It should throw an exeption when more than 3 X")]
        public void TestMethod6()
        {
            ProcesadorRomano.Convierte("XXXX");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception),
            "It should throw an exeption when more than 3 C")]
        public void TestMethod7()
        {
            ProcesadorRomano.Convierte("CCCC");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception),
            "It should throw an exeption when more than 3 C")]
        public void TestMethod8()
        {
            ProcesadorRomano.Convierte("XXL");
        }
    }
}
