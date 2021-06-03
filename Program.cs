using System;

namespace dev_homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\n");
            
            Console.WriteLine(@"
            PROBLEMA 1: Los Conejos (Secuencia de Fibonacci)
            
            Supongamos que un granjero tiene un par de conejos.
            Los conejos tardan dos meses en alcanzar la madurez, y después de eso dan a luz a otro par de conejos cada mes.
            El problema era cómo saber cuántos pares de conejos habría en un mes determinado.


            Entonces:
            Durante el 1º mes tienes un par de conejos y, como no han madurado, no pueden reproducirse.
            Durante el 2º mes, todavía hay un solo par.
            Pero a principios del 3º mes, la primera pareja se reproduce por primera vez, por lo que hay 2 pares de conejos.
            Al comienzo del 4º mes, el primer par se reproduce de nuevo, pero el segundo par no está lo suficientemente maduro , por lo que hay 3 pares.
            En el 5º mes, el primer par se reproduce y el segundo par se reproduce por primera vez, pero el tercer par es todavía muy joven, por lo que hay 5 pares.

            El ritual de apareamiento continúa, pero lo que pronto notarás es que la cantidad de parejas de conejos que tienes en un mes dado es la suma de las parejas de conejos que has tenido en cada uno de los dos meses anteriores, así que la secuencia continúa...
            1... 1... 2... 3... 5... 8... 13... 21... 34... 55... y así.
            ");
            
            int meses = 10;  //Los meses que queremos saber que cantidad de conejos hay.
            
            int[] parejas = new int[meses];  
            parejas[0] = 1; //Durante el 1º mes tienes un par de conejos y, como no han madurado, no pueden reproducirse.
            parejas[1] = 1; //Durante el 2º mes, todavía hay un solo par.
            
            Console.WriteLine($"Mes 1 hay un total parejas: {parejas[0]}");
            Console.WriteLine($"Mes 2 hay un total parejas: {parejas[1]}");

            /*
            Pero a principios del 3º mes, la primera pareja se reproduce por primera vez, por lo que hay 2 pares de conejos.
            Al comienzo del 4º mes, el primer par se reproduce de nuevo, pero el segundo par no está lo suficientemente maduro , por lo que hay 3 pares.
            
            Es decir comenzamos a calcular desde el mes 3, y se calcula la suma de los dos meses anteriores (cantidad de conejos del mes 1 y mes 2)
            Para el mes 4 se sumara la cantidad de conejos del mes 3 y del mes 2
            Para el mes 5 se sumara la cantidad de conejos del mes 4 y del mes 4
            y asi sucesivamente.
            */ 

            for(int i = 2; i < meses; i++){
                //parejas[i] es el mes actual. (iniciamos en la posicion 2, que corresonde al mes 3)
                //parejas[i-1] es le mes anterior
                //parejas[i-2] es le mes anterior al anterior
                 parejas[i] = parejas[i-1] + parejas[i-2]; 
                 Console.WriteLine($"Mes {i+1} hay un total parejas: {parejas[i]}");
            }    


            Console.WriteLine("\n");

        }
    }
}
