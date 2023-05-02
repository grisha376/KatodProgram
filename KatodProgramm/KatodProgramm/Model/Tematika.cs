using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatodProgramm.Model
{
    public class Tematika
    {
        public int ID { get; }

        public string NazvanieTematiki { get; }

        public Tematika(int id, string nazvanieTematiki)
        {
            ID = id;
            NazvanieTematiki = nazvanieTematiki;
        }

        public override string ToString()
        {
            return $"{NazvanieTematiki}";
        }

        public override bool Equals(object obj)
        {
            return obj is Tematika tematika && 
                ID == tematika.ID && 
                NazvanieTematiki == tematika.NazvanieTematiki;
        }

        public override int GetHashCode()
        {
            int hashCode = 1087608651;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NazvanieTematiki);
            return hashCode;
        }
    }
}
