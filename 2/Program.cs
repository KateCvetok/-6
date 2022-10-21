// Показать числа Фибоначчи
int Fibonacci (int n)
{
    if (n==1 || n==2) return 1;
    else return Fibonacci (n-1) + Fibonacci(n-2);
}
Console.WriteLine ("Значение какого элемента ряда Фибоначчи вы хотите узнать?" );
int n = int.Parse (Console.ReadLine()?? "0");
Console.WriteLine();

for (int i = 1; i<n; i++)
{
    Console.WriteLine(Fibonacci(i));
}

