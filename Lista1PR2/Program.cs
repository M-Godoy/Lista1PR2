using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////exercício 1
            //int metros, cm, mm;

            //Console.WriteLine("Digite o número em metros: ");
            //metros = int.Parse(Console.ReadLine());
            //cm = metros * 100;
            //mm = metros * 1000;
            //Console.WriteLine("A quanridade em cm é: " + cm);
            //Console.WriteLine("A quanridade em mm é: " + mm);
            //Console.ReadKey();

            ////exercício 2
            //float f, C;
            //int gf, gc;

            //Console.WriteLine("Digite o valor dos graus em Fahrenheit int: ");
            //gf = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor dos graus em Fahrenheit float: ");
            //f =float.Parse(Console.ReadLine());

            //gc = (gf - 32) * (5 / 9);
            //C = (f - 32.0f) * (5.0f / 9.0f);

            //Console.WriteLine("Os graus celcius é: " + C);
            //Console.WriteLine("Os graus celcius é: " + gc);
            //Console.ReadKey();

            //exercício 3
            //double imc, peso, altura;

            //Console.WriteLine("digite seu peso atual : ");
            //peso = float.Parse(Console.ReadLine());
            //Console.WriteLine("digite sua altura atual : ");
            //altura = float.Parse(Console.ReadLine());

            //imc = peso / (altura * altura);

            //Console.WriteLine("O seu imc é: " + imc);
            //Console.ReadKey();

            //exercício 4
            //float n1, n2, n3, p1, p2, p3, sn, sp, mp;

            //Console.WriteLine("Digite o primeiro valor: ");
            //n1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo valor: ");
            //n2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o terceiro valor: ");
            //n3 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o primeiro peso: ");
            //p1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo peso: ");
            //p2 = float.Parse(Console.ReadLine()); 
            //Console.WriteLine("Digite o teceiro peso: ");
            //p3 = float.Parse(Console.ReadLine());

            //sp = p1 + p2 + p3;
            //sn = n1 + n2 + n3;
            //mp = sn / sp;

            //Console.WriteLine("A média ponderada desses valores será de: " +mp);
            //Console.ReadKey();

            ////exercício 5 - velocidade media 
            //float d, t, v;

            //Console.WriteLine("Digite o valor da distância [em kilometros]: ");
            //d = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade de tempo [em horas]: ");
            //t = float.Parse(Console.ReadLine());

            //v = d / t;

            //Console.WriteLine("A velocidade escalar média é igual a:" + v + "K/H");
            //Console.ReadKey();

            ////exercício 6
            //float sal1, sal2;

            //Console.WriteLine("Digite o valor do seu salário: ");
            //sal1 = float.Parse(Console.ReadLine());

            //sal2 = (sal1 * 0.25f) + sal1;

            //Console.WriteLine("O seu salário com o almento de 20% é: " + sal2);
            //Console.ReadKey();

            //Exercício 7.
            //float r, cd, d;

            //Console.WriteLine("Digite o valor em real: ");
            //r = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a cotação do dólar: ");
            //cd = int.Parse(Console.ReadLine());

            //d = r / cd;

            //Console.WriteLine("Resultado: US$" + d);

            //Console.ReadKey();


            //Exercício 8.
            //int n, s, a, r;

            //Console.WriteLine("Digite um número: ");
            //n = int.Parse(Console.ReadLine());

            //s = n * 3 + 1;
            //a = n * 2 - 1;
            //r = s + a;

            //Console.WriteLine("Resultado: " + r);

            //Console.ReadKey();


            //Exercício 9.
            //int  n, p, s, t, q;

            //Console.WriteLine("Digite um valor de 4 dígitos: ");
            //n = int.Parse(Console.ReadLine());

            //p = n / 1000;
            //s = n / 100 - p * 10;
            //t = n / 10 - p * 100 - s * 10;
            //q = n - p * 1000 - s * 100 - t * 10;

            //Console.WriteLine(p);
            //Console.WriteLine(s);
            //Console.WriteLine(t);
            //Console.WriteLine(q);

            //Console.ReadKey();




            //Exercício 10.
            //float r = 1000, pd = 3.4f / 100, sd = 2.8f / 100, td = 14 / 100, qd = 8.5f / 100, vpd, vsd, vtd, vqd;

            //vpd = r - pd;
            //vsd = vpd + sd;
            //vtd = vsd + td;
            //vqd = vtd - qd;

            //Console.WriteLine("O valor atual dos investimentos de Marquesito é de: R$" + vqd);

            //Console.ReadKey();




            //Exercício 11.
            //int n, q, c;

            //Console.WriteLine("Digite um número: ");
            //n = int.Parse(Console.ReadLine());

            //q = n * n;
            //c = n * n * n;

            //Console.WriteLine("O número " + n + " ao quadrado é " + q + " e ao cubo é " + c);

            //Console.ReadKey();




            //Exercício 12.
            //String g;
            //float h, pi;

            //Console.WriteLine("Você é homem ou mulher? ");
            //g = Console.ReadLine();

            //if(g == "homem")
            //{
            //    Console.WriteLine("Digite a sua altura: ");
            //    h = float.Parse(Console.ReadLine());

            //    pi = (72.7f * h) - 58;

            //    Console.WriteLine("Peso ideal: " + pi);
            // }
            //else 
            //{
            //    Console.WriteLine("Digite a sua altura: ");
            //    h = float.Parse(Console.ReadLine());

            //    pi = (62.1f * h) - 44.7f;

            //    Console.WriteLine("Peso ideal: " + pi);
            //}
            //Console.ReadKey();



            //Exercício 13.
            //O que é o GIT?
            //O GIT é um sistema de controle gratuito. Ele é utilizado para a criação de um código-fonte de projetos de desenvolvimento de software.
            //O que é o GITHUB?
            //O GITHUB é um repositório remoto, criado como um serviçço online de hospedagem de repositórios do GIT.

            //10 comandos do GIT:
            //Git Add:Precisamos usar este comando para incluir as alterações feitas no nosso próximo commit.
            //Git Push:Envia arquivos de um repositório local para um repositório remoto.
            //Git Init:Dá origem a um reositório novo ou reinicializa um já existente.
            //Git Pull:Traz um arquivo de um repositório remoto para um repositório local.
            //Git Clone:Faz uma cópia do projeto em um repositório e salva no computador.
            //Git Merge:Serve para unir arquivos alterados ao arquivo original de um projeto.
            //Git Checkout:Usado para trocar de uma branch para outra. Também ode ser usado para fazer o chekout de arquivos e commits.
            //Git Log:Permite a visualização do histórico de um arquivo ou usuário, ou o acesso de uma versão específica.
            //Git Commit:Move os arquivos da state area para um repositório local.
            //Git Branch:Usando as Branches´, vários desenvolvedores conseguem trabalhar em paralelo no mesmo projeto simultaneamente.
        }
    }
}
