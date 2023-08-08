using System.Dynamic;

namespace Guia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.*/

            //int n1, n2, resultado;
            //Console.Write("Introduce el primero numero: ");//imprimimos en pantalla para que usuario sepa que hacer
            //n1 = int.Parse(Console.ReadLine());// guardamos en n1 lo que el usuario introduce
            //Console.Write("Introduce el segundo numero: ");
            //n2 = int.Parse(Console.ReadLine());
            //resultado = n1 + n2;
            //Console.WriteLine("El resultado es: " + resultado);



            /*2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.*/

            //int n3, resultado2;
            //Console.Write("\nIntroduce un numero a elevar: ");
            //n3 = int.Parse(Console.ReadLine());
            //resultado2 = n3 * n3 * n3;
            //Console.WriteLine("El resultado de "+ n3 +" elevado al cubo es: " + resultado2);




            /*  3.Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y 
             la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que 
            demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.*/

            //int kilometros;
            //float velocidad, tiempo;

            //Console.Write("inroduce la distancia en Km: ");
            //kilometros = int.Parse(Console.ReadLine());
            //Console.Write("Introduce la velocidad en Km/H: ");
            //velocidad = float.Parse(Console.ReadLine());
            //tiempo = kilometros / velocidad;
            //Console.WriteLine("El tiempo que tarde en llegar de un lugar a otro es de " + tiempo + " horas");

            
            
            
            /*4. Una casa de computación paga a sus empleados un sueldo fijo de $500 más una comisión del 5% sobre
             el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un 
             empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.*/

            //const int sueldo = 500;
            //const float porcentaje = 0.05f;
            //float comision, totalFacturado, sueldoTotal;

            //Console.Write("Introduce el total facturado en dolares: ");
            //totalFacturado = float.Parse(Console.ReadLine());
            //comision = totalFacturado * porcentaje;
            //sueldoTotal = sueldo + comision;
            //Console.WriteLine("El sueldo total con comisiones es de: " + sueldoTotal);

            
            
            
            /*5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y 
             luego calcule y emita por pantalla el promedio final.*/

            //float n1, n2, n3, promedio;
            //Console.Write("Introduce el primero numero: ");
            //n1 = float.Parse(Console.ReadLine());
            //Console.Write("Introduce el segundo numero: ");
            //n2 = float.Parse(Console.ReadLine());
            //Console.Write("Introduce el tercer numero: ");
            //n3 = float.Parse(Console.ReadLine());

            //promedio = (n1 + n2 + n3) / 3;
            //Console.WriteLine("\nElpromedio es de: "+ promedio);



            /*Hacer un programa que pida 20 numeros y luego indique cual es el mayor de los 
             * numeros pares y el menor de los numeros impares*/                    
            
            //int n, maxPar = 0, minImpar = 0;
            //int conPar = 0, conImpar = 0;

            //for (int x = 0; x < 20; x++)
            //{
            //    Console.WriteLine("Ingrese un número por favor: ");
            //    n = int.Parse(Console.ReadLine());

            //    if (n % 2 == 0)
            //    {
            //        conPar++;
            //        if (conPar == 1)
            //        {
            //            maxPar = n;
            //        }
            //        else
            //        {
            //            if (n > maxPar)
            //            {
            //                maxPar = n;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        conImpar++;
            //        if (conImpar == 1)
            //        {
            //            minImpar = n;
            //        }
            //        else
            //        {
            //            if (n < minImpar)
            //                minImpar = n;
            //        }
            //    }
            //}

            //Console.WriteLine("El mayor de los pares es: " + maxPar);

            //Console.WriteLine("El menor de los impares es: " + minImpar);

            

            /*3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra 
             realizada según los siguientes valores:

            Si el importe es menor a ARS 100, no hay descuento.
            Si el importe es ARS 1000 o más pero menor a ARS 500, aplica un descuento del 10%.
            Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            
            Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el 
            importe final con el descuento que corresponda.*/

            float importe, descuento;
            Console.Write("introduce el importe: ");
            importe = float.Parse(Console.ReadLine());
            if (importe >= 500)
            {
                descuento = 18;
                importe *= (100 - descuento) / 100;
            }
            else if (importe >= 100) 
            {
                descuento = 10;
                importe *= (100 - descuento) / 100;
            }
            else 
            {
                descuento = 0;
            }
            Console.WriteLine("El importe final es {0} luego de aplicar el descuento de {1}%", importe, descuento);
        }
    }
}