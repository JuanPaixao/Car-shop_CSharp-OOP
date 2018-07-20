using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosEX2.dominio
{
    class Marca 
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string pais { get; set; }
        public List<Carro> carro {get;set;}
     

        public Marca (int codigo, string nome, string pais)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.pais = pais;
            carro = new List<Carro>();
        }
        public override string ToString()
        {
            return codigo+", "+nome
                +", País: "+pais+", Número de carros: "+
               carro.Count() ;
        }
        public void addCarro (Carro c)
        {
            carro.Add(c);
            carro.Sort();
        }

   
    }
}
