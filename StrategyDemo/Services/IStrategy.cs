using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyDemo.Services
{
    /// <summary>
    /// 策略模式 interface
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// 計算機
        /// </summary>
        /// <param name="a">變數a</param>
        /// <param name="b">變數b</param>
        /// <returns></returns>
        public int caculate(int a, int b);
    }
}
