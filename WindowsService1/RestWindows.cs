using System.ServiceProcess;
using System.ServiceModel;

namespace RestWinService
{
    public partial class RestWindows : ServiceBase
    {
        ServiceHost oServiceHost = null;
        public RestWindows()
        {
            InitializeComponent();
        }

        public void OnDebug()
        {
            OnStart(null);
        }
        
        protected override void OnStart(string[] args)
        {            
            oServiceHost = new ServiceHost(typeof(RestWCF.Rest));
            oServiceHost.Open();
            EventLog.WriteEntry("RestWinService Started");
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("RestWinService Stopped");
            if (oServiceHost != null)
            {
                oServiceHost.Close();
                oServiceHost = null;
            }
        }
    }
}