// void HelloFunc (string name)
// {
//     Console.WriteLine($"Привет, {name} ");
// }
// Console.WriteLine("Привет, как тебя зовут ?");
// string username = Console.ReadLine();
// HelloFunc(username);

// int QuaterFunc (int num)
// {
//     int res = num * num;
//     return res;
// }
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int quat = QuaterFunc(number);
// Console.WriteLine($"{quat} квадрат числа {number}");

// // *Задача 1* Программа генерирующая случайный отрезок (от 10, до 99) и показывающая наибольшую цифру числа
// void MaxFunc (int num)
// {
//     int NumberOne = num % 10;
//     int NumberTwo = num / 10;
//     if (NumberOne > NumberTwo)
//     {
//         Console.WriteLine($"Наибольшая цифра: {NumberOne} ");
//     }
//     else
//     {
//         Console.WriteLine($"Наибольшая цифра: {NumberTwo} ");
//     }
// }
// int number = new Random().Next(10,100);
// Console.WriteLine($"Случайное число: {number}");
// MaxFunc(number);

// // *Задача 2* Программа, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
// void DecomposeFunc(int num = 0)
// {
//     if (num < 0)
//     {
//         num = num*(-1);
//     }
//     else 
//     {

//     }
//     if (num < 100 && 1000 > num)
//     {
//         Console.WriteLine("Ошибка");
//     }
//     else
//     {
//         int NumberOne = num / 100;
//         int NumberTwo = num % 10;
//         int NewNumber = (NumberOne*10)+NumberTwo;
//         Console.WriteLine($"{NewNumber}");
//     }
// }
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// //int number = new Random().Next(100,1000);
// Console.WriteLine($"Случайное число: {number}");
// DecomposeFunc(number);

// // *Задача 2* Программа принимат число и выясняет, кратно ли оно 7 и 23
// bool CheckFunc(int num = 0)
// {
//     if (num%23==0 && num%7==0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// bool flag = CheckFunc(number);
// if (flag == true)
// {
//     Console.WriteLine("Кратно");
// }
// if (flag == false)
// {
//     Console.WriteLine("Не кратно");
// }

// // *Задача 3* Программа проверяет, является ли число 1 квадратом числа 2
// void QuaterFunc(int NumOne = 0, int NumTwo = 0)
// {
//     if (NumOne == NumTwo*NumTwo || NumTwo == NumOne*NumOne)
//     {
//         Console.WriteLine($"Число является квадратом");
//     }
//     else
//     {
//         Console.WriteLine($"Число не является квадратом");
//     }
// }
// Console.WriteLine("Введите число: ");
// int NumberOne = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int NumberTwo = Convert.ToInt32(Console.ReadLine());
// QuaterFunc(NumberOne, NumberTwo);

// // *Задача 4*
// void Div (int NumOne = 0, int NumTwo = 0)
// {
//     if (NumTwo%NumOne==0)
//     {
//         Console.WriteLine($"Число {NumTwo} кратно {NumOne}");
//     }
//     else
//     {
//         int res = NumTwo%NumOne;
//         Console.WriteLine($"Число {NumTwo} не кратно {NumOne}. Остаток {res}");
//     }
// }
// Console.WriteLine("Введите число: ");
// int NumberOne = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int NumberTwo = Convert.ToInt32(Console.ReadLine());
// Div(NumberOne, NumberTwo);

// // *Задача 15* 
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 0 && num < 8)
// {
//      if (num > 0 && num < 6)
//      {
//         Console.WriteLine("Сегодня: Будний день");
//      }
//      else
//      {
//          Console.WriteLine("Сегодня: Выходной день");
//      }
// }
//  else 
// {
//        Console.WriteLine("Введено неверное число");
// }