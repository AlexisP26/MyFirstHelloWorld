public class Program
{ 
 

 static void Main(string[] args)
    {
        //CONSTANTES
        const Double SUELDO_BASE = 150000, COMISION = 0.10, BENEFICIO = 100000;
        //VARIABLES: SUELDO,VENTAS Y COMISIONES
        Double VENTA1,VENTA2,VENTA3,COMISION1,COMISION2,COMISION3,COMISIONTOTAL,SUELDOTOTAL,VENTATOTAL,PROMEDIO;
        //INICIALIZAR LAS VARIABLES
        Console.WriteLine("INGRESE EL VALOR DE SU PRIMER VENTA");
        VENTA1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("INGRESE EL VALOR DE SU SEGUNDA VENTA");
        VENTA2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("INGRESE EL VALOR DE SU TERCER VENTA");
        VENTA3 = Convert.ToDouble(Console.ReadLine());
        //PROCESOS
        //1-¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes
        COMISIONTOTAL = ((COMISION) * (VENTA1 + VENTA2 + VENTA3));
        Console.WriteLine("EL DINERO QUE OBTENDRA EN COMISIONES POR LAS 3 VENTAS ES DE:"+ COMISIONTOTAL);
        //¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones? 
        SUELDOTOTAL = (COMISIONTOTAL + SUELDO_BASE);
        //¿Cuál fue la venta que le generó la mayor comisión? 
        if (VENTA1 > VENTA2 && VENTA1 > VENTA3)
        { Console.WriteLine("LA VENTA1 FUE LA QUE GENERO MAYOR COMISION:"); }
        else if (VENTA2 > VENTA1 && VENTA2 > VENTA3)
        { Console.WriteLine("LA VENTA2 FUE LA QUE GENERO MAYOR COMISION:"); }
        else
        { Console.WriteLine("LA VENTA3 FUE LA QUE GENERO MAYOR COMISION:"); }
        //¿Cuál fue el promedio de las comisiones que recibió por cada venta? 
        PROMEDIO = (COMISIONTOTAL / 3);
        Console.WriteLine("EL PROMEDIO QUE RECIBIO EN COMISIONES POR CADA VENTA ES DE:" + PROMEDIO);




    }
}

