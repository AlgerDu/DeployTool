using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// 环境检测项；
    /// 比如 操作系统、framework版本、dotnet core运行时环境；
    /// 暂时尽量不对外抛出异常
    /// </summary>
    public interface IEnvironmentCheckItem
    {
        /// <summary>
        /// 标识
        /// </summary>
        string Code { get; }

        /// <summary>
        /// 检测环境
        /// </summary>
        /// <param name="args">输入参数</param>
        /// <returns>环境符合 true；否则 false</returns>
        bool Check(params string[] args);
    }
}
