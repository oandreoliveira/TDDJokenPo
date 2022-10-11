using System;

namespace Jokenpo.Entities
{
    public class Partida
    {
        public void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Olá, eu sou o Robô!");
            Console.WriteLine("Vamos jogar Jokenpô?");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Menu");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Digite 1 para jogar Pedra");
            Console.WriteLine("Digite 2 para jogar Papel");
            Console.WriteLine("Digite 3 para jogar Tesoura");
            Console.WriteLine("Digite qualquer tecla para Sair");
            Console.WriteLine("-------------------------------------");
            Console.Write("Escolha uma opção para jogar: ");
        }
        public int Pessoa(string pessoa)
        {
            switch(pessoa)
            {
                case "1":
                Console.WriteLine("");
                Console.WriteLine("Você escolheu Pedra");
                return 1;
                case "2":
                Console.WriteLine("");
                Console.WriteLine("Você escolheu Papel");
                return 2;
                case "3":
                Console.WriteLine("");
                Console.WriteLine("Você escolheu Tesoura");
                return 3;
                default:
                Console.WriteLine("");
                Console.WriteLine("Volte sempre!");
                return 0;
            }
        }
        public int Robo(int robo)
        {
            if(robo == 1)
            {
                Console.WriteLine("O Robô escolheu Pedra");
                return 1;
            } 
            else if(robo == 2)
            {
                Console.WriteLine("O Robô escolheu Papel");
                return 2;
            }
            else
            {
                Console.WriteLine("O Robô escolheu Tesoura");
                return 3;
            }
        }
        public int Resultado(int opcao, int robo)
        {
            int resultado = opcao - robo;

            if(resultado <= 2 && resultado >= -2 && opcao > 0 && opcao < 4)
            {
                if(opcao == robo)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Resultado do jogo: Empate!");
                    return 0;
                }
                else if(resultado == 1 || resultado == -2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Resultado do jogo: Parabéns, você venceu!");
                    return 1;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Resultado do jogo: Você perdeu. Continue tentando");
                    return -1;
                }
            }
            else 
            {
                return 0;
            }
        }
    }
}