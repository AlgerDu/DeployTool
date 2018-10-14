using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// 应用程序配置项；
    /// 需要根据不同的类型，用不同的 UI 展示给用户，用来配置应用程序必要的参数
    /// </summary>
    public class ConfigItem
    {
        /// <summary>
        /// code 标识
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 配置项所处在的路径，
        /// 其实就是不同的配置文件里面可能有相同的配置项，有时候觉得出现这种情况可能就是一种不合理，但是真实存在的
        /// </summary>
        public ConfigItemPath[] Paths { get; set; }

        /// <summary>
        /// 配置项类型
        /// </summary>
        public ConfigItemType Type { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// 展示用名称
        /// </summary>
        public string DispalyName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
    }
}
