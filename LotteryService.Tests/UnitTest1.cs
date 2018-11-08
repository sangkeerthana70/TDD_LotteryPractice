using NUnit.Framework;
using LotteryService;

namespace Tests
{
    public class Tests
    {
        Class1 _testService = new Class1();
        [Test]
        public void return_Array()
        {
            int[]lotteryNumbers0 = new int[0];
            var output = _testService.SortNumbers(lotteryNumbers0);
            System.Console.WriteLine(output);
            Assert.AreEqual(new int[0],output);
        }

        [Test]
        public void return_OneNumSorted()
        {
            int[] lotteryNumbers1 = new int[1];
            var output = _testService.SortNumbers(lotteryNumbers1);
            Assert.AreEqual(new int[1], output);

        }

        [Test]
        public void return_twoNumSorted()
        {
            int[] lotteryNumbers1 = new int[2] { 9, 2 };
            var output = _testService.SortNumbers(lotteryNumbers1);
            
            Assert.AreEqual(new int[2] { 2, 9 }, output);

        }

        [Test]
        public void return_threeNumSorted()
        {
            int[] lotteryNumbers1 = new int[3] { 9, 2 , 14};
            var output = _testService.SortNumbers(lotteryNumbers1);
            
            Assert.AreEqual(new int[3] { 2, 9, 14 }, output);

        }
        [Test]
        public void return_tenNumSorted()
        {
            int[] lotteryNumbers1 = new int[10] { 9, 2, 14, 1, 5, 3, 8, 19, 0, 12};
            var output = _testService.SortNumbers(lotteryNumbers1);
            
            Assert.AreEqual(new int[10] { 0, 1, 2, 3, 5, 8, 9, 12, 14, 19 }, output);


        }
    }
}