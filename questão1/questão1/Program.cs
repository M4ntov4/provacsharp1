using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questão1
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dataEvento = new DateTime();
            DateTime horaEvento = new DateTime();
            int sala = 0;
            double preco = 0;
            string estudante;
            DateTime aniversario;
            DateTime aniversario2;


            Console.Write("Insira a data do filme: ");
            dataEvento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Insira a hora do filme: ");
            horaEvento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Qual sala sera o filme: ");
            sala = int.Parse(Console.ReadLine());
            Console.Write("Qual sala o Valor do ingresso do filme: ");
            preco = int.Parse(Console.ReadLine());
            Console.Write("É estudante?: ");
            estudante = Console.ReadLine();


            EntradaDeCinema entrada = new EntradaDeCinema(dataEvento, horaEvento, sala, preco);

            switch (estudante)
            {
                case "nao":

                    Console.WriteLine("Insira sua data de aniversario: ");
                    aniversario = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine(entrada.CalculaDescontoDeMenor(aniversario, 20.00));
                    break;

                case "sim":
                    Console.WriteLine("Estudante insira sua data de aniversario: ");
                    aniversario2 = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine(entrada.CalculaDescontoEstudante(aniversario2, 1407746));
              
                    break;

            }


            if (horaEvento.Hour < 16)
            {
                Console.WriteLine(entrada.CalculaDescontoHorario(horaEvento));
            }






            Console.Write(entrada.EmitirEntrada());
            Console.ReadKey();
        }
    }
}
