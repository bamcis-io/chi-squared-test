using System;
using Xunit;

namespace chi_squared_test.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void RouletteTest()
        {
            // ARRANGE
            int[] observations = new int[] { 192, 163, 25 };
            double[] probabilities = new double[] { (18.0 / 38), (18.0 / 38), (2.0 / 38) };

            // ACT
            ChiSquaredTestResult result = ChiSquaredTest.Run(observations, probabilities);

            // ASSERT
            Assert.Equal(3.6556, Math.Round(result.ChiSquaredValue, 4));
            Assert.Equal(2, result.DegreesOfFreedom);
            Assert.Equal(0.1608, Math.Round(result.PValue, 4));
        }

        [Fact]
        public void MultipleChoiceAnswersTest()
        {
            // ARRANGE
            int[] observations = new int[] { 20, 20, 25, 35 };
            double[] probabilities = new double[] { 1.0 / 4, 1.0 / 4, 1.0 / 4, 1.0 / 4 };

            // ACT
            ChiSquaredTestResult result = ChiSquaredTest.Run(observations, probabilities);

            // ASSERT
            Assert.Equal(6, Math.Round(result.ChiSquaredValue, 4));
            Assert.Equal(3, result.DegreesOfFreedom);
            Assert.Equal(0.1116, Math.Round(result.PValue, 4));
        }
    }
}