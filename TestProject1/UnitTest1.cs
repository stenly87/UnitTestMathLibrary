using MathLibrary;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DistanceBetweenPointsReturnExpectedResult()
        {
            // AAA
            // Arange - подготовка
            // Act - вызов тестируемой функции
            // Assert - проверка результата
           
            Geometry geometry = new Geometry();    // Arange
            double x1 = 1, x2 = 5, y1 = 0, y2 = 0; // Arange
            double expectedResult = 4;             // Arange

            double result = geometry.DistanceBetweenPoints(x1,y1,x2,y2); // Act

            Assert.AreEqual(expectedResult, result, 0.1); // Assert
        }

        [Test]
        public void DistanceBetweenPoints0PointsReturn0()
        {
            // Arange
            Geometry geometry = new Geometry();    
            double x1 = 0, x2 = 0,
                y1 = 0, y2 = 0;     
            double expectedResult = 0;             

            double result = geometry.DistanceBetweenPoints(x1, y1, x2, y2); // Act

            Assert.AreEqual(expectedResult, result, 0.1);
        }

        [Test]
        public void Kvadratnoye_Uravneniye_TestResult_Is_NaN_Where_A_is_Zero()
        {
            Geometry geometry = new Geometry();
            int a = 0, b = int.MaxValue, c = 0;

            var result = geometry.KvadratnoyeUravneniye(a, b, c);

            Assert.AreEqual(double.NaN, result.Item1);
            Assert.AreEqual(double.NaN, result.Item2);
        }

        [Test]
        public void Kvadratnoye_Uravneniye_TestResult_Is_Normal_Where_B_is_MaxIntValue()
        {
            Geometry geometry = new Geometry();
            int a = 1, b = int.MaxValue, c = 0;

            var result = geometry.KvadratnoyeUravneniye(a, b, c);

            Assert.AreEqual(-1073741823, result.Item1);
            Assert.AreEqual(-1073741824, result.Item2);
        }
    }
}