using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stundenplan
{
    class Klasse
    {
        private string Name { get; set; }
        private Lehrer Klassenlehrer { get; set; }
        private Stundenplan Stundenplan { get; set; }

        public void gibStundenplanAus()
        {

        }

        public bool setzeStundeInStundenplan(int wochentag, int stunde, Fach fach, Lehrer lehrer)
        {
            return true;
        }


    }
}
