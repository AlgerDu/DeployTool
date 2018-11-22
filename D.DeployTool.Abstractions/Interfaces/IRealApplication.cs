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
        string Name { get; }

        string Version { get; }

        AppType Type { get; }

        IEnumerable<IEnvironmentCheckItem> EnvironmentCheckItems { get; }

        /// <summary>
        /// 主文件相对路径
        /// </summary>
        string ExecutePath { get; }
    }
}
