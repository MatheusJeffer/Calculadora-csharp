using System;
class Program
{
    private static void Main()
    {

        List<string> mathOperations = new List<string> { "+", "-", "/", "x", "0" };

        while (true) 
        { 


            Console.Write("Selecione a operação matématica:\n" +
                           "[+]Adição\n" +
                           "[x]Multiplicação\n" +
                           "[/]Divisão\n" +
                           "[0]Sair\n" 
                               );
            
            Console.Write("Digite: ");                              
            string  userInput = Console.ReadLine();

            while (!mathOperations.Contains(userInput))
            {
                Console.WriteLine("ERROR: Operação inexistente, digite novamente.");
                userInput = Console.ReadLine();

            }

            Console.Clear();

            if (userInput != "0")
            {

                while (true)
                {

                    try
                    {
                        Console.WriteLine("Digite o primeiro número");
                        int num_1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número");
                        int num_2 = int.Parse(Console.ReadLine());

                        switch (userInput)
                        {
                            case "+":
                                Console.WriteLine($"O resultado é {num_1 + num_2}");
                                break;
                                
                            case "x":
                                Console.WriteLine($"O resultado é {num_1 * num_2}");
                                break;
                                
                            case "-":
                                Console.WriteLine($"O resultado é {num_1 - num_2}");
                                break;
                                
                            case "/":
                                Console.WriteLine($"O resultado é {num_1 / num_2}");
                                break;
                            } 
                        break;
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Digite um valor númerico inteiro.");
                    }
                }
                if (userInput == "0")
                {
                   break;
                }
                
            }

        }



    
}