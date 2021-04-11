using System;

namespace IMC2
{
    class Program
    {
        static void Main(string[] args)
        {
            double  peso , altura , imc, resp2;
            Console.WriteLine("-------");
            Console.WriteLine("--IMC--");
            Console.WriteLine("-------\n");
            Console.Write("Digite seu peso em kg...:");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua altura em m...:");
            altura = Convert.ToDouble(Console.ReadLine());
            imc =  altura * altura;
            resp2 =  peso / imc;
            Console.WriteLine($"Seu IMC é {resp2} kg/m.");
            if(resp2 < 17){
                Console.WriteLine($"\nDiagnóstico:  Muito abaixo do peso");
            }
            else if(resp2 >=  17 & resp2 <=18.49){
                 Console.WriteLine($"\nDiagnóstico: Abaixo do peso");
            }
            else if(resp2 >=  18.5 & resp2 <=24.99){
                 Console.WriteLine($"\nDiagnóstico: Peso normal");
            }
            else if(resp2 >=  25 & resp2 <= 29.99){
                 Console.WriteLine($"Diagnóstico: 	Acima do peso");
            }
            else if(resp2 >=  30  & resp2 <= 34.99){
                 Console.WriteLine($"\nDiagnóstico: Obesidade I");
            }
            else if(resp2 >=  35  & resp2 <=  39.99){
                 Console.WriteLine($"\nDiagnóstico:  Obesidade II (severa)");
            }
            else if(resp2 >= 40){
                Console.WriteLine($"\nDiagnóstico: Obesidade III (mórbida) ");
            }
        
        
        }
    }
}
