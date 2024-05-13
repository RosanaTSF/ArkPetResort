namespace DesafioProjetoHospedagem.Models
{
    // Classe para representar uma Suite
    public class Suite
    {
        // Construtor que inicializa a suíte com tipo, capacidade e valor da diária
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite ?? throw new ArgumentException("Tipo da suíte não pode ser vazio ou nulo.");
            Capacidade = capacidade > 0 ? capacidade : throw new ArgumentException("Capacidade deve ser maior que zero.");
            ValorDiaria = valorDiaria > 0 ? valorDiaria : throw new ArgumentException("Valor da diária deve ser maior que zero.");
        }

        // Propriedades da suíte
        public string TipoSuite { get; }
        public int Capacidade { get; }
        public decimal ValorDiaria { get; private set; }

        // Método para alterar o valor da diária
        public void AlterarValorDiaria(decimal novoValor)
        {
            ValorDiaria = novoValor > 0 ? novoValor : throw new ArgumentException("Valor da diária deve ser maior que zero.");
        }

        // Método para verificar a disponibilidade da suíte
        public bool VerificarDisponibilidade(int quantidadePets)
        {
            return Capacidade >= quantidadePets;
        }
    }
}