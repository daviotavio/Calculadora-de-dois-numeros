using System;
  namespace myapp
  {
      class Program3
      {
          static void Main(string[] args)
          {
             
             string op;
             float num1,num2,resultado;

             Console.Write("informe o primeiro número: ");
             num1 = float.Parse(Console.ReadLine());
             Console.Write("informe o segundo número: ");
             num2 = float.Parse(Console.ReadLine());
             Console.WriteLine("Qual operação você deseja: adição, subtração, multiplicação ou divisão? ");
             op = Console.ReadLine();

             switch (op)
             {
                 case "adição":
                 resultado = num1 + num2;
                 Console.Write("O esultado da adição é: " + resultado);
                 break;

                 case "subtração":
                 resultado = num1 - num2;
                 Console.Write("O esultado da subtração é: " + resultado);
                 break;

                 case "multiplicação":
                 resultado = num1 * num2;
                 Console.Write("O esultado da multiplicação é: " + resultado);
                 break;

                 case "divisão":
                 resultado = num1 / num2;
                 Console.Write("O esultado da divisão é: " + resultado);
                 break;

                 default:
                 Console.Write("operação inválida.");
                 break;
             }
          }    
      }   
  }    