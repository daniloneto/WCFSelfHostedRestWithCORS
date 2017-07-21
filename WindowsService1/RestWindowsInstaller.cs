namespace RestWinService
{
    #region Namespaces
    using System.ComponentModel;
    using System.ServiceProcess;
    #endregion

    [RunInstaller(true)]
    public partial class RestWindowsInstaller : System.Configuration.Install.Installer
    {
        private ServiceProcessInstaller process;
        private ServiceInstaller service;   

        public RestWindowsInstaller()
        {
            process = new ServiceProcessInstaller();
            process.Account = ServiceAccount.LocalSystem;
            service = new ServiceInstaller();
            service.ServiceName = "RestAPI";
            service.Description = "REST API Hosting Windows Service";
            service.DelayedAutoStart = true;
            Installers.Add(process);
            Installers.Add(service);
        }

    }
}








