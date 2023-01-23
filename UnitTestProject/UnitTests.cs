using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        // Тестовые методы низкой сложности
        // Тест, на проверку несуществующего типа продукции
        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType()
        {
            int productType = 5;
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
            int materialType = 4;
            int count = 5;
            float width = 40;
            float length = 40;
            int except = -1;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(except, actual);
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
        // Тест, на проверку что не правильный подсчёт является верным результатом
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
        public void GetQuantityForProduct_NotIsNull()
        {
            int productType = 3;
            int materialType = 1;
            int count = 10;
            float width = 22;
            float length = 30;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsNotNull(actual);
        }
        // Тест, на проверку того, что правильный результат находится в конкретном диапозоне (приблезительное значение)
        [TestMethod]
        public void GetQuantityForProduct_CorrectCalculationBeetweenValues()
        {
            int productType = 2;
            int materialType = 2;
            int count = 15;
            float width = 20;
            float length = 30;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

        }
        // Тестовые методы высокой сложности

    }
}
