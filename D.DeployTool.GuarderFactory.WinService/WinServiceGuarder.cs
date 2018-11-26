using D.Utils;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace D.DeployTool
{
    /// <summary>
    /// WinService 的守护者
    /// </summary>
    public class WinServiceGuarder : Guarder, IGuarder
    {
        /// <summary>
        /// win service 的控制类
        /// </summary>
        ServiceController _serviceController;

        public WinServiceGuarder(
            ILogger<WinServiceGuarder> logger
            , IGuardTask task
            ) : base(logger, task)
        {

        }

        protected override void Check()
        {
            throw new NotImplementedException();
        }

        protected override IResult ExecuteRunAppCmd(IGuarderCommand command)
        {
            throw new NotImplementedException();
        }

        protected override IResult ExecuteStopAppCmd(IGuarderCommand command)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 检查服务是否安装
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private bool IsServiceInstalled(string name)
        {
            foreach (var service in ServiceController.GetServices())
            {
                if (service.ServiceName == name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
