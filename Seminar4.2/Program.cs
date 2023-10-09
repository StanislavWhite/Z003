Console.Clear();


// Семинар 4


// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// void NumCounter(int number)
// {
//     int res = 0;
//     while (number!=0)
//     {
//         number /= 10;
//         res++;
//     }
//     Console.WriteLine(res);
// }
// NumCounter(num);


// // Задача 25
// Console.WriteLine("Введите число, которое нужно возвести в степень:");
// int numOne = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число, которое будет степенью:");
// int numTwo = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// if (numTwo < 0)
// {
//     numTwo = numTwo*(-1);
// }
// void Degree(int numberOne, int numberTwo)
// {
//     int res = numberOne;
//     for (int i = 1; i < numberTwo; i++)
//     {
//         res = res * numberOne;
//     }
//     Console.WriteLine($"Выходит число {res}");
// }
// Degree(numOne,numTwo);


// // Задача 27
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 0)
// {
//     num = num*(-1);
// }
// Console.WriteLine();
// void CheckSum(int number)
// {
//     int res = 0;
//     int numLong = number;
//     while (numLong!=0)
//     {
//         numLong /= 10;
//         res++;
//     }
//     int[]masNum = new int [res];
//     for (int i = 0; i < res; i++)
//     {
//         masNum[i] = number%10;
//         number = number/10;
//         // Console.WriteLine($"Число : {number} Массив : {masNum[i]}");
//         // Console.WriteLine();
//     }
//     int total = 0;
//     for (int i = 0; i < res; i++)
//     {
//         total = total + masNum[i];
//     }
//     Console.WriteLine(total);
// }
// CheckSum(num);


// // Задача 29
// void ArrayRandom()
// {
//     int[]array = new int [new Random().Next(1, 11)];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 101);
//         Console.Write($"{array[i]} ");
//     }
// }
// ArrayRandom();