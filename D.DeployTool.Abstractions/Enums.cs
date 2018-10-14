using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// 配置项类型
    /// </summary>
    public enum ConfigItemType
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        DBConnStr,

        /// <summary>
        /// IP 地址
        /// </summary>
        IP,

        /// <summary>
        /// 文本，可以自定义验证，
        /// 不是特殊类型就是文本
        /// </summary>
        Text
    }
}
