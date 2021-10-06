using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest
{
    /// <summary>
    /// 測試用類別
    /// </summary>
    [TestFixture]
    public class MyMathTests
    {
        /// <summary>
        /// 測試Add
        /// </summary>
        [Test]
        public void Add_WhenCalled()
        {
            //實例化類別
            var obj = new MyMath();
            int no1 = 10, no2 = 15;

            //呼叫方法
            int actual = obj.Add(no1, no2);
            //預判測試結果
            int expected = 25;

            //下斷言
            Assert.AreEqual(actual, expected);
        }
    }
    
    public class MyMath
    {
        /// <summary>
        /// 整數相加
        /// </summary>
        /// <param name="no1"></param>
        /// <param name="no2"></param>
        /// <returns></returns>
        public int Add(int no1, int no2)
        {
            return no1 + no2+0;
        }
    }
}
