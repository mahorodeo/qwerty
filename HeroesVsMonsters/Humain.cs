using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    public class Humain : Hero
    {
        public override int End
        {
            get
            {
                return base.End + 1;
            }
        }

        public override int For
        {
            get
            {
                return base.For + 1;
            }
        }

        public Humain(Coordonee Coordonee) : base(Coordonee)
        {

        }

        public override string Icon
        {
            get { return "H"; }
        }
    }
}
