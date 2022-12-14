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

        public NakladniAuto(string spz, short nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;
        }

        protected virtual void NalozNaklad(short vaha)
        {
            if (vaha > nosnost - hmotnostNakladu)
            {
                MessageBox.Show("Nenaložilo se " + (vaha - (nosnost - hmotnostNakladu)) + " tun.");
                hmotnostNakladu += (short)(nosnost - hmotnostNakladu);
            }
            else
                hmotnostNakladu += vaha;
        }

        protected virtual void VylozNaklad(short vaha)
        {
            if (vaha > hmotnostNakladu)
            {
                MessageBox.Show("Chybějící náklad  " + (vaha - hmotnostNakladu) + " tun.");
                hmotnostNakladu = 0;
            }
            else
                hmotnostNakladu -= vaha;
        }

        protected new virtual string ToString()
        {
            return "Nákladní auto " + spz + " má nosnost " + nosnost + "t a má naloženo " + hmotnostNakladu + "t";
        }
    }
}