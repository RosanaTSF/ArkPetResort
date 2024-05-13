namespace DesafioProjetoHospedagem.Models
{
    // Classe para representar um Pet
    public class Pet
    {
        // Construtor que inicializa o pet com nome, tipo, idade e raça
        public Pet(string nome, string tipo, int idade, string raca)
        {
            Nome = nome ?? throw new ArgumentException("Nome do pet não pode ser vazio ou nulo.");
            Tipo = tipo ?? throw new ArgumentException("Tipo do pet não pode ser vazio ou nulo.");
            Idade = idade;
            Raca = raca ?? throw new ArgumentException("Raça do pet não pode ser vazia ou nula.");
        }

        // Propriedades do pet
        public string Nome { get; }
        public string Tipo { get; }
        public int Idade { get; }
        public string Raca { get; }

        // Método para obter as informações do pet
        public string InformacaoPet => $"{Nome} {Tipo} {Idade} {Raca}".ToUpper();
    }
}