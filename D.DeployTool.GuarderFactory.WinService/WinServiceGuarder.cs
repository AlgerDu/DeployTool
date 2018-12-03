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

        string _serviceName;
        string _servicePath;

        public WinServiceGuarder(
            ILogger<WinServiceGuarder> logger
            , IGuardTask task
            ) : base(logger, task)
        {
            var app = task.App;

            if (app.RunningParams.ContainsKey("ServiceName".ToLower()))
            {
                _serviceName = app.RunningParams["ServiceName".ToLower()];
            }

            _servicePath = $"{app.Path}/{task.App.Files.Exectue.Path}";
        }

        protected override void Check()
        {
            if (string.IsNullOrEmpty(_serviceName))
                //TODO 配置错误
                return;

            if (IsServiceInstalled(_serviceName))
            {
                var currentPath = CurrentExePath(_serviceName);

                if (currentPath != _servicePath)
                {
                    //TODO 上报可执行文件路径异常
                    return;
                }
                else
                {

                }
            }
            else
            {
                //TODO 上报未安装
                return;
            }
        }

        protected override IResult ExecuteRunAppCmd(IGuarderCommand command)
        {
            Check();

            return Result.CreateSuccess();
        }

        protected override IResult ExecuteStopAppCmd(IGuarderCommand command)
        {
            throw new NotImplementedException();
        }

        #region 内部对 WinService 的一些控制
        /// <summary>
        /// 检查服务是否安装
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private bool IsServiceInstalled(string name)
        {
            var installServices = ServiceController.GetServices();
            foreach (var service in installServices)
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
        /// <returns></returns>
        private string CurrentExePath(string name)
        {
            using (
                ManagementObject wmiService
                = new ManagementObject("Win32_Service.Name='" + name + "'")
                )
            {
                wmiService.Get();
                string currentserviceExePath = wmiService["PathName"].ToString();

                return currentserviceExePath;
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

        /// <summary>
        /// 启动服务
        /// </summary>
        /// <returns></returns>
        private bool RunService()
        {
            try
            {
                if (_serviceController != null)
                {
                    _serviceController.Start();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"WinService 启动过程中出现异常：{ex}");
                return false;
            }
        }

        /// <summary>
        /// 停止服务
        /// </summary>
        /// <returns></returns>
        private bool StopService()
        {
            try
            {
                if (_serviceController != null)
                {
                    _serviceController.Stop();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"WinService 停止过程中出现异常：{ex}");
                return false;
            }
        }
        #endregion
    }
}
