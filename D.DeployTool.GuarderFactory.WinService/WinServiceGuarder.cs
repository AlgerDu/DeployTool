using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.DeployTool
{
    /// <summary>
    /// WinService 的守护者
    /// </summary>
    public class WinServiceGuarder : IGuarder
    {
        ILogger _logger;
        IGuardTask _task;

        Dictionary<int, IGuardMessage> _messages;

        /// <summary>
        /// DI 构造函数
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="task"></param>
        public WinServiceGuarder(
            ILogger<WinServiceGuarder> logger
            , IGuardTask task
            )
        {
            _logger = logger;
            _task = task;

            _messages = new Dictionary<int, IGuardMessage>();
        }

        #region IGuarder 实现
        public IGuardTask Task => _task;

        public IDictionary<int, IGuardMessage> Messages => _messages;

        public IGuarder Reset()
        {
            throw new NotImplementedException();
        }

        public void SetReportAction(Action<IGuarder, IGuardMessage> action)
        {
            throw new NotImplementedException();
        }

        public IGuarder Work()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
