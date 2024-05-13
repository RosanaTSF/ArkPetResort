using System.Text;
using DesafioProjetoHospedagem.Models;
using System.Collections.Generic;

// Configuração para permitir acentuação
Console.OutputEncoding = Encoding.UTF8;

// Criação dos pets
Pet p1 = new Pet("Pet 1", "Cachorro", 2, "Labrador");
Pet p2 = new Pet("Pet 2", "Gata", 3, "Siamesa");
Pet p3 = new Pet("Pet 3", "Furão", 1, "Ferret");
Pet p4 = new Pet("Pet 4", "Gato", 4, "Persa");

// Criação da suíte
Suite suite = new Suite("Golden", 4, 100);

// Criação da reserva
Reserva reserva = new Reserva(15);
reserva.CadastrarSuite(suite);

// Adicionando os pets à reserva
reserva.CadastrarHospede(p1);
reserva.CadastrarHospede(p2);
reserva.CadastrarHospede(p3);
reserva.CadastrarHospede(p4);

// Exibindo informações sobre a reserva
Console.WriteLine($"Pets: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");