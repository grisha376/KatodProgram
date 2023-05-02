using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using KatodProgramm.Model;

namespace KatodProgramm.ViewModel
{
    public class BookListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<KollektciyaKnigViewModel> _kniga;

        public IEnumerable<KollektciyaKnigViewModel> kollektciyaKnigs => _kniga;
        public ICommand AddBookCommand { get; }

        public BookListingViewModel()
        {
            _kniga = new ObservableCollection<KollektciyaKnigViewModel>();

            _kniga.Add(new KollektciyaKnigViewModel(new Kniga("Avtor1", "Nazvanie1", 1, 2001)));
            _kniga.Add(new KollektciyaKnigViewModel(new Kniga("Avtor2", "Nazvanie2", 1, 2002)));
        }
    }
}
