using KatodProgramm.Model;
using KatodProgramm.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatodProgramm.Command
{
    public class AddKnigaCommand : CommandBase
    {
        private readonly MakeBookViewModel _makeBookViewModel;
        private readonly KollektsiyaKnig _kollektsiyaKnig;

        public AddKnigaCommand(ViewModel.MakeBookViewModel makeBookViewModel, KollektsiyaKnig kollektsiyaKnig)
        {
            this._makeBookViewModel = makeBookViewModel;
            _kollektsiyaKnig = kollektsiyaKnig;
        }

        public override void Execute(object parameter)
        {
            Kniga kniga = new Kniga(
                _makeBookViewModel.Автор, 
                _makeBookViewModel.НазваниеКниги,
                new Tematika(1, "Фантастика"),
                _makeBookViewModel.ГодИздания);
                );

            _kollektsiyaKnig.KollectsiyaKnig() 
        }
    }
}
