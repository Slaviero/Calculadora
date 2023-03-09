namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        { // escopo 

            //Console.WriteLine("Digite o numero desejado de operações: ");
            //int numeroDeOperacoes = Convert.ToInt32(Console.ReadLine());
            //int numeroRealizadoDeOperacoes = 0;
            //bool ehPraContinuar = true;

            do 
            {
                
                Console.Clear();
                
                Console.Write("Calculadora TOP 2023!");

                Console.WriteLine();

                Console.Write("\n1 = soma \n2 = subtração \n3 = Divisão \n4 = Multiplicação \nLetra S = Sair\nVocê também pode gerar uma tabuada inserindo o numero 5! " +
                    "\nDigite a operação desejada aqui: ");


                string operacao = Console.ReadLine();
                
                if (operacao == "5")
                {
                    Console.Write("Digite o numero que deseja a tabuada: ");
                    int tabuada = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <=10; i++)
                    {
                        int resultadoMultiplicacao = tabuada * i;

                        Console.WriteLine(tabuada + " X " + i + " = " + resultadoMultiplicacao);
                    }

                    #region utilizando while para laço de repetição
                    //int numero = 1;

                    //while (numero <= 10)
                    //{
                    //    int resultadoMultiplicacao = tabuada * numero;
                    //    Console.WriteLine(tabuada + " X " + numero + " = " + resultadoMultiplicacao);

                    //    numero = numero + 1;
                    //}
                    #endregion
                    
                    Console.ReadLine();
                    continue;
                }

                if (operacao == "S" || operacao == "s")
                {
                    break;
                }

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "S" && operacao != "s" && operacao != "5")
                {
                    Console.WriteLine("opção Invalida, tente novamente.");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine();
                Console.Write("Digite o primeiro valor: ");
                
                string strPrimeirovalor = Console.ReadLine();
                decimal primeirovalor = Convert.ToDecimal(strPrimeirovalor);

                Console.Write("Digite o segundo valor: ");
                
                string strSegundovalor = Console.ReadLine();
                decimal segundovalor = Convert.ToDecimal(strSegundovalor);

                //Decimal, float e double  são tipos de variavel que possibilita ter casas decimais nas operações

                decimal resultadoOperacao = 0;

                switch(operacao)
                {
                    case "1": resultadoOperacao = primeirovalor + segundovalor; break;
                    case "2": resultadoOperacao = primeirovalor - segundovalor; break;
                    case "3":
                        {
                            while (segundovalor == 0)
                            {
                                Console.WriteLine("Numero invalido, o segundo numero não pode ser ZERO!!!");
                                Console.WriteLine();
                            }
                        }
                        resultadoOperacao = primeirovalor / segundovalor; break;

                    case "4": resultadoOperacao = primeirovalor * segundovalor; break;
                }
                #region Usando Else If para escolha de operação
                if (operacao == "1")
                {
                    resultadoOperacao = primeirovalor + segundovalor;
                }
                else if (operacao == "2")
                {
                    resultadoOperacao = primeirovalor - segundovalor;
                }
                else if (operacao == "3")
                {
                    while (segundovalor == 0)
                    {
                        Console.WriteLine("Numero invalido, o segundo numero não pode ser ZERO!!!");
                        Console.WriteLine();
                    }
                    resultadoOperacao = primeirovalor / segundovalor;
                }
                else if (operacao == "4")
                {
                    resultadoOperacao = primeirovalor * segundovalor;
                }
                #endregion

                decimal resultadoformatado = Math.Round(resultadoOperacao,2); //Formatar o resultado para reduzir casas decimais, o numero 2 ao lado do resultado é a quantidade de casas utilizadas

                Console.WriteLine($"O resultado de sua conta é: {resultadoformatado}");

                Console.ReadLine();

            } while (true);
            
        }


    }
}