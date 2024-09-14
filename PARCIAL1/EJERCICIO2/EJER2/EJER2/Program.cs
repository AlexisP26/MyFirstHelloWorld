public class Program
{


    static void Main(string[] args)
    {
        //VARIABLES
        double A, B;
        //INICIALIZAR
        Console.WriteLine("INGRESE EL VALOR DE A:");
        A=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("INGRESE EL VALOR DE B:");
        B = Convert.ToDouble(Console.ReadLine());
        //OPERAR
      
            if (A == 0 && B == 0)
            { Console.WriteLine("LA ECUACION TIENE INFINITAS SOLUCIONES.");}
            else if (A == 0)
            {Console.WriteLine("LA ECUACION NO TIENE SOLUCION."); }
            else
            {double X = -B / A;
                Console.WriteLine($"LA SOLUCION DE LA ECUACION ES : {X}");
            }
        }
    }







