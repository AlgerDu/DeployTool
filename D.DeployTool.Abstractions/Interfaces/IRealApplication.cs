using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// 软件的抽象
    /// </summary>
    public interface IRealApplication
    {
        /// <summary>
        /// 编码
        /// </summary>
        string Code { get; }

        /// <summary>
        /// 应用名
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 版本号
        /// </summary>
        string Version { get; }

        /// <summary>
        /// 程序根目录的绝对路径
        /// </summary>
        string Path { get; }

        /// <summary>
        /// 应用类型
        /// </summary>
        AppType Type { get; }

        /// <summary>
        /// 运行参数；
        /// eg：WinService 的参数，网站的端口 等等
        /// </summary>
        IDictionary<string, string> RunningParams { get; }

        /// <summary>
        /// 需要配置的参数
        /// </summary>
        IEnumerable<IAppConnfigItem> Configs { get; }

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
