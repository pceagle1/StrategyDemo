using NUnit.Framework;
using StrategyDemo;

namespace NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// 測試加法
        /// </summary>
        [Test]
        public void TestAdd()
        {
            // 預計執行結果
            int expected = 3;

            //計算
            Calculator cal = new Calculator();
            cal.SetStrategy(StrategyDemo.Enums.DoType.Add);
            var ans = cal.execute(1, 2);

            Assert.AreEqual(expected, ans);
        }

        /// <summary>
        /// 測試減法
        /// </summary>
        [Test]
        public void TestMinus()
        {
            // 預計執行結果
            int expected = -1;

            //計算
            Calculator cal = new Calculator();
            cal.SetStrategy(StrategyDemo.Enums.DoType.Minus);
            var ans = cal.execute(1, 2);

            Assert.AreEqual(expected, ans);
        }

        /// <summary>
        /// 測試乘法
        /// </summary>
        [Test]
        public void TestMultyply()
        {
            // 預計執行結果
            int expected = 2;

            //計算
            Calculator cal = new Calculator();
            cal.SetStrategy(StrategyDemo.Enums.DoType.Multyply);
            var ans = cal.execute(1, 2);

            Assert.AreEqual(expected, ans);
        }

        /// <summary>
        /// 測試除法
        /// </summary>
        [Test]
        public void TestDivide()
        {
            // 預計執行結果
            int expected = 2;

            //計算
            Calculator cal = new Calculator();
            cal.SetStrategy(StrategyDemo.Enums.DoType.Divide);
            var ans = cal.execute(4, 2);

            Assert.AreEqual(expected, ans);
        }

        

    }
}