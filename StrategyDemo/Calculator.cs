using StrategyDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StrategyDemo.Enums;

namespace StrategyDemo
{
    /// <summary>
    /// 計算機
    /// </summary>
    public class Calculator
    {
        private int now = 0;

        private IStrategy strategy;

        // 策略模式
        public int execute(int a, int b)
        {
            return strategy.caculate(a, b);
        }

        public void reset()
        {
            this.now = 0;
        }

        // 簡單工廠模式
        public void SetStrategy(DoType doType)
        {
            switch (doType)
            {
                case DoType.Add:
                    this.strategy = new Add();
                    break;
                case DoType.Minus:
                    this.strategy = new Minus();
                    break;
                case DoType.Divide:
                    this.strategy = new Divide();
                    break;
                case DoType.Multyply:
                    this.strategy = new Multyply();
                    break;
            }
        }
    }
}
