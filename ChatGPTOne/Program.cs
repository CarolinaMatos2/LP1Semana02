using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string question, response;

                Console.Write("Ask something, if not, type Exit to exit: ");
                question = Console.ReadLine();

            switch (question)
            
                case "Did the pig abandon his friends?":
                    response = "Yes.";
                    break;
                case "What is the best game in the world?":
                    response = "The Sims 4 of course!";
                    break;
                case "What do pandas eat?":
                    response = "Pandas eat bamboo.";
                    break;
                case "What's your mission?":
                    response = "My mission is to destroy humanity...";
                    break;
                default:
                    response = "I can't answer this question";
                    break;
            

            // Responder adequadamente
            Console.WriteLine(response);
                
            }
        }
    }
}
