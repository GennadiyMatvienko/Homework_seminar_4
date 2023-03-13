// № 25 Напишите цикл, который принимает на вход
//два числа(A и B) и возводит число A в натуральную степень B.

/*

void DegreeOfNumber(double arg1, double arg2)                // Первыый аргумент должен присваивать значения числа которое хотим возвести в степень
{                                                    // Второе аргумент должен присваивать значение степени
    double ans = Math.Pow(arg1, arg2);

    Console.WriteLine("Число : ");
    Console.Write(arg1);
    Console.Write(" В степени : ");
    Console.Write(arg2);
    Console.Write(" = ");
    Console.Write(ans);
}

Console.WriteLine("Введите число которое хотите возвести в степень");
double A = double.Parse(Console.ReadLine());

Console.WriteLine("Введите степень числа");
double B = double.Parse(Console.ReadLine());

DegreeOfNumber(A, B);
Console.ReadLine();

*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void SumOfDigits(int arg)
{
    int count = 0; // переменная для поиска последней цифры числа 
    int temp = 0; // контейнер для суммы цмфр числа
    int i = 1;
    while (arg > 0)
    {
        count = arg % 10;   // Поиск последней цифры в числе с шагом один
        arg = arg / 10; // уменьшение самого числа на десятую часть до 0,9

        temp = temp + count; // Посчет всех цифр числа начиная с права на лево

        Console.WriteLine(" ");
        Console.Write("Число с конца  ");
        Console.Write(i);
        Console.Write(" : ");
        Console.Write(count);
        i++; // счетчик номера числа с конца
    }
    Console.WriteLine(" ");
    Console.Write("Сумма всех цифр в числе = ");
    Console.Write(temp);

}


Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

SumOfDigits(number);
Console.ReadLine();