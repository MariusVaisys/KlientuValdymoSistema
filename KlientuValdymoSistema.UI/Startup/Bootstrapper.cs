using Autofac;
using KlientuValdymoSistema.UI.Data;
using KlientuValdymoSistema.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientuValdymoSistema.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<KlientuDataService>().As<IKlientuDataService>();

            return builder.Build();
        }
    }
}
