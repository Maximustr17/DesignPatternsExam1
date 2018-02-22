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
            ProcesadorRomano.Convierte("IIII");
        }
    }
}
