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

        /// <summary>
        /// 检查是否包含某个字符
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="toCheck">要比较的字符串</param>
        /// <param name="comp">比较的类型</param>
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }


        /// <summary>
        /// 获取拼音码
        /// </summary>
        /// <param name="chinese">要获取拼音码的汉字</param>
        /// <param name="type">获取拼音码的类型,默认为拼音全码</param>
        /// <returns></returns>
        public static string GetChineseCode(this string chinese, Enums.ChineseCharacterConvertType type = Enums.ChineseCharacterConvertType.FullCodeToUpper)
        {
            return ChineseCharactersHelper.ChineseToCharacters(chinese, type);
        }

    }
}
