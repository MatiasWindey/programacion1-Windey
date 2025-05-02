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
