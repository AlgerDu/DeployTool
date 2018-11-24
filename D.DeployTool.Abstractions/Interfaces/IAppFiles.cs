using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// 文件集合
    /// </summary>
    public interface IAppFiles
    {
        /// <summary>
        /// 可执行文件
        /// </summary>
        IAppFile Exectue { get; }

        /// <summary>
        /// 配置文件
        /// </summary>
        IEnumerable<IAppFile> Configs { get; }

        /// <summary>
        /// 其它文件，比如 DLL 等的这些
        /// </summary>
        IEnumerable<IAppFile> Others { get; }
    }
}
