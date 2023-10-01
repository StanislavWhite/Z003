// // *Задача 1* программа, которая выводит квадрат числа 
//Console.WriteLine("Укажите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int res = num * num;
//Console.WriteLine($"{res} квадрат числа {num} ");

// // *Задача 2* программа, которая проверяет, является ли число 1 квадратом числа 2
// Console.WriteLine("Введите число 1: ");
// int num_one = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// int num_two = Convert.ToInt32(Console.ReadLine());
// int res = num_two * num_two;
// if (res == num_one)
// {
//     Console.WriteLine($"число {num_one} является квадратом числа {num_two} ");
// }
// else 
// {
//     Console.WriteLine($"число {num_one} не является квадратом числа {num_two} ");
// }

// // *Задача 3* программа, которая показывает все целые числа от 0 до N
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i<= num; i++)
// {
//     Console.Write($"{i} ");
// }

// // *Задача 4* программа, которая принимает трёхзначное число и показывает его последнее число
// Console.WriteLine("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 0)
// {
//     num = num * (-1);
// }
// if (num > 99 && num < 1000)
// {
//     int res = num % 10;
//     Console.Write($"{res}");
// }
// else
// {
//     Console.WriteLine("Введено неверное число");
// } 

// // *Задача 5* программа, которая из числа определяет день недели
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 0 && num < 8)
// {
//     if (num == 1)
//     {
//         Console.WriteLine("Сегодня: Понедельник");
//     }
//     if (num == 2)
//     {
//         Console.WriteLine("Сегодня: Вторник");
//     }
//     if (num == 3)
//     {
//         Console.WriteLine("Сегодня: Среда");
//     }
//     if (num == 4)
//     {
//         Console.WriteLine("Сегодня: Четверг");
//     }
//     if (num == 5)
//     {
//         Console.WriteLine("Сегодня: Пятница");
//     }
//     if (num == 6)
//     {
//         Console.WriteLine("Сегодня: Суббота");
//     }
//     if (num == 7)
//     {
//         Console.WriteLine("Сегодня: Воскресенье");
//     }
// }
// else 
// {
//     Console.WriteLine("Введено неверное число");
// }