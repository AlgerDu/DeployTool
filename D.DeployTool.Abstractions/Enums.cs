using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// 配置项类型
    /// </summary>
    public enum AppConnfigItemType
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

    /// <summary>
    /// 程序类型
    /// </summary>
    public enum AppType
    {
        WebSit,

        WinService,

        Exe
    }

    /// <summary>
    /// 预定义的一些命令
    /// </summary>
    public enum CommandCode
    {
        /// <summary>
        /// 启动保护
        /// </summary>
        Run,

        /// <summary>
        /// 停止保护
        /// </summary>
        Stop,

        /// <summary>
        /// 启动 app
        /// </summary>
        RunApp,

        /// <summary>
        /// 停止 app
        /// </summary>
        StopApp
    }
}
