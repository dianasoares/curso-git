using System;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Produto a, b;

            a = new Produto();

            Console.WriteLine("Cadastre um novo produto..");
            Console.WriteLine("Nome:");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Preco");
            a.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade em estoque");
            a.Quantidade = int.Parse(Console.ReadLine());

            a.MostraDados();

            Console.WriteLine("Digite o valor a ser add: ");
            a.AdicionarProdutos(int.Parse(Console.ReadLine()));

            a.MostraDados();

            Console.WriteLine("Digite o valor a ser removido: ");
            a.RemoverProdutos(int.Parse(Console.ReadLine()));

            a.MostraDados();
            
            //NULLABLES
            
            double? number = null;
           

            if (number.HasValue)
                Console.WriteLine(number.Value);
            else
                Console.WriteLine("number nao tem valor");

            double t = number ?? 50.77;
            Console.WriteLine(t);

            //
            Console.WriteLine("Cadastro de conta");


            //nome do titular
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            while (nome.Length < 3)
            {
                Console.WriteLine("Nome inválido, digite seu nome novamente...");
                nome = Console.ReadLine();
            }

            //numero da conta

            Console.WriteLine("Digite o numero da Conta (6 digitos)");
            string numero = Console.ReadLine();

            while (numero.Length < 6)
            {
                Console.WriteLine("Numero inválido, digite seu nome novamente...");
                numero = Console.ReadLine();
            }

            //deposito

            double depInicial = 0.0;

            Console.WriteLine("Depósito inicial? S/N");
            char dep = char.Parse(Console.ReadLine());


            if (dep == 'S' || dep == 's')
            {
                Console.WriteLine("Digite o valor do deposito");
                depInicial = double.Parse(Console.ReadLine());
            }


            Conta c = new Conta(nome, numero, depInicial);

            c.detalhes();

            //operações
            bool emUso = true;

            while (emUso)
            {
                Console.WriteLine("Qual operação quer realizar? D= depósito, S= saque, I= informações da conta, E= sair");
                char option = char.Parse(Console.ReadLine());

                if (option == 'd' || option == 'D')
                {
                    Console.WriteLine("Digite o valor do deposito");
                    double valor = double.Parse(Console.ReadLine());
                    bool depositar = c.deposito(valor);

                    if (depositar)
                    {
                        Console.WriteLine($"Depóstio realizado com sucesso. Saldo atual: {c.Saldo}");
                    }
                    else Console.WriteLine("Erro no depósito! Tente novamente mais tarde...");
                }
                else if (option == 's' || option == 'S')
                {
                    Console.WriteLine("Digite o valor do saque (será cobrada uma taxa de 5,0 reais) ");
                    double valor = double.Parse(Console.ReadLine());
                    bool saque = c.saque(valor);

                    if (saque)
                    {
                        Console.WriteLine($"Saque realizado com sucesso. Saldo atual: {c.Saldo}");
                    }
                    else Console.WriteLine("Erro no saque! Tente novamente mais tarde...");
                }
                else if (option == 'I' || option == 'i')
                {

                    c.detalhes();
                }
                else if (option == 'E' || option == 'e')
                {

                    emUso = false;
                }
            }

           

            

            Console.WriteLine("Digite o numero de estudantes que alugaram quartos");
            int n = int.Parse(Console.ReadLine());

            Estudante[]? vect = new Estudante[10];

            

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite o quarto que ele irá ocupar");
               int position =  int.Parse(Console.ReadLine());

                vect[position] = new Estudante();

                vect[position].Quarto = position;

               Console.WriteLine($"Digite o nome do estudante");
                
                vect[position].Nome = (Console.ReadLine());

                Console.WriteLine($"Digite o e-mail do estudante");
                vect[position].Email = (Console.ReadLine());

               

            }

            

            for (int i = 0; i < 10; i++)
            {
                
                    if (vect[i] != null)
                        Console.WriteLine($"Estudante: {vect[i].Nome} - email: {vect[i].Email} - quarto: {vect[i].Quarto}");
               
            }

           
            //LISTAS

            List<string> list = new List<string>();

            //adicionar 
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            list.Remove("Alex");
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            
            //MATRIZES
            Console.WriteLine("Digite as dimensões da matriz");

            string[] leitura = Console.ReadLine().Split(' ');

            int l = int.Parse(leitura[0]);
            int c = int.Parse(leitura[1]);

            int[,] matriz = new int[l, c];

            for (int i = 0; i < l; i++)
            {
                Console.WriteLine($"Digite os {c} valores da {i} linha");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < c; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            for (int i = 0; i < l; i++)
            {



                for (int j = 0; j < c; j++)
                {
                    Console.Write($"[{matriz[i, j]}] ");
                }
                Console.WriteLine(" \n ");
            }

            Console.WriteLine($"Valor a ser achado");
            int toBeFound = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (matriz[i, j] == toBeFound)
                    {
                        if (i > 0) Console.Write($" Valor acima:[{matriz[(i - 1), j]}] ");
                        if (i < matriz.GetLength(0)-1) Console.Write($" Valor abaixo:[{matriz[(i + 1), j]}] ");
                        if (j < matriz.GetLength(0)-1) Console.Write($" Valor direita:[{matriz[i, (j + 1)]}] ");
                        if (j > 0) Console.Write($" Valor esquerda:[{matriz[i, (j - 1)]}] ");

                    }
                }
                Console.WriteLine(" \n ");
            }
             */

            DateTime hojeNow = DateTime.Now;
            DateTime hojeUTC = DateTime.UtcNow;
            DateTime hoje = DateTime.Today;
            Console.WriteLine(hojeNow);
            Console.WriteLine(hojeUTC);
           // Console.WriteLine(hoje);
            Console.WriteLine(hoje.ToString());

        }
    }
}
