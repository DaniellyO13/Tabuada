Console.WriteLine("--- Tábuada ---");

int n = 1;
int numeroDigitado;

Console.Write("Digite um Número: ");
numeroDigitado = Convert.ToInt32(Console.ReadLine());



while (n <= 10)
{
    Console.WriteLine($"{numeroDigitado} X {n} = {numeroDigitado * n}");
    n = n + 1;
}