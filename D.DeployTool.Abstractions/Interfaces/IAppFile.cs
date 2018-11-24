using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// 程序的文件描述信息
    /// </summary>
    public interface IAppFile
    {
        /// <summary>
        /// 文件名
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 文件相对路径
        /// </summary>
        string Path { get; }

        /// <summary>
        /// 版本信息
        /// </summary>
        string Version { get; }

        /// <summary>
        /// 创建时间
        /// </summary>
        DateTimeOffset CreateTime { get; }

        /// <summary>
        /// 文件大小
        /// </summary>
        string Size { get; }
    }
}
