using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leds
{
    internal class Led
    {
        private byte dado;

        public Led()
        {
            this.dado = 0;
        }
        public Led(byte dado)
        {
            this.dado = dado;
        }
        public void Acender(int led)
        {
            dado = (byte)((int)dado | (int)(Math.Pow(2, (led - 1))));
        }
        public void Apagar(int led)
        {
            dado = (byte)((int)dado & (255 - (int)(Math.Pow(2, (led - 1)))));
        }

        public byte Getdados()
        {
            return dado;
        }

        public bool Getled(int led)
        {
            byte teste;
            teste = (byte)((int)dado & (int)(Math.Pow(2, (led - 1))));
            return (teste > 0);

        }
    }
}
