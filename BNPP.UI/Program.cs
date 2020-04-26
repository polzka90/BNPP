using BNPP.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BNPP.UI
{
    static class Program
    {
        public static ServiceProvider provider { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ServiceCollection services = new ServiceCollection();
            services.ConfigureDomainDependencies();
            services.AddScoped<ManualMovementsForm>();
            provider = services.BuildServiceProvider();
            Form main = (Form)provider.GetService(typeof(ManualMovementsForm));
            Application.Run(main);
        }
    }
}
