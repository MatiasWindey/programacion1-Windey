
// Crea una función que reciba 2 números y los sume.
/*

int x = 7;

int y = 5;

int Suma = Sumanumeros(x, y);

Console.WriteLine(Suma);

int Sumanumeros(int sx, int sy)
{

    return sx + sy;

}
*/

/*

//Crea una función que reciba una lista de números y devuelve la suma de los mismos.

List<int> Lista = new List<int> { 5, 10, 20, 30, 40 };
List<int> Lista1 = new List<int> { 5, 10, 20, 30, 400 };

int suma = 0;

int SumaLista = ElementosSumados(Lista);

int ElementosSumados(List<int> ListaEntrada)
{

    foreach (int x in Lista)
    {

        

        suma += x;

    }
    return suma;

}

Console.WriteLine(SumaLista);

*/

//Crea una función que reciba 2 números y devuelva su multiplicación.

/*
 
int x = 7;

int y = 5;

int Multiplicacion = Multiplicacionnumeros(x, y);

Console.WriteLine(Multiplicacion);

int Multiplicacionnumeros(int mx, int my)
{

    return mx * my;

}

*/

// Crea una función que reciba un string y devuelva la cantidad de vocales que contiene.

/*



string Vocales = "aeiouAEIOU";
string palabra = "Achicoria";


int NumeroVocales = VocalesN(palabra);


Console.WriteLine(NumeroVocales);



int VocalesN(string PalabraDada)
{
    int contador = 0;

    foreach (char letra in PalabraDada)
    {


        if (Vocales.Contains(letra))

        {
            contador++;


        }


    }

      return contador;

}

*/

// Crea una función que reciba un texto con varias palabras separadas por espacios y devuelve la palabra más larga.


/*
string PalabraLarga (string texto)
{

    string[] palabras = texto.Split(' ');

    string PalabraMasLarga = " ";

   

    foreach (string i in palabras)
    {

        if (i.Length >= PalabraMasLarga.Length)
        {

            PalabraMasLarga = i;
            polipalabras.Add(i);

        }


    }
    return PalabraMasLarga;
   
}

string frase = "viva la libertad adfghjkl";

string resultado = PalabraLarga(frase);

Console.WriteLine(resultado);

*/

//Crea una función que reciba un número entero y devuelve la suma de sus dígitos.

/*

int caracteresseparasdos(int numeros)
{

    int suma = 0;
    

    foreach (char numero in numeros.ToString())
    {

        suma += int.Parse(numero.ToString());

    }
    return suma;
}

int cadena = 12345;

int totalsuma = caracteresseparasdos(cadena);

Console.WriteLine(totalsuma);

*/


//Crea una función que devuelva un array con la tabla de multiplicar de un número recibido hasta el 10.

/*

int[] tablas(int numero)
{
    List<int> tablasLista = new List<int>();
    int multiplicacion;

    for (int i = 0; i <= 10; i++)
    {

        multiplicacion = numero * i ;
        
        tablasLista.Add(multiplicacion);
        
    }

    int[] TablasArray = tablasLista.ToArray();



    return TablasArray;
}

int numerodado = 2;

int[] tablaDeMultiplicar = tablas(numerodado);

Console.WriteLine($"las tablas de multiplicar del numero {numerodado} del 1 al 10 son {(string.Join(",", tablaDeMultiplicar))}");

*/

// Crea una función que devuelva cuántas veces aparece una letra específica en un texto.

/*

char letradada = 'a';

string frase = "papas con mayonesa con milanesa con coca cola";

int palabracantidad = cantidad(frase,letradada);


Console.WriteLine(palabracantidad);


int cantidad(string Texto, char Letrabuscada)
{


    int contador = 0;


    foreach (char i in Texto)
    {

        if (char.ToLower(i) == char.ToLower(Letrabuscada))
        {

            contador++;
        }

        
    }
    return contador;
}

*/


//Función que muestra todos los números pares entre dos valores dados (inclusive).








