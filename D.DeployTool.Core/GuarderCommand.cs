using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    public class GuarderCommand : IGuarderCommand
    {
        public Guid Uid { get; set; }

        public int Code { get; set; }

        public string[] Params { get; set; }

        public DateTimeOffset TimeStamp { get; set; }

        public GuarderCommand()
        {
            Uid = Guid.NewGuid();
            TimeStamp = DateTimeOffset.Now;
        }
    }
}
