namespace Test.XWinService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.XServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.XServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // XServiceProcessInstaller
            // 
            this.XServiceProcessInstaller.Password = null;
            this.XServiceProcessInstaller.Username = null;
            // 
            // XServiceInstaller
            // 
            this.XServiceInstaller.Description = "Deploy Tool WinService 监控测试";
            this.XServiceInstaller.ServiceName = "DepolyToolXService";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.XServiceProcessInstaller,
            this.XServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller XServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller XServiceInstaller;
    }
}