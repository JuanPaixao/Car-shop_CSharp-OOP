using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CarrosEX2.dominio
{
    class Carro : IComparable
    {
        public int codigo { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public double precoBasico { get; set; }
        public List<Acessorio> acessorio { get; set; }
        public Marca marca;

   

        public Carro (int codigo, string modelo, int ano, double precoBasico, Marca marca)
        {
            this.codigo = codigo;
            this.modelo = modelo;
            this.ano = ano;
            this.precoBasico = precoBasico;
            this.marca = marca;
            acessorio = new List<Acessorio>();
        }

        public double precoTotal()
        {
            double soma = precoBasico;
             for (int i=0; i<acessorio.Count; i++)
            {
                soma = soma +acessorio[i].preco;
            }
            return soma;
        }

        public override string ToString()
        {
            String s = codigo +", "+modelo+ ", Ano: " + ano
                + ", Preço básico: " + precoBasico.ToString("F2", CultureInfo.InvariantCulture) 
                + ", Preço total:"+precoTotal().ToString("F2", CultureInfo.InvariantCulture);
            if (acessorio.Count > 0)
            {
                s = s + "\n Acessórios:";
                    for (int i=0; i<acessorio.Count; i++)
                {
                    s = s + "\n" + acessorio[i];
                }
            }
            return s;
        }

        public int CompareTo(object obj)
        {
            Carro outroCarro = (Carro)obj;
            int resultado = modelo.CompareTo(outroCarro.modelo);
                if(resultado != 0)
            {
                return resultado;
            } else
            {
                return -precoTotal().CompareTo(outroCarro.precoTotal());
            }
           
        }

    }
}
