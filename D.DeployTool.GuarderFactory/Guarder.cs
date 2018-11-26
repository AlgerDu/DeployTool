using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using D.Utils;
using Microsoft.Extensions.Logging;

namespace D.DeployTool
{
    /// <summary>
    /// Guarder 基类
    /// </summary>
    public abstract class Guarder : IGuarder
    {
        Timer _checkTimer;

        protected ILogger _logger;
        protected IGuardTask _task;

        /// <summary>
        /// 每个类型最后的一些信息
        /// </summary>
        protected Dictionary<int, IGuardMessage> _messages;

        /// <summary>
        /// 用来上报消息的 action
        /// </summary>
        protected Action<IGuarder, IGuardMessage> _reportMessageAction;

        public Guarder(
            ILogger logger
            , IGuardTask task
            )
        {
            _logger = logger;
            _task = task;

            _messages = new Dictionary<int, IGuardMessage>();

            InitTier();
        }

        #region IGuarder 基类实现
        public virtual IGuardTask GTask => _task;

        public virtual IDictionary<int, IGuardMessage> Messages => _messages;

        public virtual IResult Execute(IGuarderCommand command)
        {
            _logger.LogInformation($"接收到命令 {command}");

            switch (command.Code)
            {
                case (int)CommandCode.Run:
                    return ExecuteRunCmd(command);

                case (int)CommandCode.Stop:
                    return ExecuteStopCmd(command);

                case (int)CommandCode.RunApp:
                    return ExecuteRunAppCmd(command);

                case (int)CommandCode.StopApp:
                    return ExecuteStopAppCmd(command);

                default:
                    var msg = $"不能处理的命令 {command.Code}";
                    _logger.LogWarning(msg);

                    return Result.CreateError(msg);
            }
        }

        public virtual void SetReportAction(Action<IGuarder, IGuardMessage> action)
        {
            _reportMessageAction = action;
        }
        #endregion

        /// <summary>
        /// 检测有没有异常
        /// </summary>
        protected abstract void Check();

        /// <summary>
        /// 上报并且存储
        /// </summary>
        /// <param name="message"></param>
        protected virtual void ReportMessage(IGuardMessage message)
        {
            lock (_messages)
            {
                var msgType = message.Code >> 4;

                if (_messages.ContainsKey(msgType))
                {
                    _messages[msgType] = message;
                }
                else
                {
                    _messages.Add(msgType, message);
                }

                Task.Run(() => { _reportMessageAction?.Invoke(this, message); });
            }
        }

        #region 处理预定义命令
        /// <summary>
        /// 停止 app
        /// </summary>
        /// <param name="command"></param>
        protected abstract IResult ExecuteStopAppCmd(IGuarderCommand command);

        /// <summary>
        /// 启动 app
        /// </summary>
        /// <param name="command"></param>
        protected abstract IResult ExecuteRunAppCmd(IGuarderCommand command);

        /// <summary>
        /// 开始守护
        /// </summary>
        /// <param name="command"></param>
        protected virtual IResult ExecuteRunCmd(IGuarderCommand command)
        {
            StartTimer();
            return Result.CreateSuccess();
        }

        /// <summary>
        /// 停止守护
        /// </summary>
        /// <param name="command"></param>
        protected virtual IResult ExecuteStopCmd(IGuarderCommand command)
        {
            StopTimer();
            return Result.CreateError();
        }
        #endregion

        #region timer 相关
        private void InitTier()
        {
            _checkTimer = new Timer();
            _checkTimer.Interval = TimeSpan.FromSeconds(2).TotalMilliseconds;
            _checkTimer.Elapsed += (object sender, ElapsedEventArgs e) =>
            {
                Check();
            };
        }

        protected void StartTimer()
        {
            _checkTimer.Start();
        }

        protected void StopTimer()
        {
            _checkTimer.Stop();
        }
        #endregion
    }
}
