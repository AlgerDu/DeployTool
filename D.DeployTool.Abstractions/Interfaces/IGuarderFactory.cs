using D.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// 工厂
    /// </summary>
    public interface IGuarderFactory
    {
        /// <summary>
        /// 根据任务创建一个守护者
        /// </summary>
        /// <param name="app"></param>
        /// <returns>不支持的返回特定 Code</returns>
        IResult<IGuarder> Create(IGuardTask task);
    }
}
