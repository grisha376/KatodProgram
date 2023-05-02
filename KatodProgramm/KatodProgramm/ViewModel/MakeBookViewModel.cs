using KatodProgramm.Command;
using KatodProgramm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KatodProgramm.ViewModel
{
    public class MakeBookViewModel : ViewModelBase
    {

        private string _автор;

        public string Автор
        {
            get
            {
                return _автор;
            }
            set
            {
                _автор = value;
                OnPropertyChanged(nameof(Автор));
            }
        }

        private string _названиеКниги;

        public string НазваниеКниги
        {
            get
            {
                return _названиеКниги;
            }
            set
            {
                _названиеКниги = value;
                OnPropertyChanged(nameof(НазваниеКниги));
            }
        }

        private int _тематика;

        public int Тематика
        {
            get
            {
                return _тематика;
            }
            set
            {
                _тематика = value;
                OnPropertyChanged(nameof(Тематика));
            }
        }

        private int _годИздания;

        public int ГодИздания
        {
            get
            {
                return _годИздания;
            }
            set
            {
                _годИздания = value;
                OnPropertyChanged(nameof(ГодИздания));
            }
        }

        public ICommand AddCommand { get; }

        public ICommand CancelCommand { get; }

        public MakeBookViewModel(KollektsiyaKnig kollektsiyaKnig)
        {
            AddCommand = new AddKnigaCommand(this, kollektsiyaKnig);
        }
    }
}
