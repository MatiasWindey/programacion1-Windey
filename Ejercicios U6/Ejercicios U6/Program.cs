/*

// 1- Realizar una encuesta a N usuarios que califiquen un servicio (1 al 5). Al final, mostrar el porcentaje de cada calificación.

int Contador1 = 0;
int Contador2 = 0;
int Contador3 = 0;
int Contador4 = 0;
int Contador5 = 0;


int Calificacion;

do
{
    Console.Write("POR FAVOR INGRESE UNA CALIFICACION DE 1 A 5 PARA VALORAR EL SERVICIO, INGRESE UN '0' CUANDO QUIERA FINALIZAR: ");

    if (int.TryParse(Console.ReadLine(), out Calificacion))
    {
        if (Calificacion == 1)
        {



        }


    }

}while(Calificacion != 0);


Console.WriteLine($"La calificacion promedio del servicio es de");


*/



/*

//2- Registrar alumnos en 3 cursos (A, B, C), y luego listar cuántos hay en cada uno


string NombreA;
string NombreB;
string NombreC;


List<string> ListaA = new List<string>();
List<string> ListaB = new List<string>();
List<string> ListaC = new List<string>();

do
{

    Console.WriteLine("ingrese nombre de los alumnos del curso A (cuando no quiera ingresar mas presione enter): ");

    NombreA = Console.ReadLine();

    ListaA.Add(NombreA);
    
} while (!string.IsNullOrEmpty(NombreA));



do
{

    Console.WriteLine("ingrese nombre de los alumnos del curso B (cuando no quiera ingresar mas presione enter): ");

    NombreB = Console.ReadLine();

    ListaB.Add(NombreB);

} while (!string.IsNullOrEmpty(NombreB));



do
{

    Console.WriteLine("ingrese nombre de los alumnos del curso C (cuando no quiera ingresar mas presione enter): ");

    NombreC = Console.ReadLine();

    ListaC.Add(NombreC);

} while (!string.IsNullOrEmpty(NombreC));



Console.WriteLine($"La cantidad de los alumnos ingresados para cada curso es de: Curso A = {ListaA.Count -1} Curso B = {ListaB.Count -1} y Curso C = {ListaC.Count -1}");


*/





/*


// Verificar si un array de enteros se lee igual de izquierda a derecha que de derecha a izquierda.

int num;

int[] arreglo = new int[7];
int[] arreglont = new int[7];

for (int i = 0; i < 7; i++)
{
    Console.Write("Ingrese un valor: ");
    if (int.TryParse(Console.ReadLine(), out num))
    {

        arreglo[i] = num;
        arreglont[i] = num;

    }

}

Array.Reverse(arreglont);

if (arreglo.SequenceEqual(arreglont))
{
    
    Console.WriteLine($"el arreglo es capicua Normal: {string.Join(", ", arreglo)}  reversa: {string.Join(", ", arreglont)}");
}
else
{
   
    Console.WriteLine($"el arreglo no es capicua Normal: {string.Join(", ", arreglo)} Reversa: {string.Join(", ", arreglont)}" );
}

*/


/*


// Eliminar los valores duplicados de una lista.


int num;
List<int> Lista = new List<int>();


do
{
    Console.Write("ingrese un valor (cuando no quiera ingrese un 0): ");

    if (int.TryParse(Console.ReadLine(), out num))
    {

        Lista.Add(num);
    }   

} while (num != 0);

Lista.Remove(0);

List<int> SinDuplicados = Lista.Distinct().ToList();

Console.WriteLine($"La lista con numeros duplicados es {(String.Join(", ", Lista))}");
Console.WriteLine($"La lista sin numeros duplicasod es {(String.Join(", ", SinDuplicados))}");

*/


// Ordenar una lista de enteros usando el algoritmo de burbuja.



//Rotar los elementos de un array una posición a la derecha.

using System.ComponentModel;

int[] arreglo = new int[6];
int [] arregloOrdenado = new int[6];
arreglo[0] = 1;
arreglo[1] = 2;
arreglo[2] = 3;
arreglo[3] = 4;
arreglo[4] = 5; 
arreglo[5] = 6;

arregloOrdenado [0] = arreglo[5];

List<int> ListaArreglo = new List<int>(arreglo)   




Console.WriteLine(string.Join( $"  ",  ));









