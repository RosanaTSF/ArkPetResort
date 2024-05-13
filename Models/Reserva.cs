namespace DesafioProjetoHospedagem.Models
{
    // Classe para representar uma Reserva
    public class Reserva
    {
        // Construtor que inicializa a reserva com dias reservados
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados > 0 ? diasReservados : throw new ArgumentException("Dias reservados devem ser maior que zero.");
        }

        // Propriedades da reserva
        public List<Pet> Hospedes { get; private set; } = new List<Pet>();
        public Suite Suite { get; private set; }
        public int DiasReservados { get; private set; }

        // Método para adicionar um pet à reserva
        public void CadastrarHospede(Pet pet)
        {
            if (Suite == null)
                throw new InvalidOperationException("A suíte deve ser cadastrada antes de adicionar hóspedes.");

            if (Suite.Capacidade < Hospedes.Count + 1)
                throw new InvalidOperationException("A capacidade da suíte é menor que o número de hóspedes.");

            Hospedes.Add(pet);
        }

        // Método para adicionar uma suíte à reserva
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite ?? throw new ArgumentNullException(nameof(suite));
        }

        // Método para obter a quantidade de pets na reserva
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        // Método para calcular o valor da diária
        public decimal CalcularValorDiaria()
        {
            if (Suite == null)
                throw new InvalidOperationException("A suíte deve ser cadastrada antes de calcular o valor da diária.");

            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor *= 0.9m; // Aplica um desconto de 10%
            }

            return valor;
        }

        // Método para remover um pet da reserva
        public void RemoverHospede(Pet pet)
        {
            if (!Hospedes.Contains(pet))
                throw new InvalidOperationException("O pet não está na reserva.");

            Hospedes.Remove(pet);
        }

        // Método para verificar se um pet está na reserva
        public bool VerificarPetNaReserva(Pet pet)
        {
            return Hospedes.Contains(pet);
        }
    }
}