
// ********Exemplo 1********//

using System;
using System.IO;

namespace ExemploSR01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abrindo arquivo para gravação
            StreamReader arquivo = new StreamReader(@"C:\temp\arq.txt");

            String linha = arquivo.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = arquivo.ReadLine();
            }
            arquivo.Close();
            Console.ReadKey();
        }
    }
}

// ********Exemplo 2********//

/*using System;
using System.IO;

namespace ExemploSR02
{
    class Program
    {
        static Double IMC(Double P, Double A)
        {
            return P / Math.Pow(A, 2);
        }
        static void Main(string[] args)
        {
            // Abrindo arquivo para gravação
            StreamReader arquivo = new StreamReader(@"C:\temp\arq.txt");
            string nome;
            char sexo;
            int idade;
            Double peso, altura;

            nome = arquivo.ReadLine();
            while (nome != null)
            {
                sexo = char.Parse(arquivo.ReadLine());
                idade = int.Parse(arquivo.ReadLine());
                peso = Double.Parse(arquivo.ReadLine());
                altura = Double.Parse(arquivo.ReadLine());

                Console.WriteLine($"Nome..: {nome}");
                Console.WriteLine($"Sexo..: {sexo}");
                Console.WriteLine($"Idade.: {idade}");
                Console.WriteLine($"Peso..: {peso}");
                Console.WriteLine($"Altura: {altura}");
                Console.WriteLine($"IMC..: {IMC(peso, altura):0.00}\n");
                nome = arquivo.ReadLine();
            }
            arquivo.Close();
            Console.ReadKey();
        }
    }
}*/

// ********Exemplo 3********//

/*﻿using System;
using System.IO;

namespace ExemploSW01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abrindo arquivo para gravação
            StreamWriter arquivo = new StreamWriter(@"C:\temp\arq.txt", true);
            // Gravando dados do João da Silva (nome, sexo, idade, peso, altura)
            arquivo.WriteLine("João da Silva");
            arquivo.WriteLine('M');
            arquivo.WriteLine(45);
            arquivo.WriteLine(85);
            arquivo.WriteLine(1.78);

            // Gravando dados do Maria José (nome, idade, peso, altura)
            arquivo.WriteLine("Maria José");
            arquivo.WriteLine('F');
            arquivo.WriteLine(53);
            arquivo.WriteLine(72);
            arquivo.WriteLine(1.69);

            // Gravando dados do Carlos Eudardo (nome, idade, peso, altura)
            arquivo.WriteLine("Carlos Eduardo");
            arquivo.WriteLine('M');
            arquivo.WriteLine(28);
            arquivo.WriteLine(81);
            arquivo.WriteLine(1.83);

            arquivo.Close();
        }
    }
}*/

// ********Exemplo 4********//

/*using System;
using System.IO;

namespace ExemploSW02
{
    class Program
    {
        static StreamWriter arquivo;

        static void AbreArquivo(string Path)
        {
            arquivo = new StreamWriter(@Path, true);
        }

        static void FechaArquivo()
        {
            arquivo.Close();
        }

        static void GravaDados(string nome, char sexo, int idade, Double peso, Double altura)
        {
            arquivo.WriteLine(nome);
            arquivo.WriteLine(sexo);
            arquivo.WriteLine(idade);
            arquivo.WriteLine(peso);
            arquivo.WriteLine(altura);
        }

        static void Main(string[] args)
        {
            // Abrindo arquivo para gravação
            AbreArquivo(@"C:\temp\arq2.txt");
            // Gravando dados do João da Silva (nome, sexo, idade, peso, altura)
            GravaDados("João da Silva", 'M', 45, 85, 1.78);

            // Gravando dados do Maria José (nome, idade, peso, altura)
            GravaDados("Maria José", 'F', 53, 72, 1.69);

            // Gravando dados do Carlos Eudardo (nome, idade, peso, altura)
            GravaDados("Carlos Eduardo", 'M', 28, 81, 1.83);

            FechaArquivo();
        }
    }
}*/

// ********Exemplo 5********//

/*using System;
using System.IO;

namespace ExemploSW03
{
    class Program
    {
        static StreamWriter arquivo;

        static void AbreArquivo(string Path)
        {
            arquivo = new StreamWriter(@Path, true);
        }

        static void FechaArquivo()
        {
            arquivo.Close();
        }

        static void GravaDados(string n, char s, int i, Double p, Double a)
        {
            arquivo.WriteLine(n);
            arquivo.WriteLine(s);
            arquivo.WriteLine(i);
            arquivo.WriteLine(p);
            arquivo.WriteLine(a);
        }

        static void Main(string[] args)
        {
            string nome;
            char sexo;
            int idade;
            Double peso, altura;

            // Abrindo arquivo para gravação
            AbreArquivo(@"C:\temp\arq3.txt");

            Console.Write("Nome..: ");
            nome = Console.ReadLine();
            while(nome.ToUpper() != "FIM") 
            {   
                // Lê dados
                Console.Write("Sexo..: ");
                sexo = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Idade.: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                altura = Double.Parse(Console.ReadLine());
                Console.Write("Peso..: ");
                peso = Double.Parse(Console.ReadLine());
                // Grava os dados lidos no arquivo
                GravaDados(nome, sexo, idade, altura, peso);
                // Lê o nome da próxima pessoa
                Console.Write("Nome..: ");
                nome = Console.ReadLine();
            }
            FechaArquivo();
            Console.WriteLine("Dados gravados com sucesso!!!");
            Console.ReadKey();
        }
    }
}*/
