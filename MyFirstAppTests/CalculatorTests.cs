using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Tests
{
    [TestClass()] // esto se llama custom attributes, test class le indica al compitlador que es una clase de testeo
    public class CalculatorTests
    {
        [TestMethod()] // indica que es un metodo de test, cada uno es una prueba dentro de la clase de prueba
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Add(2, 2) == 4); //tambien se puede pasar un arreglo de valores
        }

        [TestMethod()]
        public void SubstractTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Substract(2, 2) == 0);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Multiply(2, 2) == 4);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Divide(2, 2) == 1);
        }
    }
}