using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.DeployTool.Pack.ViewModels
{
    /// <summary>
    /// 自己想出来的一种实现
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// 全局 ViewModel 生成
        /// </summary>
        public static ILifetimeScope LifetimeScope;
    }

    public static class AutofacExt
    {
        public static void AddViewModels(this ContainerBuilder builder)
        {
        }
    }
}
