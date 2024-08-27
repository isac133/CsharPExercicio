using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  1-   string? nome;
    string? sobrenome;

    int? n1;
    int? n2;
    Console.WriteLine($&quot;digite o primeiro numero&quot;);
    n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($&quot;digite o segundo numero:&quot;);
    n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($&quot;A soma dos dois numeros e: ({n1+n2})&quot;);

  2-  int? n1;
    int? n2;
    Console.WriteLine($&quot;digite o primeiro numero&quot;);
    n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($&quot;digite o segundo numero:&quot;);
    n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($&quot;A diferença do primeiro numero pelo segundo e: ({n1-
    n2})&quot;);

 3-  int? n1;
    int? n2;
    Console.WriteLine($&quot;digite o primeiro numero&quot;);
    n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($&quot;digite o segundo numero:&quot;);
    n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($&quot;A multiplicação entre os dois numeros  e:
    ({n1*n2})&quot;);

 4- int? n1;
    double? n2;
    Console.WriteLine($&quot;digite o primeiro numero&quot;);
    n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($&quot;digite o segundo numero:&quot;);
    n2 = Convert.ToInt32(Console.ReadLine());
    if(n2== 0  || n1 == 0)
    {
       Console.WriteLine(&quot;O segundo numero não pode ser 0:&quot;);
    }
    else

    {
       Console.WriteLine($&quot;A divisão entre dois  numeros  e: ({n1/n2})&quot;);
    }


 5- public static void EntradaSaida()
        {
            int n1;
            int n2;
            Console.WriteLine("digite o primeiro numero:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o segundo numero:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"o resto da divisão do primeiro numero pelo segundo e:{n1%n2}");
        }


  6- public static void EntradaSaida()
        {
            int n1;
           
            Console.WriteLine("Digite o primeiro numero:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O resto da divisão do primeiro numero pelo segundo e:{n1++}");

        }


   7-  public static void EntradaSaida()
        {
            int n1;
           
            Console.WriteLine("Digite o primeiro numero:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O resto da divisão do primeiro numero pelo segundo e:{n1--}");

        }

    8-   public static void EntradaSaida()
        {
            int n1;
            int n2;
           
            Console.WriteLine("Digite o primeiro numero:");
            n1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Digite o segundo numero numero:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A media e:{(n1+n2)/2}");

        }



      9-    int n1;
            int n2;
            int n3;
      
            Console.WriteLine("Digite o primeiro numero:");
            n1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Digite o segundo numero numero:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A media e:{(n1+n2)/2}");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A media e:{(n1 + n2)-n3}");

        }

    
     10-   public static void EntradaSaida()
        {
            int n1;
            int n2;
            int n3;

            Console.WriteLine("Digite o primeiro numero:");
            n1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Digite o segundo numero numero:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"o quadrado do primeiro numero mais o segundo e:{(n1 * n2)+n2}");

        }
    

  11-  public static void EntradaSaida()
        {
            int n1;
           

            Console.WriteLine("Digite um numero:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O dobro do numero e:{(2 * n1)}");
            Console.WriteLine($"A metade do numero  e:{(n1 / 2)}");

        }

    12-     int n1;
            int n2;
           
            Console.WriteLine("Digite um numero:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"digite o segundo numero e:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A diferença do quadrado dos dois numeros  e:{(n1 + n2) * (n1 - n2)}");

        }

   13- public static void EntradaSaida()
        {
            int n1;
            int n2;
           
            Console.WriteLine("Digite um numero:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Digite o segundo numero e:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O quadrado do primeiro mais o quadrado do segundo  e:{(n1 * n2) + (n1 - n2)}");

        }


     15-    int n1;
            int n2;
           
            Console.WriteLine("Digite o primeiro e:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O digite o segundo numero :");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"resultado da expressão (n1 * n1) / n2) e : { (n1 * (n2 + n1 ) /n2)}");
                
    
   16-         int n1;
            
            Console.WriteLine("Digite o primeiro numero:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"o quadrado de diferença entre o numero e 5 e :{(n1 + 5) * (n1 + 5)}");

     
    17-     int n1;
            int n2;

            Console.WriteLine("Digite o primeiro numero:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"digite o segundo numero :{(n1 + 5) * (n1 + 5)}");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"o quadrado de diferença entre o numero  e :{(n1 + n2)/2}");
   

    18- int n1;
           
            Console.WriteLine("Digite o primeiro numero:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A valor em reais convertidos em dolar  e:{(n1 + 5m)}");

    19-     int dias;
           
            Console.WriteLine("Digite o primeiro numero:?");
            dias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A quantidade de horas contidas nos dias informados  é:{(dias * 24)}");


    20-    Console.Write("Digite a hora e os minutos no formato HHMM (ex:1430 para 14:30):");
            string imput = Console.ReadLine();

            if (imput.Length == 4 && int.TryParse(imput, out _))
            {
                int horas = int.Parse(imput.Substring(0, 2));
                int minutos = int.Parse(imput.Substring(2, 2));

                int minutostotais = (horas * 60) + minutos;
                Console.WriteLine($"total em minutos: {minutostotais}");
            }
            else]


            {
                Console.WriteLine("Entrada inválida. certifique-se de digitar 4 digitos.");

            }
 */

namespace CursoCSharp
{
    public static class ExerciciosTiposPrimitivos
    {
        public static void EntradaSaida()
        {

            Console.Write("Digite a hora e os minutos no formato HHMM (ex:1430 para 14:30):");
            string imput = Console.ReadLine();

            if (imput.Length == 4 && int.TryParse(imput, out _))
            {
                int horas = int.Parse(imput.Substring(0, 2));
                int minutos = int.Parse(imput.Substring(2, 2));

                int minutostotais = (horas * 60) + minutos;
                Console.WriteLine($"total em minutos: {minutostotais}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. certifique-se de digitar 4 digitos.");

            }
                




        }

    }
            
}
