using System.Runtime.Serialization.Formatters;
using System.Threading.Channels;

namespace Jogo_de_Adivinha
{
    // Numero de 1 a 20
    //adivinhação 1000 pontos
    //Fácil = 15 chances Médio = 10 chances Difícil = 5 chances
    //como encontrar numeros rondonicos no c# tarefa 

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************\n");

            Console.WriteLine(" Bem vindo! Adivinhe se Puder *\n");

            Console.WriteLine("*****************************************\n");


            Console.WriteLine("Insira a dificuldade do jogo (1 = fácil, 2 = médio, 3 = difícil):");
            int dificuldade = int.Parse(Console.ReadLine());

            int pontos = 1000;


            Console.WriteLine();

            Random aleatorio = new Random();   

            int numeroScreto= aleatorio.Next(0,20);

            int chances = aleatorio.Next(0,20);

            switch (dificuldade)
            {
                case 1:
                    chances = 15;
                    Console.WriteLine("Este é um jogo fácil. Você tem " + chances + " chances.");

                    break;
                case 2:
                    chances = 10;
                    Console.WriteLine("Este é um jogo médio. Você tem " + chances + " chances.");
                    break;
                case 3:
                    chances = 5;
                    Console.WriteLine("Este é um jogo difícil. Você tem " + chances + " chances.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }



            Console.WriteLine("O numero secreto é :\n" );

             

            Console.WriteLine("bem vindo {0}", "Academia Do Programador\n");

            
            
            

            for (int i = 0; i < chances; i++)
                

            {
                int chute = int.Parse(Console.ReadLine());


                Console.WriteLine("Você fez " + pontos + " pontos!");

                pontos = Math.Abs(pontos - (chute + numeroScreto) / 2) ;

                Console.Write("Qual o seu chute ? ");
               
                Console.WriteLine("Seu chute foi " + chute);



                int numeroChute = Convert.ToInt32(chute);


                bool acertou = numeroChute == numeroScreto;

                if (acertou)
                {
                    Console.WriteLine("Parabéns ! Vc acertou!");
                    Console.WriteLine(pontos);
                }
                else
                {
                    bool maior =numeroChute > numeroScreto;
                    if (maior)
                    {
                        Console.WriteLine("Seu chute foi maior que o número secreto!");
                        Console.WriteLine(pontos);

                    }
                    else
                    {
                        Console.WriteLine("Seu chute foi menor que o número secreto !");

                    }
                }
            }












        }
    }
}