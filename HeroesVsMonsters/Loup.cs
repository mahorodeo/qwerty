using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    public class Loup : Monster, ICuir
    {
        private int _Cuir;

        public int Cuir
        {
            get { return _Cuir; }
            private set { _Cuir = value; }
        }

        public Loup(Coordonee Coordonee) : base(Coordonee)
        {
            //Cuir = De4.Lance();
        }

        public override string Icon
        {
            get { return "L"; }
        }
    }
}
