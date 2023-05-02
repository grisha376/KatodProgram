using KatodProgramm.Model;
using KatodProgramm.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KatodProgramm
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly KollektsiyaKnig _kollektsiyaKnig;

        public App(KollektsiyaKnig kollektsiyaKnig)
        {
            _kollektsiyaKnig = kollektsiyaKnig;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_kollektsiyaKnig)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
