using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrosEX2.dominio;

namespace CarrosEX2
{
    class Program
    {
        public static List<Carro> carro = new List<Carro>();
        public static List<Marca> marca = new List<Marca>();
        public static List<Acessorio> acessorio = new List<Acessorio>();

        static void Main(string[] args)
        {
            int opcao = 0;

            Marca m1 = new Marca(1001, "Volkswagen", "Alemanha");
            Marca m2 = new Marca(1002, "General Motors", "Estados Unidos");

            Carro c1 = new Carro(101, "Fusca", 1980, 5000.00, m1);
            m1.addCarro(c1);
            Carro c2 = new Carro(102, "Golf", 2016, 60000.00, m1);
            m1.addCarro(c2);
            Carro c3 = new Carro(103, "Fox", 2017, 30000.00, m1);
            m1.addCarro(c3);
            Carro c4 = new Carro(104, "Gol", 2014, 25000.00, m1);
            m1.addCarro(c4);
            Carro c5 = new Carro(105, "Cruze", 2016, 30000.00, m2);
            m2.addCarro(c4);
            Carro c6 = new Carro(106, "Cobalt", 2015, 25000.00, m2);
            m2.addCarro(c5);
            Carro c7 = new Carro(107, "Cobalt", 2017, 35000.00, m2);
            m2.addCarro(c6);

            marca.Add(m1);
            marca.Add(m2);
            carro.Add(c1);
            carro.Add(c2);
            carro.Add(c3);
            carro.Add(c4);
            carro.Add(c5);
            carro.Add(c6);
            carro.Add(c7);

            while (opcao != 7)
            {
                Console.Clear();
                Tela.mostrarMenu();

                try
                {
                    opcao = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }
                if (opcao == 1)
                {
                    try
                    {
                        Tela.mostrarMarcas();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                        opcao = 0;
                    }

                }
                else if (opcao == 2)
                {
                    try
                    {
                        Tela.mostrarCarros();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                        opcao = 0;
                    }

                }
                else if (opcao == 3)
                {
                    try
                    {
                        Tela.cadastrarMarcas();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                        opcao = 0;
                    }
                }

                else if (opcao == 4)
                {
                    try
                    {
                        Tela.cadastraCarro();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                        opcao = 0;
                    }
                }
                else if (opcao == 5)
                {
                    try
                    {
                        Tela.cadastrarAcessorio();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                        opcao = 0;
                    }
                }
                else if (opcao == 6)
                {
                    try
                    {
                        Tela.mostrarDetalhesCarro();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                        opcao = 0;
                    }
                }
                else if (opcao == 7)
                {
                    Console.WriteLine("Carros.LTDA agradece sua preferência, fechando programa...");
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                    opcao = 0;
                }
                Console.ReadLine();
            }

        }
    }
}
