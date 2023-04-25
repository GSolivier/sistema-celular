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

        public void Ligar(){
            Console.WriteLine($"O celular está ligando...");
            Thread.Sleep(3000);
            Estado = true;
        }
        
        public void Desligar(){
            Console.WriteLine($"O celular está desligando...");
            Thread.Sleep(3000);
            Estado = false;
        }

        public void Chamada(){
            if (Estado == false)
            {
                Console.WriteLine($"O celular está desligado! Ligue ele antes de realizar uma ligação");

                Console.WriteLine($"Aperte qualquer botão para retornar ao menu.");
                Console.ReadKey();
            }
            else{
                Console.WriteLine($"Realizando Ligação...");
                Thread.Sleep(3000);
                Console.WriteLine($"Ligação finalizada.");

                Console.WriteLine($"Aperte qualquer botão para retornar ao menu.");
                Console.ReadKey();
                
            }
        }

        public void Mensagem(){
            if (Estado == false)
            {
                Console.WriteLine($"O celular está desligado! Ligue ele antes de enviar uma mensagem");

                Console.WriteLine($"Aperte qualquer botão para retornar ao menu.");
                Console.ReadKey();
            }
            else{
                Console.WriteLine($"Enviando Mensagem...");
                Thread.Sleep(3000);
                Console.WriteLine($"Mensagem enviada.");

                Console.WriteLine($"Aperte qualquer botão para retornar ao menu.");
                Console.ReadKey();
            }
        }
    }
}