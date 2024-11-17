using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {  //EJERCICIO    1                                                  21


            //int positivos, negativos, pares, impares, numeros, neutro, cantidad;

            //Console.WriteLine("Cuantos números desea ingresar?");
            //cantidad = Convert.ToInt32(Console.ReadLine());

            //positivos = 0;
            //negativos = 0;
            //pares = 0;
            //impares = 0;
            //neutro = 0;

            //for (int i = 0; i < cantidad; i++)
            //{
            //    Console.WriteLine($"Ingrese el número {i + 1} ");
            //    numeros = Convert.ToInt32(Console.ReadLine());
            //    if (numeros > 0)
            //        positivos++;

            //    else if (numeros < 0)
            //        negativos++;

            //    else neutro++;


            //    if (numeros % 2 == 0)
            //        pares++;

            //    else impares++;
            //}

            //Console.WriteLine($"Positivos = {positivos}");
            //Console.WriteLine($"Negativos = {negativos}");
            //Console.WriteLine($"Neutro = {neutro}");
            //Console.WriteLine($"Pares = {pares}");
            //Console.WriteLine($"Impares = {impares}");

            //Console.ReadKey();







            //EJERCICIO    2                                                   22

            //int Intentos = 0;
            //int MaxIntentos = 3;
            //int ContraseñaCorrecta = 0624;
            //int ContraseñaIngresada;
            //bool Ingresar = false;

            //Console.WriteLine("Para poder Entar debe de ingresar la contraseña correcta, para esto tendra 3 intentos. Empezando ya.");

            //while (Intentos < MaxIntentos)
            //{
            //    Console.WriteLine("Ingrese la contraseña");
            //    ContraseñaIngresada = int.Parse(Console.ReadLine());

            //    if (ContraseñaIngresada == ContraseñaCorrecta)
            //    {
            //        Console.WriteLine("La contraseña que ingresaste es correcta");
            //        Ingresar = true;

            //        Console.ReadKey();

            //        break;

            //    }


            //    else
            //    {
            //        ++Intentos;
            //        Console.WriteLine($"Contraseña  incorrecta. Tiene {+ (MaxIntentos - Intentos)}  intento/s");


            //    }
            //}


            //    if (!Ingresar)
            //    {
            //        Console.WriteLine("Ha agotado el numero de intentos y el programa debe terminar.");
            //    }
            //    Console.ReadKey();











            //EJERCICIO 3                                                         23


            //int sumatoria = 0;
            //int numero;

            //while (sumatoria < 100)
            //{
            //    Console.Write("Introduce un número entero: ");
            //    numero = int.Parse(Console.ReadLine());  
            //    sumatoria += numero;

            //    Console.WriteLine($"La suma es: {sumatoria}");
            //}

            //if (sumatoria == 100)
            //{
            //    Console.WriteLine("La Sumatoria alcanzó el límite. Es igual a 100.");
            //}
            //else if (sumatoria > 100)
            //{
            //    Console.WriteLine("La Sumatoria alcanzó el límite. Es mayor a 100.");
            //}

            //Console.ReadKey();





            //EJERCICIO 4                                                         24


            //int suma = 0;


            //for (int i = 1; i <= 100; i++)
            //{
            //    suma += i;
            //}

            //Console.WriteLine("La suma de los primeros 100 números naturales es: " + suma);
            //Console.ReadKey();








            //EJERCICIO 5                                                        25


            //int suma = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    suma += i;
            //}

            //double promedio = suma / 100.0;


            //Console.WriteLine("El promedio de los primeros 100 números naturales es: " + promedio);
            //Console.ReadKey();








            //EJERCICIO 6                                                        26


            //for (int i = 1; i <= 30; i++)
            //{
            //    if (i % 2 != 0) 
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.ReadKey();







            //EJERCICIO 7                                                        27

            //int numero, resultado;

            //Console.Write("Ingrese el número ");
            // numero = int.Parse(Console.ReadLine());  

            //Console.WriteLine($"La tabla de multiplicar del número {numero} es:");
            //Console.WriteLine("");

            //for (int i = 1; i <= 12; i++)
            //{
            //    resultado = numero * i;
            //    Console.WriteLine($"{numero}X{i}= {resultado}");

            //}

            //Console.ReadKey();







            //EJERCICIO 8                                                        28

            //int numero;
            //int suma= 0; 


            //do
            //{
            //    Console.WriteLine("Ingrese un número ");
            //   numero = int.Parse(Console.ReadLine());  

            //    suma += numero; 

            //} while (numero != 0);
            //Console.WriteLine("");
            //Console.WriteLine("Ingresaste 0, por ende ya no puedes siguir ingresando números");
            //Console.WriteLine("");

            //Console.WriteLine($"El resultado de la suma es: {suma}");
            //Console.ReadKey();








            //EJERCICIO 9                                                        29
            //Console.WriteLine("Según por la cantidad de filas será el tamaño del triangulo rectangúlo");
            //Console.WriteLine("");
            //Console.WriteLine("Introduce la cantidad de filas para el triángulo rectangúlo: ");
            //int filas = int.Parse(Console.ReadLine());
            //Console.WriteLine("");

            //for (int i = 1; i <= filas; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("L");
            //    }
            //    Console.WriteLine();
            //}



            //Console.ReadKey();





            //EJERCICIO  1                                               30

            //    int suma = sumar(2, 3);
            //    Console.WriteLine($"El resultado de la Suma es: {suma}");


            //    int multiplicar = multiplicacion(2, 3);
            //    Console.WriteLine($"El resultado de la Multiplicación es {multiplicar}");



            //     ParImpar(56);

            //    double pesosd = Convertir(200);
            //    Console.WriteLine($"200 dolares son {pesosd} Dominicanos");


            //    Console.ReadKey();
            //}


            //static int sumar(int n1, int n2)
            //{

            //    return n1 + n2;
            //}

            //static int multiplicacion(int n1, int n2)
            //{

            //    return n1 * n2;
            //}

            //static void ParImpar(int numero)
            //{
            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine($"{numero} es un número par.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{numero} es un número impar.");
            //    }

            //}

            //static int Convertir( int cantidad)
            //{
            //    int tasaCambio = 60; 
            //    return cantidad * tasaCambio;
            //}








            //EJERCICIO  1                                               31


            //int[] numeros = new int[10];
            //int suma =0;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Ingrese 10 números Naturales: {i+1} ");
            //    numeros[i] = int.Parse(Console.ReadLine());

            //}

            //Console.WriteLine("");

            //for(int i = 0; i< numeros.Length; i++)
            //{
            //    suma += numeros[i];


            //}

            //Console.WriteLine("La suma de los números es de: " + suma);

            //Console.ReadKey();








            //EJERCICIO  2                                               32

            //Console.WriteLine("Ingrese la cantidad de números que desea ingresar: ");
            //int cantidad = int.Parse(Console.ReadLine());

            //double[] numeros = new double [cantidad];
            //Console.WriteLine("Nota: los número decimales deben de ser representados por ¨,¨");
            //for(int i = 0; i<cantidad; i ++)
            //{
            //    Console.WriteLine("Ingrese el número decimal: ", i+1);
            //    numeros[i] = double.Parse(Console.ReadLine());
            //}
            //double prodcto = 1;
            //for (int i = 0; i<numeros.Length; i++)
            //{
            //    prodcto *= numeros[i];
            //    Console.WriteLine($"El producto es: " + prodcto);

            //}


            //Console.ReadKey();






            //EJERCICIO  3                                               33

            //    int par = 0;
            //    Console.Write("Ingrese la Cantidad de números:");
            //    int cantidad = int.Parse(Console.ReadLine());

            //    int[] numeros = new int[cantidad];

            //    for (int i = 0; i < cantidad; i++)
            //    {
            //        Console.WriteLine($"Ingrese el número: {i + 1}");
            //        numeros[i] = int.Parse(Console.ReadLine());


            //        if (numeros[i] % 2 == 0)
            //            ++par;

            //    }
            //    Console.WriteLine("La cantidad de números pares es: "+par);
            //    Console.ReadKey();







            //EJERCICIO  4                                               34
            //    int par = 0;
            //int impar = 0;
            //Console.Write("Ingrese la Cantidad de números:");
            //    int cantidad = int.Parse(Console.ReadLine());

            //    int[] numeros = new int[cantidad];

            //    for (int i = 0; i < cantidad; i++)
            //    {
            //        Console.WriteLine($"Ingrese el número: {i + 1}");
            //        numeros[i] = int.Parse(Console.ReadLine());


            //    if (numeros[i] % 2 == 0)
            //        ++par;
            //    else ++impar;

            //    }
            //    Console.WriteLine("La cantidad de números pares es: "+impar);
            //    Console.ReadKey();







            //EJERCICIO  5                                               35

            //int[] numeros = { 65, 3, 6, 1, 46, 81, 5, 2, 7, };

            //Console.WriteLine("Lista de Elementos Original");
            //Console.WriteLine("");

            //for (int i =0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}
            //Console.WriteLine("Lista de Elementos Ordenados de Forma Ascendente");
            //Console.WriteLine("");
            //Array.Sort(numeros);
            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}

            //Console.ReadKey();






            //int[] NumEnteros1 = new int[10];
            //int[] NumEnteros2 = new int[10];
            //int suma1 = 0;
            //int suma2 = 0;
            //int total = 0;

            //Console.WriteLine($"1ra vuelta");
            //Console.WriteLine($"Ingrese 10 números enteros");
            //for (int i = 0; i < NumEnteros1.Length; ++i)
            //{

            //    NumEnteros1[i] = int.Parse(Console.ReadLine());

            //    suma1 += NumEnteros1[i];

            //}

            //Console.WriteLine($"2da vuelta");
            //Console.WriteLine($"Ingrese 10 números enteros");
            //for (int i = 0; i < NumEnteros2.Length; ++i)
            //{

            //    NumEnteros2[i] = int.Parse(Console.ReadLine());

            //    suma2 += NumEnteros2[i];
            //}


            //for (int i = 0; i > suma1  && i > suma2; i++)
            //{


            //    total = suma1 + suma2;

            //}



            //Console.WriteLine($"La sumatoría de la a vuelta es: {suma1}");
            //Console.WriteLine($"La sumatoría de la 2da vuelta es: {suma2}");
            //Console.WriteLine($"El resultado de la sumatoria de la 1ra vuelta y de la 2da es: {total}");










            //Console.ReadKey();


            // int[] numeros = new int[3];
            // int promedio;
            // int suma = 0;

            // for (int i = 0; i < numeros.Length; ++i)
            // {
            //     Console.WriteLine($"Ingrese tres números {i+1}");
            //     numeros[i] = int.Parse(Console.ReadLine());


            // }

            //for (int i = 0; i < numeros.Length; ++i)
            // {
            //      suma += numeros[i];



            // }
            // Console.WriteLine("El promedio es:");
            // promedio = suma / 3;
            // Console.WriteLine($"{promedio}");
            // Console.ReadKey();







            //Console.WriteLine("¿Cuantos números desea almacenar?");
            //int almacenar = int.Parse(Console.ReadLine());

            //int[] Numeros = new int[almacenar];
            //int sumar = 0;

            //for (int i = 0; i < Numeros.Length; i++) {
            //Console.WriteLine($"Ingrese los números {i+1}");
            //Numeros[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i> Numeros.Length; i++)
            //{
            //     sumar += Numeros[i];





            //}

            //if (sumar >= 100)
            //{
            //    Console.WriteLine("La sumatoria es mayor o igual a 100");
            //}

            //Console.ReadKey();




        }

    }
}
