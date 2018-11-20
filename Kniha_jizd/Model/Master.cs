using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniha_jizd.Model
{
    class Master
    {
        public static List<jizda> Jizdy = new List<jizda>();
        public static int pocet_jizd = 0;


        public static void Vytvorit_jizdu(string Datum, string Odkud, string Kam, string Typ)
        {
            jizda Jizda = new jizda();
            Jizda.typ = Typ;
            Jizda.datum = Datum;
            Jizda.identifikator = pocet_jizd;
            Jizda.odkud = Odkud;
            Jizda.kam = Kam;
            Master.pocet_jizd++;
            Jizdy.Add(Jizda);
        }
        public static void Odebrat_jizdu(int ID)
        {
            for (int i = 0; i<Jizdy.Count; i++)
            {
                if (Jizdy[i].identifikator == ID){
                    Jizdy.RemoveAt(i);
                }
            }
        }
    }
}
