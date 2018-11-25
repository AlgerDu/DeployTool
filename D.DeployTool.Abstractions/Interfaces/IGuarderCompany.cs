using D.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// guarder 公司
    /// </summary>
    public interface IGuarderCompany
    {
        /// <summary>
        /// 雇佣一个 guarder
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        IResult<IGuarder> Employ(IGuardTask task);
    }
}
