using System;
using System.Collections.Generic;
using D.DeployTool;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Guarder
{
    [TestClass]
    public class TestWinServiceGuarder
    {
        ILoggerFactory _loggerFactory = new LoggerFactory();

        IGuardTask _guardTask = new GuardTask
        {
            Uid = Guid.NewGuid(),
            App = new RealApplication
            {
                Path = "",
                Type = AppType.WinService,
                RunningParams = new Dictionary<string, string>
                {
                    { "servicename","DepolyToolXService" }
                },
                Files = new AppFiles
                {
                    Exectue = new AppFile
                    {
                        Path = ""
                    }
                }
            }
        };

        /// <summary>
        /// 为了开发时的调试
        /// </summary>
        [TestMethod]
        public void ForDevelop()
        {
            var guarder = new WinServiceGuarder(
                _loggerFactory.CreateLogger<WinServiceGuarder>()
                , _guardTask
                );

            var runCommand = new GuarderCommand
            {
                Code = (int)CommandCode.RunApp
            };

            var rst = guarder.Execute(runCommand);
        }

        /// <summary>
        /// 检测一个随机生成的服务名，是否运行
        /// </summary>
        [TestMethod]
        public void CheckWinServiceIsRun()
        {

        }
    }
}
