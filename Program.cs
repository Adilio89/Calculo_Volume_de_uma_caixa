using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3._1_VolumeDeUmaCaixa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double comprimento, altura, largura, volume;
            Console.WriteLine("Calculo do Volume De Uma Caixa:");
            Console.Write("Digite o comprimento: ");
            comprimento = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("Digite a largura: ");
            largura = double.Parse(Console.ReadLine());
            volume = comprimento * altura * largura;
            Console.Write("O Volume da sua caixa é: " + volume + "cm³");
            Console.ReadKey();
        }
    }
}
