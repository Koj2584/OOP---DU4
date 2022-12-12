using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___DU4
{
    class NakladniAuto
    {
        protected string spz;
        protected short nosnost;
        protected short hmotnostNakladu = 0;
        protected short HmotnostNakladu
        {
            get
            {
                return hmotnostNakladu;
            }

        }

        public NakladniAuto(string spz, short nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;
        }

        public void NalozNaklad(short vaha)
        {
            if (vaha + hmotnostNakladu > nosnost)
            {
                hmotnostNakladu = nosnost;
                MessageBox.Show("Nenaložilo se " + (vaha - nosnost) + " tun.");
            }
            else
                hmotnostNakladu += vaha;
        }

        public void VylozNaklad(short vaha)
        {
            if (vaha > hmotnostNakladu)
            {
                hmotnostNakladu = 0;
                MessageBox.Show("Chybějící náklad  " + (vaha - hmotnostNakladu) + " tun.");
            }
            else
                hmotnostNakladu -= vaha;
        }


    }
}