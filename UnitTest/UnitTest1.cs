using System;
using Xunit;
using StatisticsCalculator;
using StatisticsCalculator.Exceptions;
using System.Collections.Generic;

namespace UnitTest
{
    public class UnitTest1
    {


        [Fact]
        public void Test1()
        {


        }
        [Theory]
        [InlineData(2, 8, 5, 5)]
        [InlineData(10, 8, 6, 8)]
        [InlineData(2, 5, 5, 4)]
        [InlineData(-2, -50, -98, -50)]
        [InlineData(2.5, 4.6, 5, 4)]
        public void TestingAccuracyOfAverageMethode(int a, int b, int c, decimal expectedResult)
        {
            //Arrange
            StatCalc calc = new StatCalc();
            calc.AddNumber(a);
            calc.AddNumber(b);
            calc.AddNumber(c);
            //Act
            calc.CalculateAverage();
            //Assert
            Assert.Equal(expectedResult, calc.CalculateAverage());
        }
        [Fact]
        public void EmptingList()
        {
            StatCalc calc = new StatCalc();
            calc.AddNumber(5);
            calc.AddNumber(20);
            calc.AddNumber(78);

            calc.ClearNumbers();

            Assert.Throws<AverageCalculationException>(() => calc.CalculateAverage());
        }
        [Theory]
        [InlineData(2, 8, 5, 10, 5)]
        [InlineData(10, 8, 6, 25, 8)]
        [InlineData(2, 5, 5, 59, 4)]
        public void RemoveLastNumberMethodeTest1(int a, int b, int c, int d, decimal expectedResult)
        {
            //Arrange
            StatCalc calc = new StatCalc();
            calc.AddNumber(a);
            calc.AddNumber(b);
            calc.AddNumber(c);
            calc.AddNumber(d);

            //Act
            calc.RemoveLastNumber();
            calc.CalculateAverage();

            //Assert
            Assert.Equal(expectedResult, calc.CalculateAverage());


        }
        [Theory]
        [InlineData(2, 8, 5, 10)]
        [InlineData(10, 8, 6, 25)]
        [InlineData(2, 5, 5, 59)]
        public void GetnumbersMethodeTest1(int a, int b, int c, int d)
        {
            //Arrange
            StatCalc calc = new StatCalc();
            calc.AddNumber(a);
            calc.AddNumber(b);
            calc.AddNumber(c);
            calc.AddNumber(d);


            //Act

            int[] arr = calc.GetNumbers();
            calc.CalculateAverage();

            //Assert
            Assert.Equal(a, arr[0]);
            Assert.Equal(b, arr[1]);
            Assert.Equal(c, arr[2]);
            Assert.Equal(d, arr[3]);
        }

        [Fact]
        public void GetSingleModeExceptionTest1()
        {
            StatCalc calc = new StatCalc();
            calc.AddNumber(5);
            calc.AddNumber(20);
            calc.AddNumber(78);

            calc.ClearNumbers();

            Assert.Throws<InvalidModeCalculationException>(() => calc.GetSingleMode());
        }
        [Fact]
        public void GetSingleModeTest1()
        {
         int[] arr = new int[10] { 1, 25, 8, 32, 1, 5, 5, 4, 8, 8 };
        StatCalc calc = new StatCalc(arr);
           var result =calc.GetSingleMode();
            Assert.Equal(8, result);


        }
        [Fact]
        public void GetSingleModeExceptionTest2()
        {
            //beim SingleModeNotFoundException gibt ein Problem

            //Assert
            int[] arr = new int[4] { 1, 1, 8 ,8};
            
            StatCalc calc = new StatCalc(arr);

            calc.GetSingleMode();
            
            Assert.Throws<SingleModeNotFoundException>(() => calc.GetSingleMode());
            



        }



    }
}
