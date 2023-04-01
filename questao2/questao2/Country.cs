using System;                           // joao delaia
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao2
{
    class Country
    {

        string nome;
        string capital;
        double kilometrosQuadrados;
        string[] vizinhos = new string[5];

        public string Nome { get => nome; set => nome = value; }
        public string Capital { get => capital; set => capital = value; }
        public double KilometrosQuadrados { get => kilometrosQuadrados; set => kilometrosQuadrados = value; }
        public string[] Vizinhos { get => vizinhos; set => vizinhos = value; }


        public Country(string name, string capi, double km2, string[] vizi)
        {
            this.Nome = name;
            this.Capital = capi;
            this.KilometrosQuadrados = km2;
            this.Vizinhos = vizi;
        }

        public bool Igual(Country pais1, Country pais2)
        {
            if (pais1.Nome == pais2.Nome || pais1.Capital == pais2.capital)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Fronteira(Country pais1, Country pais2)
        {

                string[] seperacao1 = this.Vizinhos.Split 
                

        }



        ~Country() { }
    }
}
