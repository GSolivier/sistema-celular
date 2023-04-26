using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_celular
{
    public class Celular
    {
        public string Cor;
        public string Modelo;
        public string Tamanho;
        public bool Estado;
        public string MensagemUsuario = null;
        public string CelularUser;
        

        public void Ligar(){
            Console.Clear();
            Console.WriteLine($"O celular está ligando...");
            Thread.Sleep(3000);
            Estado = true;
        }
        
        public void Desligar(){
            Console.Clear();
            Console.WriteLine($"O celular está desligando...");
            Thread.Sleep(3000);
            Estado = false;
        }

        public void Chamada(){
            if (Estado == false)
            {
                Console.WriteLine($"O celular está desligado! Ligue ele antes de realizar uma ligação");
                Console.WriteLine($"");
                
                Console.WriteLine($"Aperte qualquer botão para retornar ao menu.");
                Console.ReadKey();
            }
            else{
                Console.WriteLine($"Realizando Ligação...");
                Thread.Sleep(3000);
                Console.WriteLine($"Ligação finalizada.");
                Console.WriteLine($"");
                Console.WriteLine($"Aperte qualquer botão para retornar ao menu.");
                Console.ReadKey();
                
            }
        }

        public void Mensagem(){
            if (Estado == false)
            {
                Console.WriteLine($"O celular está desligado! Ligue ele antes de enviar uma mensagem");
                Console.WriteLine($"");
                

                Console.WriteLine($"Aperte qualquer botão para retornar ao menu.");
                Console.ReadKey();
            }
            else{
                Console.Write("Digite uma mensagem: ");
                MensagemUsuario = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{CelularUser}: {MensagemUsuario}");
                Console.WriteLine($"");
                Console.WriteLine(@$"                       Anônimo: Oi, estou bem e você?");
                Console.WriteLine($"");
                MensagemUsuario = Console.ReadLine();
                DeletePrevConsoleLine();
                Console.WriteLine($"{CelularUser}: {MensagemUsuario}");
                Console.WriteLine($"");
                Console.WriteLine(@$"                       Anônimo ficou offline.");
                Console.WriteLine($"");
                
                Thread.Sleep(3000);
                Console.WriteLine($"Chat com 'Anônimo' encerrado.");
                Console.WriteLine($"");
                

                Console.WriteLine($"Aperte qualquer botão para retornar ao menu.");
                Console.ReadKey();
            }
        }

        private static void DeletePrevConsoleLine()
{
    Console.SetCursorPosition(0, Console.CursorTop);
    Console.Write(new string(' ', Console.WindowWidth)); 
    Console.SetCursorPosition(0, Console.CursorTop - 1);
}
    }
}