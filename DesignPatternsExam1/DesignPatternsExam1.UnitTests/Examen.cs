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
    }
}
