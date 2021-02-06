using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telefonni_seznam
{
    public class Cislo
    {
        private String jmeno;
        private int cislo;

        /**
         * Konstruktor telefoniho cila
         * @param jmeno jmeno osoby
         * @param cislo cislo osoby
         */
        public Cislo(String jmeno, int cislo){
            this.cislo = cislo;
            this.jmeno = jmeno;
        }

        /**
         * vraci jmseno
         * @return jmeno
         */
        public String getJmeno()
        {
            return jmeno;
        }

        /**
         * vraci cislo
         * @return cislo
         */
         public int getCislo()
        {
            return cislo;
        }

        /**
         * formatovany vystup
         * @return textovou reprezentaci instance
         */
        public override string ToString(){
            return string.Format("{0,-9} , {1,-10}",cislo, jmeno);
        }
    }
}
