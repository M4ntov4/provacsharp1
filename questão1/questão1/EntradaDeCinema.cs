using System;                           //joao vitor delaia
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questão1
{
    class EntradaDeCinema
    {
        DateTime dataFilme = new DateTime();
        DateTime horaFilme = new DateTime();
        int sala;
        double valorEntrada;


        public int Sala { get => sala; set => sala = value; }
        public double ValorEntrada { get => valorEntrada; set => valorEntrada = value; }
        public DateTime DataFilme { get => dataFilme; set => dataFilme = value; }
        public DateTime HoraFilme { get => horaFilme; set => horaFilme = value; }

        public EntradaDeCinema(DateTime datafilm, DateTime horafilm, int room, double Ticket)
        {
            this.DataFilme = datafilm;
            this.HoraFilme = horafilm;
            this.Sala = room;
            this.ValorEntrada = Ticket;

        }

        public string CalculaDescontoDeMenor(DateTime dtNascimento, double valorTicket)
        {
            //DateTime aniver;
            TimeSpan intervalo = DateTime.Now - dtNascimento;
            int idade = intervalo.Days / 365;
            
            if (idade <= 12)
            {
                double desconto = this.ValorEntrada;
                desconto *= 0.5;
                this.ValorEntrada -= desconto;
                return "Ganhou 50% de deconto no ingresso, R$" + valorTicket + " Reais";
            }
            else
            {
                return "Você pagara: R$" + valorTicket + " Reais";
            }

        }

        public string CalculaDescontoEstudante(DateTime dtNascimento, int carteiraId)
        {
            TimeSpan intervalo = DateTime.Now - dtNascimento;
            int idade = intervalo.Days / 365;

            if (idade >= 12 && idade <= 15 )
            {
                double desconto = this.ValorEntrada;
                desconto *= 0.4;
                this.ValorEntrada -= desconto;
                return "Você ganhou 40% de desconto, totalizando: R$" + ValorEntrada + " Reais";
            }
            else
            {
                if (idade >= 16 && idade <= 20)
                {
                    double desconto = this.ValorEntrada;
                    desconto *= 0.3;
                    this.ValorEntrada -= desconto;
                    return "Você ganhou 30% de desconto, totalizando: R$" + ValorEntrada + " Reais";
                }
                else
                {
                    if (idade > 20)
                    {
                        double desconto = this.ValorEntrada;
                        desconto *= 0.2;
                        this.ValorEntrada -= desconto;
                        return "Você ganhou 20% de desconto, totalizando: R$" + ValorEntrada + " Reais";
                    }
                }
            }

            return "Você ganha 50%";


        }

        public string CalculaDescontoHorario(DateTime hora)
        {
            if (hora.Hour < 16)
            {
                double desconto = this.ValorEntrada;
                desconto *= 0.5;
                this.ValorEntrada -= desconto;
                return "Você ganhou 50% por assistir antes das 16:00, totalizando: R$" + ValorEntrada + " Reais";
            }
            else
            {
                return "Você ira assistir após as 16:00";
            }

        }

        public string EmitirEntrada()
        {
            return "A data do seu filme sera: " + DataFilme.Day + "/" + DataFilme.Month + " || No Horario de: " + HoraFilme.Hour + ":" + HoraFilme.Minute + " || Na sala: " + sala + " || No valor de: " + ValorEntrada;
        }


        ~EntradaDeCinema() { }

    }

    




}
