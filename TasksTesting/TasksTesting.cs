using System;
using Xunit;

namespace TasksTesting
{
    public class TasksTesting
    {
        [Fact]
        public void TestTask1()
        {
            int[] valuesArr = { 6, 8, 8, 7, 2, 5 };
            int multipleOf = 3;

            entityservice.Calcs cals = new entityservice.Calcs();
            (int, int, int) result = cals.GetMaximumProductMultiple(valuesArr, multipleOf);

            Assert.Equal(48, result.Item1);
            Assert.Equal(8, result.Item2);
            Assert.Equal(6, result.Item3);
        }
    }
}
