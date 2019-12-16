using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euromilh
{
    class euromilhões
    {
        private int nestrelas = 0, nnumero = 0;
        private const string cruz = "X";
        private bool[] numeros = new bool[50];
        private bool[] estrelas = new bool[12];
        public string numero(int n)
        {
            if (numeros[n])
            {
                numeros[n] = false;
                nnumero--;
            }
            else if (nnumero < 5)
            {
                numeros[n] = true;
                nnumero++;
            }
            if (numeros[n]) return cruz;
            else return "";
        }
        public string estrela(int n)
        {
            if (estrelas[n])
            {
                estrelas[n] = false;
                nestrelas--;
            }
            else if (nestrelas < 2)
            {
                estrelas[n] = true;
                nestrelas++;
            }
            if (estrelas[n]) return cruz;
            else return "";
        }
        public string listanum
        {
            get
            {
                string lista = "";
                for (int i = 0; i<50; i++)
                if (numeros[i])
                    {
                        if (lista != "") lista += "+";
                        lista += (i + 1).ToString();
                    }
                return lista;

            }

        }
        public string listao
        {
            get
            {
                string listam = "";
                for (int i = 0; i < 12; i++)
                    if (estrelas[i])
                    {
                        if (listam != "") listam += "+";
                        listam += (i + 1).ToString();
                    }
                return listam;

            }
        }
        public string sorteion
        {
            get
            {
                int min = 1;
                int max = 50;
                Random random = new Random();
                return Convert.ToString(random.Next(min, max)) + "+" + Convert.ToString(random.Next(min, max)) + "+" + Convert.ToString(random.Next(min, max) + "+" + Convert.ToString(random.Next(min, max) + "+" + Convert.ToString(random.Next(min, max))));
            }
        }
        public string sorteioe
        {
            get
            {
                int min = 1;
                int max = 12;
                Random random = new Random();
                return Convert.ToString(random.Next(min, max)) + "+" + Convert.ToString(random.Next(min, max));

            }
        }
    }
}
 