using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// 配置项对应的文件及路径
    /// </summary>
    public class ConfigItemPath
    {
        /// <summary>
        /// 配置项所处的文件，包含文件路径
        /// </summary>
        public string File { get; set; }

        /// <summary>
        /// 访问到改配置项的路径（有一定的格式，具体再定义 TODO）
        /// </summary>
        public string Path { get; set; }
    }
}
