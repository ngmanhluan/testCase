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
        public void TestDivde2Numbers()
        {
            MathCal cal = new MathCal();
            int expectedValue = 6;

            int actualValue = cal.sum2Numbers(6, 2);
            Assert.Equal(expected: expectedValue, actual: actualValue);
        }
        [Fact]
        public void TestDivde2Numbers2() {
            MathCal cal = new MathCal();                      
            Assert.Equal(expected: 3.5, actual: cal.devide2Numbers(7, 2));
        }
        public void TestDivdeByZero()
        {
            MathCal cal = new MathCal();

        }
    }   
}