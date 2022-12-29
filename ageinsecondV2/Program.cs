using System;

public class Program 
{
    static void Main() 
    {
        Console.WriteLine("Welcome to the age calculator in seconds");

        int natural = 365;
        int bisiesto = 366;
        int resultadoBisiesto = 0;
        int resultado = 0;

        Console.Write("Por favor introduce el año a convertir: ");
        int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuál formato de salida eliges");
            Console.WriteLine("1. Horas");
            Console.WriteLine("2. Minutos");
            Console.WriteLine("3. Segundos");
            Console.WriteLine("4. Full Time (H:mm:ss)");
            Console.WriteLine("Elige una de las cuatro opciones");
            int opcion = Convert.ToInt32(Console.ReadLine());


        switch (opcion)
        {
            case 1:
                if (year % 4 == 0){
                    Console.WriteLine("Ojo este es un año bisiesto");            
                    resultadoBisiesto = (bisiesto * 24);
                    Console.WriteLine($"El año {year} consta de: " + resultadoBisiesto + " horas");
                } else{
                    resultado = (natural * 24 );
                    Console.WriteLine($"El año {year} consta de: " + resultado + " horas");       
                }
            break;

            case 2:
                if (year % 4 == 0){
                    Console.WriteLine("Ojo este es un año bisiesto");            
                    resultadoBisiesto = (bisiesto * 24 * 60);
                    Console.WriteLine($"El año {year} consta de: " + resultadoBisiesto + " minutos");
                } else{
                    resultado = (natural * 24 * 60);
                    Console.WriteLine($"El año {year} consta de: " + resultado + " minutos");       
                }
            break;

            case 3:
                if (year % 4 == 0){
                    Console.WriteLine("Ojo este es un año bisiesto");            
                    resultadoBisiesto = (bisiesto * 24 * 3600);
                    Console.WriteLine($"El año {year} consta de: " + resultadoBisiesto + " segundos");
                } else{
                    resultado = (natural * 24 * 3600);
                    Console.WriteLine($"El año {year} consta de: " + resultado + " segundos");       
                }
            break;

            case 4:
                if (year % 4 == 0){
                    Console.WriteLine("Ojo este es un año bisiesto");
                    int horas = (bisiesto * 24);
                    int minutos = (bisiesto * 24 * 60);
                    int segundos = (bisiesto * 24 * 3600);
                    Console.WriteLine($"El año {year} consta de: " + horas + " horas " + 
                    minutos + " minutos " + segundos + " segundos ");
                } else{
                    int horas = (natural * 24);
                    int minutos = (natural * 24 * 60);
                    int segundos = (natural * 24 * 3600);
                    Console.WriteLine($"El año {year} consta de: " + horas + " horas " + 
                    minutos + " minutos " + segundos + " segundos ");       
                }
            break;
                
        }
        Console.WriteLine("Gracias por usar el programa");
        Console.ReadKey();
    }   
    
}
