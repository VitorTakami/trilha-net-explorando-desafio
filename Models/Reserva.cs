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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (Suite.Capacidade >= Hospedes.Count())
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
            int valor= Hospedes.Count();
            Console.WriteLine($"A quantidade de hóspedes é de : {valor}");
            return 0;
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