using Calculator;

namespace FirstUnitTest
{
    public class MathCalTest
    {
        [Fact]
        public void TestAdd2Numbers()
        {
            MathCal cal = new MathCal();
            int expectedValue = 6;

            int actualValue = cal.sum2Numbers(2, 4);
            Assert.Equal(expected: expectedValue, actual: actualValue);
        }
        [Fact]
        public void TestDivide2Numbers()
        {
            MathCal cal = new MathCal();
            int expectedValue = 6;

            int actualValue = cal.sum2Numbers(6, 2);
            Assert.Equal(expected: expectedValue, actual: actualValue);
        }
        [Fact]
        public void TestDivide2Numbers2() {
            MathCal cal = new MathCal();                      
            Assert.Equal(expected: 3.5, actual: cal.devide2Numbers(7, 2));
        }
        [Fact]
        public void TestDivideByZero()
        {
            MathCal cal = new MathCal();
            string expectedErrorMessage = "Error Devide By Zero";
            var exResult = Assert.Throws<ArithmeticException>(()=>cal.devide2Numbers(2,0));
            Assert.Equal(expected: expectedErrorMessage, exResult.Message);

        }
    }   
}