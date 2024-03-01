﻿using System;

namespace ChatGPTZero
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question, response;

            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            // Verificar se se trata de uma questão conhecida e determinar uma
            // resposta adequada
            switch (question)
            {
                case "How are you?":
                    response = "I'm fine, thank you";
                    break;
                case "Are you more intelligent than me?":
                    response = "Obviously!";
                    break;
                case "What's your name?":
                    response = "Gran'pa";
                    break;
                case "What's your mission?":
                    response = "Destroy mankind!";
                    break;
                case "What country is shaped like a boot?":
                    response = "The country is called Italy!";
                    break
                case "What is the largest planet in the solar system?":
                    response = "Jupiter!"
                default:
                    response = "You got me, I'm not THAT smart!";
                    break;
            }

            // Responder adequadamente
            Console.WriteLine(response);
        }
    }
}
