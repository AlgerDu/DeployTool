using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool.Interfaces
{
    public interface IAppConnfigItem
    {
        /// <summary>
        /// 配置的路径；不区分大小写
        /// eg：xx.json/Logging/rolling
        /// </summary>
        string Path { get; }

        /// <summary>
        /// 配置项类型
        /// </summary>
        AppConnfigItemType Type { get; }

        /// <summary>
        /// 现在的值
        /// </summary>
        string Value { get; }

        /// <summary>
        /// 默认值
        /// </summary>
        string DefaultValue { get; }

        /// <summary>
        /// 正则校验方式
        /// </summary>
        string Verify { get; }
    }
}
