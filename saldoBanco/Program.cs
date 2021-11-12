using System;

namespace saldoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            double saldoPessoa, saldoDeposito, saldoSaque;
            Console.WriteLine("Digite o número da ação que deseja executar:\n" +
                "1 - Depósito\n" +
                "2 - Saque\n" +
                "3 - Ver saldo");
            codigo = Convert.ToInt32(Console.ReadLine());

            saldoPessoa = 0;
            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Você escolheu a ação depósito!\n" +
                        "Digite o valor que deseja depositar em sua conta:");
                    saldoDeposito = Convert.ToDouble(Console.ReadLine());
                    saldoPessoa = saldoPessoa + saldoDeposito;
                    
                    Console.WriteLine($"O saldo da sua conta bancária agora é R${saldoPessoa.ToString("0.00")}.");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a ação saque!\n" +
                        "Digite o valor que deseja sacar da sua conta:");
                    saldoSaque = Convert.ToDouble(Console.ReadLine());
                    saldoPessoa = saldoPessoa - saldoSaque;

                    Console.WriteLine($"O saldo da sua conta bancária agora é R${saldoPessoa.ToString("0.00")}.");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a ação ver saldo!\n" +
                        $"Seu saldo atual é R${saldoPessoa.ToString("0.00")}.");
                    break;
            }
        }
    }
}
