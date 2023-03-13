// № 25 Напишите цикл, который принимает на вход
//два числа(A и B) и возводит число A в натуральную степень B.

/*

void DegreeOfNumber(double arg1, double arg2)                
{                                                    
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
/*
void SumOfDigits(int arg)
{
    int count = 0;  
    int temp = 0; 
    while (arg > 0)
    {
        count = arg % 10;   
        arg = arg / 10; 

        temp = temp + count; 

        Console.WriteLine(" ");
        Console.Write("Число с конца ");
        Console.Write(i);
        Console.Write(" : ");
        Console.Write(count);
        i++; 
    }
    Console.WriteLine(" ");
    Console.Write("Сумма всех цифр в числе = ");
    Console.Write(temp);

}


Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

SumOfDigits(number);
Console.ReadLine();

*/