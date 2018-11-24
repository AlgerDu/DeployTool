using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// 应用的环境需求
    /// </summary>
    public interface IEnvironmentRequirement
    {
        /// <summary>
        /// 类型编码
        /// </summary>
        string Code { get; }

        /// <summary>
        /// 检测参数
        /// </summary>
        string Params { get; }
    }
}
