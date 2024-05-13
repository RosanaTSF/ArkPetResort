<h1 align="center">Ark Pet Resort</h1>
<h2 align="center">🐾 Projeto de Hospedagem de Pets 🐾</h2>

<p align="center">
Este projeto, desenvolvido em C#, implementa um sistema de hospedagem de pets, permitindo a criação e gerenciamento de pets, suítes e reservas.
</p>

---

## 📝 Resumo do Pedido

O objetivo deste projeto é criar um sistema de hospedagem de pets, utilizando os conceitos de programação orientada a objetos em C#. O sistema deve permitir a criação de pets, suítes e reservas, e deve ser capaz de calcular o valor da diária de uma reserva, levando em consideração a quantidade de pets e a duração da estadia. Além disso, o sistema deve aplicar um desconto de 10% para reservas de 10 dias ou mais.

---

## 📚 Conceitos e Implementações

O sistema utiliza vários conceitos de programação orientada a objetos, incluindo:

- **Classes e Objetos**: O sistema é composto por três classes principais: `Pet`, `Suite` e `Reserva`. Cada uma dessas classes é usada para criar objetos com propriedades e métodos específicos.

```csharp
Pet p1 = new Pet("Fido", "Cachorro", 2, "Labrador");
Suite suite = new Suite("Golden", 4, 100);
Reserva reserva = new Reserva(15);