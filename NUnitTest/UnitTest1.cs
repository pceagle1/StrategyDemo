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
        /// ���ե[�k
        /// </summary>
        [Test]
        public void TestAdd()
        {
            // �w�p���浲�G
            int expected = 3;

            //�p��
            Calculator cal = new Calculator();
            cal.SetStrategy(StrategyDemo.Enums.DoType.Add);
            var ans = cal.execute(1, 2);

            Assert.AreEqual(expected, ans);
        }

        /// <summary>
        /// ���մ�k
        /// </summary>
        [Test]
        public void TestMinus()
        {
            // �w�p���浲�G
            int expected = -1;

            //�p��
            Calculator cal = new Calculator();
            cal.SetStrategy(StrategyDemo.Enums.DoType.Minus);
            var ans = cal.execute(1, 2);

            Assert.AreEqual(expected, ans);
        }

        /// <summary>
        /// ���խ��k
        /// </summary>
        [Test]
        public void TestMultyply()
        {
            // �w�p���浲�G
            int expected = 2;

            //�p��
            Calculator cal = new Calculator();
            cal.SetStrategy(StrategyDemo.Enums.DoType.Multyply);
            var ans = cal.execute(1, 2);

            Assert.AreEqual(expected, ans);
        }

        /// <summary>
        /// ���հ��k
        /// </summary>
        [Test]
        public void TestDivide()
        {
            // �w�p���浲�G
            int expected = 2;

            //�p��
            Calculator cal = new Calculator();
            cal.SetStrategy(StrategyDemo.Enums.DoType.Divide);
            var ans = cal.execute(4, 2);

            Assert.AreEqual(expected, ans);
        }

        

    }
}