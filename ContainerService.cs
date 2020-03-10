using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComPort.Forms;
using ComPort.Repositories.Json;
using ComPort.Repositories.Json.Interfaces;
using ComPort.Utils;
using Microsoft.Practices.Unity;

namespace ComPort
{
    public static class ContainerService
    {
        private static UnityContainer _container;

        static ContainerService()
        {
            _container = new UnityContainer();

            _container.RegisterType<BeanForm>();
            _container.RegisterType<CalculationForm>();
            _container.RegisterType<MainForm>();
            _container.RegisterType<FaktForm>();
            _container.RegisterType<FaktResultForm>();
            _container.RegisterType<ResultForm>();
            _container.RegisterType<SettingsForm>();
            _container.RegisterType<SportsmanForm>();
            _container.RegisterType<MeasurementForm>();

            _container.RegisterType<LoadCalculateService>();


            _container.RegisterType<IIOBean, IOBean>();
            _container.RegisterType<IIOFaktResult, IOFaktResult>();
            _container.RegisterType<IIOResult, IOResult>();
            _container.RegisterType<IIOSettings, IOSettings>();
            _container.RegisterType<IIOSportsman, IOSportsman>();
        }

        public static T GetInject<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
