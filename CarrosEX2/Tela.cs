using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrosEX2.dominio;
using System.Globalization;

namespace CarrosEX2
{
    class Tela
    {
        public static void mostrarMenu()
        {
            Console.WriteLine("1 - Listar marcas");
            Console.WriteLine("2 - Listar carros de uma marca ordenadamente");
            Console.WriteLine("3 - Cadastrar marca");
            Console.WriteLine("4 - Cadastrar carro");
            Console.WriteLine("5 - Cadastrar acessório");
            Console.WriteLine("6 - Mostrar detalhes de um carro");
            Console.WriteLine("7 - Sair");
            Console.Write("Digite uma opção:");
        }

        public static void mostrarMarcas()
        {
            for (int i = 0; i < Program.marca.Count(); i++)
            {
                Console.WriteLine(Program.marca[i]);
            }
        }

        public static void cadastrarMarcas()
        {
            Console.WriteLine("Digite os dados da marca:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            int pos = Program.marca.FindIndex(x => x.codigo == codigo);
            if (pos == -1)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("País de origem: ");
                string paisDeOrigem = Console.ReadLine();
                Program.marca.Add(new Marca(codigo, nome, paisDeOrigem));

            }
            else
            {
                throw new ModelException("Código já cadastrado.");
            }
        }

        public static void mostrarCarros()
        {
            Console.Write("Digite o código da marca:");
            int codMarca = int.Parse(Console.ReadLine());
            int pos = Program.marca.FindIndex(x => x.codigo == codMarca);
            if (pos == -1)
            {
                throw new ModelException("Código da marca não encontrado: " + codMarca);
            }
            else
            {
                Console.WriteLine("Carros da marca " + Program.marca[pos].nome + ":");
                List<Carro> lista = Program.marca[pos].carro;
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine(lista[i]);
                }
                Console.WriteLine();


            }
        }


        public static void cadastraCarro()
        {
            Console.WriteLine("Digite os dados do carro:");
            Console.Write("Marca (código):");
            int codigo = int.Parse(Console.ReadLine());
            int pos = Program.marca.FindIndex(x => x.codigo == codigo);
            if (pos == -1)
            {
                throw new ModelException("Marca não cadastrada ou código inválido.");
            }
            else
            {
                Console.Write("Código do carro: ");
                int codigoCarro = int.Parse(Console.ReadLine());
                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();
                Console.Write("Ano: ");
                int ano = int.Parse(Console.ReadLine());
                Console.Write("Preço Básico: ");
                double precoBasico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Marca m = Program.marca[pos];
                Carro c = new Carro(codigoCarro, modelo, ano, precoBasico, m);
                m.addCarro(c);
                Program.carro.Add(c);

            }
        }

        public static void cadastrarAcessorio()
        {
            Console.WriteLine("Digite os dados do acessório: ");
            Console.Write("Carro(código): ");
            int codigo = int.Parse(Console.ReadLine());
            int pos = Program.carro.FindIndex(x => x.codigo == codigo);
            if (pos == -1)
            {
                throw new ModelException("Carro não cadastrado ou código inválido.");
            }
            else
            {

                Console.Write("Descrição: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Carro c = Program.carro[pos];
                Acessorio a = new Acessorio(nome, preco, c);
                c.acessorio.Add(a);


            }
        }
        public static void mostrarDetalhesCarro()
        {
            Console.Write("Digite o código do carro: ");
            int codigoCarro = int.Parse(Console.ReadLine());
            int pos = Program.carro.FindIndex(x => x.codigo == codigoCarro);
            if (pos == -1)
            {
                throw new ModelException("Carro não cadastrado ou código inválido.");
            }
            else
            {
                Carro c = Program.carro[pos];
                Console.WriteLine(c);
                
            }
        }
    }
}
