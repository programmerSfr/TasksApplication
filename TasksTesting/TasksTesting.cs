using System;
using Xunit;

namespace TasksTesting
{
    public class TasksTesting
    {
        [Fact]
        public void TestTask1()
        {
            //int[] valuesArr = { 6, 8, 8, 7, 2, 5 };
            int[] valuesArr = { 6, 9, 9, 4, 1, 5 };
            int multipleOf = 3;

            entityservice.Calcs cals = new entityservice.Calcs();
            (int, int, int) result = cals.GetMaximumProductMultipleLinear(valuesArr, multipleOf);

            Assert.Equal(81, result.Item1);
            Assert.Equal(9, result.Item2);
            Assert.Equal(9, result.Item3);
        }
    }
}
