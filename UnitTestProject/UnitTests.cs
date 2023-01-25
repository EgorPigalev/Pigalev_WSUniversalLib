using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        // Тестовые методы низкой сложности
        // Тест, на проверку, что результат это положительное число
        [TestMethod]
        public void GetQuantityForProduct_ResultIsPositive()
        {
            int productType = 3;
            int materialType = 2;
            int count = 7;
            float width = 10;
            float length = 50;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsTrue(actual >= 0);
        }
        // Тест, на проверку правильного подсчёта
        [TestMethod]
        public void GetQuantityForProduct_CorrectCalculation()
        {
            int productType = 3;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = 45;
            int except = 114147;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(except, actual);
        }
        // Тест, на проверку что не правильный подсчёт не является верным результатом
        [TestMethod]
        public void GetQuantityForProduct_NotCorrectCalculation()
        {
            int productType = 2;
            int materialType = 2;
            int count = 7;
            float width = 20;
            float length = 40;
            int except = 12000;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreNotEqual(except, actual);
        }
        // Тест, на проверку того, что возвращается правильный тип данных
        [TestMethod]
        public void GetQuantityForProduct_CorrcectType()
        {
            int productType = 1;
            int materialType = 2;
            int count = 10;
            float width = 22;
            float length = 50;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsInstanceOfType(actual, typeof(int));
        }
        // Тест, на проверку того, что неправильный тип данных не является результатом выполнения метода
        [TestMethod]
        public void GetQuantityForProduct_NotCorrcectType()
        {
            int productType = 2;
            int materialType = 1;
            int count = 5;
            float width = 10;
            float length = 20;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsNotInstanceOfType(actual, typeof(float));
        }
        // Тест, на проверку того, что результат не равен null
        [TestMethod]
        public void GetQuantityForProduct_ResultNotIsNull()
        {
            int productType = 3;
            int materialType = 1;
            int count = 10;
            float width = 22;
            float length = 30;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsNotNull(actual);
        }
        
        // Тест, на проверку того, что при вводе всех корректных значений, метод не возвращает значение -1
        [TestMethod]
        public void GetQuantityForProduct_CorrectResultIsNotWrong()
        {
            int productType = 1;
            int materialType = 1;
            int count = 5;
            float width = 20;
            float length = 40;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsFalse(actual == -1);
        }
        // Тест, на проверку того, что возвращается правильный тип данных при использование дробных входных данных
        [TestMethod]
        public void GetQuantityForProduct_CorrcectTypeFloatNumbers()
        {
            int productType = 2;
            int materialType = 2;
            int count = 15;
            float width = (float)20.25;
            float length = (float)40.20;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsInstanceOfType(actual, typeof(int));
        }
        // Тест, на проверку того, что результат не выходит за пределы int
        [TestMethod]
        public void GetQuantityForProduct_CorrectCalculationTypeMaxAndMinValue()
        {
            int productType = 3;
            int materialType = 2;
            int count = 150;
            float width = 2000;
            float length = 4500;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsTrue(actual > -2147483648 && actual < 2147483647);
        }
        // Тест, на проверку того, что результат вычисления округляется в большею сторону
        [TestMethod]
        public void GetQuantityForProduct_CorrectCalculationWhenFractionalPartIsLessThan5()
        {
            int productType = 1;
            int materialType = 1;
            int count = 10;
            float width = 5;
            float length = 25;
            int except = 1380;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(except, actual);
        }
        // Тестовые методы высокой сложности
        // Тест, на проверку, что при выходе за пределы int он выведет -1
        [TestMethod]
        public void GetQuantityForProduct_OverlyLargeNumbers()
        {
            int productType = 3;
            int materialType = 1;
            int count = 5;
            float width = 9999999999999999999;
            float length = 9999999999999999999;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsTrue(-1 == actual);
        }
        // Тест, на проверку, что при использование самых мальниких чисел, данные будут корректны
        [TestMethod]
        public void GetQuantityForProduct_SmallestNumbers()
        {
            int productType = 1;
            int materialType = 1;
            int count = 0;
            float width = 0;
            float length = 0;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(0, actual);
        }
        // Тест, на проверку несуществующего типа продукции
        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType()
        {
            int productType = 500;
            int materialType = 1;
            int count = 5;
            float width = 40;
            float length = 40;
            int except = -1;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(except, actual);
        }
        // Тест, на проверку несуществующего типа материала
        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterialType()
        {
            int productType = 2;
            int materialType = 400;
            int count = 5;
            float width = 40;
            float length = 40;
            int except = -1;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(except, actual);
        }
        // Тест, на проверку того, что при вводе неправильной ширины метод возвращает значение (-1)
        [TestMethod]
        public void GetQuantityForProduct_NotCorrectlyWidth()
        {
            int productType = 2;
            int materialType = 2;
            int count = 15;
            float width = -20;
            float length = 30;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsTrue(actual == -1);
        }
    }
}
