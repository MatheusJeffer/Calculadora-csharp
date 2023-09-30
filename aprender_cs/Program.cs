using System;
using System.Runtime.CompilerServices;

class Program
{
    private static void Main()
    {
        //Uma lista com os caracteres selecionados.
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
            string userInput = Console.ReadLine();
            
            //O loop vai acontecer enquanto o usuario digitar algo que não está na lista.
            while (!mathOperations.Contains(userInput))
            {
                Console.WriteLine("ERROR: Operação inexistente, digite novamente.");
                userInput = Console.ReadLine();

            }

            Console.Clear();

            if (userInput != "0")
            {
                //Um loop que executa o Try, e ele só vai ser quebrado se o usuario digitar um valor inteiro.
                while (true)
                {

                    try
                    {
                        Console.WriteLine("Digite o primeiro número");
                        Int64 num_1 = Int64.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número");
                        Int64 num_2 = Int64.Parse(Console.ReadLine());

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
                                try
                                {
                                    Console.WriteLine($"O resultado é {num_1 / num_2}");
                                }
                                catch (DivideByZeroException)
                                {
                                    Console.WriteLine("ERROR: Não é possível dividir por 0.");

                                }
                                break;
                        }
                        break;
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Digite um valor númerico inteiro.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("ERROR: Número muito grande.");
                    }
                }

                //Vai quebrar o programa quando o usuario digitar 0.
                if (userInput == "0")
                {
                    break;
                }

            }

        }
    }
}

