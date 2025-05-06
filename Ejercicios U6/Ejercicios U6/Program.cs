/*

// 1- Realizar una encuesta a N usuarios que califiquen un servicio (1 al 5). Al final, mostrar el porcentaje de cada calificación.

int Contador = 0;
int Suma = 0;
int Calificacion;

do
{
    Console.Write("POR FAVOR INGRESE UNA CALIFICACION DE 1 A 5 PARA VALORAR EL SERVICIO, INGRESE UN '0' CUANDO QUIERA FINALIZAR: ");

    if (int.TryParse(Console.ReadLine(), out Calificacion))
    {

        Suma += Calificacion;
        Contador++;
    }

}while(Calificacion != 0);

Contador--;

Console.WriteLine($"La calificacion promedio del servicio es de {Suma/Contador}");

*/


//2- Registrar alumnos en 3 cursos (A, B, C), y luego listar cuántos hay en cada uno


string NombreA;
string NombreB;
string NombreC;


List<string> ListaA = new List<string>();
List<string> ListaB = new List<string>();
List<string> ListaC = new List<string>();

do
{

    Console.WriteLine("ingrese nombre de los alumnos del curso A (cuando no quiera ingresar mas precione enter): ");

    NombreA = Console.ReadLine();

    ListaA.Add(NombreA);
    
} while (!string.IsNullOrEmpty(NombreA));

Console.WriteLine(ListaA.Count - 1);

