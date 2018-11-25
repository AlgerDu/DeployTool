using D.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    public interface IGuardMessage : IResult
    {
        /// <summary>
        /// app uid
        /// </summary>
        Guid AppUid { get; }

        /// <summary>
        /// 时间戳
        /// </summary>
        DateTimeOffset TimeStamp { get; }
    }
}
