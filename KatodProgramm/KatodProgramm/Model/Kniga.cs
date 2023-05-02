using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatodProgramm.Model
{
    public class Kniga
    {

        public string Avtor { get; }

        public string NazvanieKnigi { get; }

        public int IdTematiki { get; }

        public int GodIzdaniya { get; }

        public Kniga (string avtor, string nazvanieKnigi, int idTematiki, int godIzdaniya)
        {
            Avtor = avtor;
            NazvanieKnigi = nazvanieKnigi;
            IdTematiki = idTematiki;
            GodIzdaniya = godIzdaniya;
        }

        internal void AddKniga(Kniga kniga)
        {
            throw new NotImplementedException();
        }

        internal Task<IEnumerable<Kniga>> GetAllKnigas()
        {
            throw new NotImplementedException();
        }
    }
}
