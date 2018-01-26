using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS.Library.Extensions
{
    /// <summary>
    /// string 类型的扩展方法
    /// </summary>
    public static class ExtensionsString
    {
        /// <summary>
        /// 扩展string类型，判断string不为空
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNotEmpty(this string s)
        {
            return !string.IsNullOrWhiteSpace(s);
        }
        /// <summary>
        /// 扩展string类型，判断string为空
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsEmpty(this string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }
    }
}
