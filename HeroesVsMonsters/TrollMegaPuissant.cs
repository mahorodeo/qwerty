using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    public class TrollMegaPuissant : Monster, ICuir
    {
        private int _Cuir;

        public int Cuir
        {
            get { return _Cuir; }
            private set { _Cuir = value; }
        }

        public TrollMegaPuissant(Coordonee Coordonee) : base(Coordonee)
        {
            System.Console.WriteLine("GRRRRRRRRRRR");
            //Cuir = De4.Lance();
        }

        public override string Icon
        {
            get { return "L"; }
        }
    }
}
