using D.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    public interface IMessage : IResult
    {
        /// <summary>
        /// 时间戳
        /// </summary>
        DateTimeOffset TimeStamp { get; }
    }
}
