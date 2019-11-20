using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyDemo.Services
{
    /// <summary>
    /// 加法實做
    /// </summary>
    public class Add : IStrategy
    {
        /// <summary>
        /// 加法計算
        /// </summary>
        /// <param name="a">變數a</param>
        /// <param name="b">變數b</param>
        /// <returns></returns>
        public int caculate(int a, int b)
        {
            return a + b;
        }
    }

    /// <summary>
    /// 減法實做
    /// </summary>
    public class Minus : IStrategy
    {
        /// <summary>
        /// 減法計算
        /// </summary>
        /// <param name="a">變數a</param>
        /// <param name="b">變數b</param>
        /// <returns></returns>
        public int caculate(int a, int b)
        {
            return a - b;
        }
    }

    /// <summary>
    /// 乘法實做
    /// </summary>
    public class Multyply : IStrategy
    {
        /// <summary>
        /// 乘法計算
        /// </summary>
        /// <param name="a">變數a</param>
        /// <param name="b">變數b</param>
        /// <returns></returns>
        public int caculate(int a, int b)
        {
            return a * b;
        }
    }

    /// <summary>
    /// 除法實做
    /// </summary>
    public class Divide : IStrategy
    {
        /// <summary>
        /// 除法計算
        /// </summary>
        /// <param name="a">變數a</param>
        /// <param name="b">變數b</param>
        /// <returns></returns>
        public int caculate(int a, int b)
        {
            return a / b;
        }
    }
}
