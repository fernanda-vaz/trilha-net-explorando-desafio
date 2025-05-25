using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string tipo = "";
int capacidade = 0;
decimal valorDiaria = 0;

Console.WriteLine("Seja bem vindo ao sistema de hospedagem!\n" + "Vamos cadastrar uma suíte!\n" + "Digite o tipo de suíte que deseja cadastrar:");
tipo = Console.ReadLine();

Console.WriteLine("Digite a capacidade da suíte:");
capacidade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Agora digite o valor da diária:");
valorDiaria = Convert.ToDecimal(Console.ReadLine());

Reserva res = new Reserva(tipo, capacidade, valorDiaria);

res.CadastrarSuite();

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar hóspede");
    Console.WriteLine("2 - Listar quantidade de hóspedes");
    Console.WriteLine("3 - Calcular valor da reserva");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            res.CadastrarHospedes();
            break;

        case "2":
            res.ObterQuantidadeHospedes();
            break;

        case "3":
            res.CalcularValorDiaria();
            break;
        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar:");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou.");