/*

//  Carga un array con 10 números aleatorios entre 1 y 100. Mostrar el mayor y el menor.

int menor = 100; 
int mayor = 0;

int[] numeros = new int[10];

Random random = new Random();

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = random.Next(101);
   
    Console.WriteLine(numeros[i]);

    if (numeros[i] > mayor)
    {
        mayor = numeros[i];
    }
    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}
Console.WriteLine($"el mayor es  {mayor} y el menor es  {menor}");

*/

/*

//  Solicitar al usuario 8 nombres y almacenarlos en un array. Mostrar cuántos empiezan con la letra 'A'.

int Contador = 0;
string[] nombres = new string[8];

for (int i = 0; i < nombres.Length; i++)
{
    Console.WriteLine("ingrese un nombre");
    string NuevoNombre = Console.ReadLine().Replace ("a", "A");
    

    nombres[i] = NuevoNombre;


    if (NuevoNombre.StartsWith("A"))
    {
        Contador++;
        
    }

}
Console.WriteLine("La cantidad de nombres que comienzan con A son: " + Contador);

*/

/*

//Ingresar 10 números y mostrar cuántos son positivos, negativos y ceros.

int Contador = 0;
int ContadorNeg = 0;
int ContadorPos = 0;

int[] num = new int[10];

for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine($"ingrese un numero");
    if (int.TryParse(Console.ReadLine(), out int numeros))
    {
        num[i] = numeros;

        if (num[i] == 0)
        {
            Contador++;
        }
        else if (num[i] > 0)
        {
            ContadorPos++;
        }
        else if (num[i] < 0)
        {
            ContadorNeg++;
        }
    }
}
     


Console.WriteLine($"La cantidad de numero negativos ingresados es de {ContadorNeg} la cantidad de positivos es de {ContadorPos} y de ceros es de {Contador}");


*/

/*

//Crear un array con los días de la semana y mostrar solo los días laborales

string[] dias = new string[] { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(dias[i]);
}


*/



// Solicitar al usuario que ingrese 5 números enteros y guardarlos en una lista. Luego calcular y mostrar la suma total de los elementos

/*

int num;
int suma = 0;

List<int> lista = [5];

for (int i = 0; i < 5; i++)
{
    Console.Write("ingrese un numero entero: ");
    if (int.TryParse(Console.ReadLine(), out num))
    {
        lista[i] = num;
    }    
    
    suma += num;

}
Console.WriteLine(suma);

*/

/*

//  Pedir al usuario que ingrese 7 números y guardarlos en una lista. Luego pedir otro número y verificar si está en la lista. Mostrar un mensaje informando si se encontró o no.
int num2;
int num;
List<int> lista = [7];

for (int i = 0; i < 7; i++)
{
    Console.Write("Ingrese un numero: ");
    if (int.TryParse(Console.ReadLine(), out num))
    {

        lista[i] = num;
    }
    Console.WriteLine(num);
    

}
Console.WriteLine("ingrese otro numero");
if (int.TryParse(Console.ReadLine(), out num2))
{

    if (lista.Contains(num2))
    {
        Console.WriteLine($"se encontro el numero {num2} en la lista");
    }
    else
    {
        Console.WriteLine($"el numero {num2} no aparece en la lista");
    }
}


*/


/*

// Generar una lista con 10 números aleatorios entre 1 y 100. Luego pedir al usuario un valor límite y eliminar todos los elementos menores a ese valor.
//  Mostrar la lista resultante.



List<int> lista = [10];
 int num;
 int num2;
 Random random = new Random();

for (int i = 0; i < 10; i++)
{
    lista[i] = random.Next(101);
    Console.WriteLine($"{lista[i]}, ");

}
Console.Write("ingrese un valor limite: ");
if (int.TryParse(Console.ReadLine(), out num2))
{

    for (int i = 0; i < 10; i++)
    {
        if (lista[i] < num2)
        {
           lista.RemoveAt(i);
        } 
        Console.Write($" {lista[i]}, ");
    }

}

*/