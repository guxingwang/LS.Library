using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS.Library.Extensions
{
    /// <summary>
    /// 项目所使用的枚举类
    /// </summary>
    public class Enums
    {
        /// <summary>
        /// 拼音转换的类型
        /// </summary>
        public enum ChineseCharacterConvertType
        {
            /// <summary>
            /// 所有拼音简码全部大写
            /// </summary>
            ShortCodeToUpper,
            /// <summary>
            /// 所有拼音简码全部小写
            /// </summary>
            ShortCodeToLower,
            /// <summary>
            /// 拼音全码全部大写
            /// </summary>
            FullCodeToUpper,
            /// <summary>
            /// 拼音全码全部小写
            /// </summary>
            FullCodeToLower,
            /// <summary>
            /// 拼音全码首字母大写
            /// </summary>
            FullCodeFirstToUpper

        }

        /// <summary>
        /// 自动生成拼音码的类型
        /// </summary>
        public enum AddChineseCodeType
        {
            /// <summary>
            /// 拼音简码和拼音全码全都生成
            /// </summary>
            All,
            /// <summary>
            /// 仅生成拼音简码
            /// </summary>
            ShortCode,
            /// <summary>
            /// 仅生成拼音全码
            /// </summary>
            FullCode
        }
    }
}
