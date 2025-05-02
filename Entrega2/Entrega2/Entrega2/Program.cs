
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

