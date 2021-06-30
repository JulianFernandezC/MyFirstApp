using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace MyFirstApp.Tests
{
    [TestClass()] // esto se llama custom attributes, test class le indica al compitlador que es una clase de testeo
    public class CalculatorTests
    {
        [TestMethod()] // indica que es un metodo de test, cada uno es una prueba dentro de la clase de prueba
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            IsTrue(calculator.Add(2, 2) == 4); //tambien se puede pasar un arreglo de valores
        }

        [TestMethod()]
        public void SubstractTest()
        {
            Calculator calculator = new Calculator();
            IsTrue(calculator.Substract(2, 2) == 0);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            IsTrue(calculator.Multiply(2, 2) == 4);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();
            IsTrue(calculator.Divide(2, 2) == 1);
        }
    }
}