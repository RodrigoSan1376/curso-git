using System;
using System.Globalization;
using System.Collections.Generic;

namespace ParaPraticar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa para ler um número inteiro N e a altura de N pessoas.
            Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
            pessoas.
            */

            //int N = int.Parse(Console.ReadLine());

            //double[] vect = new double[N];

            //for(int i = 0; i < N; i++)
            //{
            //    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                
            //}

            //double soma = 0.0;

            //for(int i = 0; i < N; i++)
            //{
            //    soma += vect[i];
            //}

            //double media = soma / N;

            //Console.WriteLine("AVERAGE HEIGHT = " + media.ToString("F2", CultureInfo.InvariantCulture));


            //--------------------------------------------------------------------------------------------------------


            /*
            Fazer um programa para ler um número inteiro N e os dados (nome e
            preço) de N Produtos. Armazene os N produtos em um vetor. Em
            seguida, mostrar o preço médio dos produtos.
            */

            //int N = int.Parse(Console.ReadLine());

            //Produto[] vect = new Produto[N];

            //for(int i = 0; i < N; i++)
            //{
            //    string nome = Console.ReadLine();
            //    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    vect[i] = new Produto { Nome = nome, Preco = preco };
            //}

            //double soma = 0.0;

            //for(int i = 0; i < N; i++)
            //{
            //    soma += vect[i].Preco;
            //}

            //double media = soma / N;

            //Console.WriteLine("AVERAGE PRICE = " + media.ToString("F2", CultureInfo.InvariantCulture));


            //--------------------------------------------------------------------------------------------------------


            //Suponha que se queira uma calculadora para calcular a soma de uma quantidade variável de valores.

            //int result = Calculator.Sum(10, 20, 30, 40);

            //Console.WriteLine(result);


            //--------------------------------------------------------------------------------------------------------


            //foreach

            //string[] vect = new string[] { "Maria", "Bob", "Alex" };

            //foreach(string name in vect)
            //{
            //    Console.WriteLine(name);
            //}


            //--------------------------------------------------------------------------------------------------------


            //Listas

            //List<string> list = new List<string>();

            //list.Add("Maria");     //A função "Add" adiciona cada item ao final da lista
            //list.Add("Alex");
            //list.Add("Bob");
            //list.Add("Marco");
            //list.Add("Anna");
            //list.Insert(0, "John");   //Já a função "Insert" permite você escolher em qual posição o item será inserido.

            //foreach (string name in list)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine();

            //Console.WriteLine("List count: " + list.Count);  //A Função "Count" calcula o tamanho da lista

            ////Nos próximos exemplos a sintaxe que está dentro de parênteses onde inicia com "x" se chama predicado.

            //string s1 = list.Find(x => x[0] == 'A'); /* A função "Find" procura, neste caso do exemplo, o primeiro item dentro da lista
            //                                          * no qual a letra "A" esteja na posição [0] deste item. */
            //Console.WriteLine("First name with 'A': " + s1);

            //string s2 = list.FindLast(x => x[0] == 'A');  /*A função "FindLast" funciona como a "Find" só que procura o ÚLTIMO item da
            //                                               * lista onde tem o 'A' na posição [0] deste item.*/
            //Console.WriteLine("Last name with 'A': " + s2);

            //int pos1 = list.FindIndex(x => x[0] == 'A'); /*A função "FindIndex" procura pela primeira posição, dentro da lista, de um   
            //                                              * item com os parâmetros que você escolher. Neste caso do exemplo procurou 
            //                                              * a primeira posição de um nome que inicia com a letra 'A',  
            //                                              * ou seja, quando a letra 'A' está na posição [0] do item. */

            //Console.WriteLine("Position of the first name with 'A': " + pos1);

            //int pos2 = list.FindLastIndex(x => x[0] == 'A');  /*A função "FindLastIndex" procura pela última posição, dentro da lista,   
            //                                              * de um item com os parâmetros que você escolher. Neste caso do exemplo 
            //                                              * a última posição de um nome que inicia com a letra 'A', 
            //                                              * ou seja, quando a letra 'A' está na posição [0] do item.*/

            //Console.WriteLine("Position of the last name with 'A': " + pos2);

            //Console.WriteLine("----------------------------------------------------------");

            //Console.WriteLine("Only names with 5 Chars:");

            //List<string> list2 = list.FindAll(x => x.Length == 5); /* A função "FindAll" procura pelo item conforme o parâmetro
            //                                                        * que você inseriu como predicado. No caso deste exemplo, procurou
            //                                                        * pelos nomes que contêm 5 caracteres. É necessário criar uma
            //                                                        * nova lista para exibir o resultado. Neste exemplo, foi criado
            //                                                        * a lista "list2".*/
            //foreach (string name in list2)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("----------------------------------------------------------");

            //Console.WriteLine("Remove 'Alex' from the list:");

            //list.Remove("Alex"); // A função "Remove" apaga um item da lista.

            //foreach (string name in list)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("----------------------------------------------------------");

            //Console.WriteLine("Remove names with 'M' at first char:");

            //list.RemoveAll(x => x[0] == 'M');  // A função "RemoveAll" apaga todos os itens da lista conforme o predicado.

            //foreach (string name in list)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("----------------------------------------------------------");

            //Console.WriteLine("Remove name in position [0]:");

            //list.RemoveAt(0); // A função "RemoveAt" apaga o item de acordo com a posição informada.
            //foreach (string name in list)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("----------------------------------------------------------");

            //Console.WriteLine("Added names to the list:");

            //list.Add("Stephen");
            //list.Add("Roger");
            //list.Add("Michael");
            //list.Add("Jonathan");

            //foreach (string name in list)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("----------------------------------------------------------");

            //Console.WriteLine("Removed two names, starting from position [2]:");

            //list.RemoveRange(2, 2);
            //foreach (string name in list)
            //{
            //    Console.WriteLine(name);
            //}


            //--------------------------------------------------------------------------------------------------------


            //Matrizes

            //double[,] mat = new double[2, 3];

            //Console.WriteLine(mat.Length);

            //Console.WriteLine(mat.Rank);

            //Console.WriteLine(mat.GetLength(0));

            //Console.WriteLine(mat.GetLength(1));

            /*Fazer um programa para ler um número inteiro N e uma matriz de
            ordem N contendo números inteiros. Em seguida, mostrar a diagonal
            principal e a quantidade de valores negativos da matriz.
            */

            //int n = int.Parse(Console.ReadLine());

            //int[,] mat = new int[n, n];

            //for(int i = 0; i < n; i++)
            //{
            //    string[] values = Console.ReadLine().Split(' ');
            //    for(int j = 0; j < n; j++)
            //    {
            //        mat[i, j] = int.Parse(values[j]);
            //    }
            //}

            //Console.WriteLine();

            //Console.WriteLine("Main Diagonal:");
            //for(int i = 0; i < n; i++)
            //{
            //    Console.Write(mat[i, i] + " ");
            //}

            //Console.WriteLine();

            //int count = 0;
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < n; j++)
            //    {
            //        if(mat[i, j] < 0)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine("Negative numbers = " + count);

            //--------------------------------------------------------------------------------------------------------

            Console.WriteLine("Teste de alteração do git");
        }
    }
}
