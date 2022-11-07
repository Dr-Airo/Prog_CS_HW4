// DONE Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.WriteLine("Введите первое число");
// int x=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int y=Convert.ToInt32(Console.ReadLine());

// void Stepenb (int x, int y)
// {
// int result = 1;
// for (int i = 0; i<=y-1; i++) result = result*x;
// Console.WriteLine(result);
// }

// Stepenb (x, y);

//_____________________________________________________________________
// DONE Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (x != 0)
// {
//     sum = sum + x % 10;
//     x = x / 10;
// }
// Console.WriteLine($"Сумм цифр в числе = {sum}");

// _____________________________________________________________________
//  Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

// void FillArray (int [] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index<length) 
//     {
//         collection[index] = new Random().Next(0, 101); 
//         index++;
//     }
// }
// void PrintArray (int [] col)       
// {
//     int count = col.Length;
//     int position = 0;
//     while(position<count)
//     {
//         Console.Write (col[position]+" ");
//         position++;
//     }
// }
// Console.WriteLine("Введите цифру 8");
// int x = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [x];   

// FillArray(array);
// PrintArray(array);

// Задача 26. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.

//Сдвигать запятую вправо, пока x не станет меньше 1. Получим 0,xxxx. Потом, пока

// double x = Convert.ToInt32(Console.ReadLine());
// while (x>1) x=x/10;
// while (x*10<1) x=x/10;

double Razryad (double x) // Функция: счетчик разрядности числа
{
    int count = 0; 
    while (x % 10 > 0)
    {
        x/=10;
        count++;
    }
    return count;
}
Console.WriteLine("Введите целое число");
double n = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine(Razryad(n));


// Задача 30: - HARD необязательная Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.. 
//Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(0, 2);
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(col[position] + " ");
//         position++;
//     }
// }
// int CountZero(int[] x)
// {
//     for (int i = 0; i <= x.Length; i++)
//     {
//         int count = 0;
//         if (x[i] == 0) count++; 
//         return count;
//     }
// }

// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);
// int count = CountZero(array);
// if (count > 4) Console.WriteLine("False");
// if (count < 4) Console.WriteLine("True");