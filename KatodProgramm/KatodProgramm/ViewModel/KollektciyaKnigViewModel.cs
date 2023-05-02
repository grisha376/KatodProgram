using KatodProgramm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatodProgramm.ViewModel
{
    public class KollektciyaKnigViewModel : ViewModelBase
    {
        private readonly Kniga _kniga;

        //public string ID => _kniga.ID.ToString();

        public string Avtor => _kniga.Avtor;

        public string NazvanieKnigi => _kniga.NazvanieKnigi;

        public string IdTematiki => _kniga.IdTematiki.ToString();

        public string GodIzdaniya => _kniga.GodIzdaniya.ToString();

        public KollektciyaKnigViewModel(Kniga kniga)
        {
            _kniga = kniga;
        }
            
    }
}
