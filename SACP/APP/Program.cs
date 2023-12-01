using APP.infra;
using IFSPStore.App;

namespace APP
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ConfigureDI.ConfiguraServices();
            ApplicationConfiguration.Initialize();
            Application.Run(new FormPrincipal());
        }
    }
}