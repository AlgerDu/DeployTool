using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    public class GuardMessage : IGuardMessage
    {
        public Guid AppUid { get; set; }

        public DateTimeOffset TimeStamp { get; set; }

        public int Code { get; set; }

        public string Msg { get; set; }

        public bool IsSuccess()
        {
            return Code % 10 == 0;
        }
    }
}
