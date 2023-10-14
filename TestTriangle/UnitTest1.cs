using TriangleLAB1Name;

namespace TestTriangle
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test2() //Тест на неправильный треугольник
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "не треугольник";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("3", "36", "5");
            Assert.AreEqual(expect, actual); 
        }

        [Test]
        public void Test3() //Тест на тип треугольника - равносторонний
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "Равносторонний";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("3", "3", "3");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test4() // Тест на 0-вое значение
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "не треугольник";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("3", "0", "5");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test5() //Тест на тип треугольника - равнобедренный num1
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "Равнобедренный";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("3", "4", "3");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test6() //Тест на тип треугольника - равнобедренный num2
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "Равнобедренный";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("4", "3", "3");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test7() //Тест на пустые значения
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "не треугольник";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("", "6", "6");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test8() //Тест на тип треугольника - разносторонний num1
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "Разносторонний";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("3", "4", "5");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test9() //Тест на тип треугольника - разносторонний num2
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "Разносторонний";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("5", "4", "3");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test10() //Тест на маленькие значения (меньше единицы)
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "Равносторонний";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("0,4", "0,4", "0,4");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test11() //Тест на дробные числа
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "Разносторонний";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("8,5", "8,3", "8,2");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test12() //Тест на точку
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "Разносторонний";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("5,7", "6,2", "9,4");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test13() //Тест на символы
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "не треугольник";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("10", ";№4", "!5");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test14() //Тест на буквы 
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "не треугольник";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("sdrZH", "3", "5");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test15() //Тест на отрицательное значение
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "не треугольник";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("-3", "7", "4");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test16() //Тест на значение 0
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "не треугольник";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("0", "0", "3");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test17() //Тест на большие числа
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "Равносторонний";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("3000000000000000000000000", "3000000000000000000000000", "3000000000000000000000000");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test18() //Тест на значение 0
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "не треугольник";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("0", "0", "0");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test19() //Тест на пустые значения
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "не треугольник";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("", "", "");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test20() //Тест на пустые значения
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "не треугольник";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = TriangleClass.GoTriangle("3", "0", "0");
            Assert.AreEqual(expect, actual);
        }
    }
}