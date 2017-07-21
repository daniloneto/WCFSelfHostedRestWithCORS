using System.ServiceProcess;

namespace RestWinService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static void Main()
        {
            
            #if DEBUG
                        RestWindows myservice = new RestWindows();
                        myservice.OnDebug();
                        System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
            #else
            ServiceBase[] ServicesToRun;

            ServicesToRun = new ServiceBase[]
            {
                new RestWindows()
            };

            ServiceBase.Run(ServicesToRun);
            #endif
        }

    }
}