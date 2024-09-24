using System.Security.Cryptography.X509Certificates;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // *IMPLEMENTE AQUI*
            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("Quantidade de hóspedes excedeu a capacidade da Suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // *IMPLEMENTE AQUI*
            int valor = Hospedes.Count();
            return valor;
        }

        public decimal CalcularValorDiaria()
        {
           
            // *IMPLEMENTE AQUI*
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;
            Decimal desconto = 0.9m;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                valor *= desconto;
            }

            return valor;
        }
    }
}