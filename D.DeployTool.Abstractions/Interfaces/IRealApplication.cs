using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool.Interfaces
{
    /// <summary>
    /// 软件的抽象
    /// </summary>
    public interface IRealApplication
    {
        /// <summary>
        /// 应用名
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 版本号
        /// </summary>
        string Version { get; }

        /// <summary>
        /// 应用类型
        /// </summary>
        AppType Type { get; }

        /// <summary>
        /// 运行环境需求
        /// </summary>
        IEnumerable<IEnvironmentRequirement> Environments { get; }

        /// <summary>
        /// 文件
        /// </summary>
        IAppFiles Files { get; }
    }
}
