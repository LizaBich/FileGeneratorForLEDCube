using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LEDCubeFileGenerator.Common.Interfaces;
using LEDCubeFileGenerator.Common.Services;
using SimpleInjector;

namespace LEDCubeFileGenerator
{
    internal static class Program
    {
        private static readonly Container container;

        static Program()
        {
            container = new Container();

            container.Register<IConverter, Converter>();
            container.Register<IFileCreator, FileCreator>();
            container.Register<ICubeService>(() => 
                new CubeService(8, container.GetInstance<IConverter>(), container.GetInstance<IFileCreator>()));

            container.Verify();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LedCubeApp(container.GetInstance<ICubeService>()));
        }
    }
}
