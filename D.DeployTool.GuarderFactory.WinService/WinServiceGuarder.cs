using D.Utils;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Configuration.Install;
using System.Linq;
using System.Management;
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

        /// <summary>
        /// win service 可执行文件路径是否正确，平时经常遇到安装错了
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        private bool IsExePathRight(string name, string path)
        {
            using (
                ManagementObject wmiService
                = new ManagementObject("Win32_Service.Name='" + name + "'")
                )
            {
                wmiService.Get();
                string currentserviceExePath = wmiService["PathName"].ToString();

                return currentserviceExePath == path;
            }
        }

        /// <summary>
        /// 安装服务
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private bool InstallService(string path)
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[]
                    {
                        path
                    });

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"安装 WinService {path} 出现异常：{ex}");

                return false;
            }
        }

        /// <summary>
        /// 卸载服务
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private bool UninstallService(string path)
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[]
                    {
                        "/U",
                        path
                    });

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"卸载 WinService {path} 出现异常：{ex}");

                return false;
            }
        }

        private bool RunService()
        {

        }
    }
}
