using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// 环境检测服务
    /// </summary>
    public interface IEnvironmentCheckService
    {
        bool Check();
    }
}
