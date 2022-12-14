using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___DU4
{
    class Tahac : NakladniAuto
    {
        private short nosnostVlecky;
        public short HmotnostNakladu
        {
            get
            {
                return this.hmotnostNakladu;
            }

        }

        public Tahac(string spz, short nosnost, short nosnostVlecky) : base(spz, (short)(nosnost+nosnostVlecky))
        {
            this.nosnostVlecky = nosnostVlecky;
        }

        public new void NalozNaklad(short vaha)
        {
            base.NalozNaklad(vaha);
        }

        public new void VylozNaklad(short vaha)
        {
            base.VylozNaklad(vaha);
        }

        public new string ToString()
        {
            return base.ToString();
        }
    }
}
