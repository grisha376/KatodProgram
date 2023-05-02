using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatodProgramm.Model
{
    public class KollektsiyaKnig
    {
        private readonly Kniga _knigas;


        public KollektsiyaKnig(Kniga kniga)
        {
            _knigas = kniga;

        }

       public async Task<IEnumerable<Kniga>> GetAllKnigas()
       {
            return await _knigas.GetAllKnigas();
       }

        public void KollectsiyaKnig(Kniga kniga)
        {
            _knigas.AddKniga(kniga);
        }
        
    }
}
