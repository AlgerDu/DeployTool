using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// 命令
    /// </summary>
    public interface IGuarderCommand
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        Guid Uid { get; }

        /// <summary>
        /// 类型，感觉不会太多，顶多十几个
        /// </summary>
        int Code { get; }

        /// <summary>
        /// 参数
        /// 暂定这样吧，为了第三方扩展方便
        /// </summary>
        string[] Params { get; }

        /// <summary>
        /// 时间戳
        /// </summary>
        DateTimeOffset TimeStamp { get; }
    }
}
