using KatodProgramm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatodProgramm.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel(KollektsiyaKnig kollektsiyaKnig)
        {
            CurrentViewModel = new MakeBookViewModel(kollektsiyaKnig);
        }
    }
}
