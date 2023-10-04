// // Координаты
// Console.WriteLine("Введите координату X;");
// int xCoordination = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y;");
// int yCoordination = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"X{xCoordination}, Y{yCoordination}");
// int Coordinator (int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         Console.WriteLine("Верхняя-Правая часть");
//         return 1;
//     }
//     else if (x > 0 && y < 0)
//     {
//         Console.WriteLine("Нижняя-Правая часть");
//         return 2;
//     }
//     else if (x < 0 && y < 0)
//     {
//         Console.WriteLine("Нижняя-Левая часть");
//         return 3;
//     }
//     else 
//     {
//         Console.WriteLine("Верхняя-Левая часть");
//         return 4;
//     }
// }
// if (xCoordination == 0 || yCoordination == 0)
// {
//     Console.WriteLine("Вы ввели неверное число");
// }
// else
// {
//     Coordinator(xCoordination, yCoordination);
// }


// // Координаты наоборот
// Console.WriteLine("Введите номер четверти: ");
// int coordination = Convert.ToInt32(Console.ReadLine());
// int Coordinator (int num)
// {
//     if (num == 1)
//     {
//         Console.WriteLine("[X > 0; Y > 0]");
//         return 1;
//     }
//     else if (num == 2)
//     {
//         Console.WriteLine("[X < 0; Y > 0]");
//         return 2;
//     }
//     else if (num == 3)
//     {
//         Console.WriteLine("[X < 0; Y < 0]");
//         return 3;
//     }
//     else
//     {
//         Console.WriteLine("[X > 0; Y < 0]");
//         return 4;
//     }
// }
// if (coordination < 1 || coordination > 4)
// {
//     Console.WriteLine("Вы ввели неверное число");
// }
// else
// {
//     Coordinator(coordination);
// }


// // Поиск расстояния 
// Console.WriteLine("Введите координату точки 1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату точки 2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"X1: {x1}, X2: {x2}");
// void Distance (int point1, int point2)
// {
//     int result = 0;
//     if (point1 > point2)
//     {
//         result = point1 - point2;
//         Console.WriteLine($"Расстояние от X1 до X1 равняется {result}"); 
//     }
//     else if (point1 == point2)
//     {
//         result = 0;
//         Console.WriteLine($"Расстояние от X1 до X1 равняется {result}"); 
//     }
//     else 
//     {
//         result = point2 - point1;
//         Console.WriteLine($"Расстояние от X1 до X1 равняется {result}");
//     }
// }
// Distance (x1, x2);


// // Таблица квадратов
// void SquaterTable(int quat)
// {
//     for (int i = 1; i <= quat; i++)
//     {
//         Console.Write($"{i*i} ");
//     }
// }
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 0)
// {
//     num = num*(-1);
// }
// SquaterTable(num);


// Домашнее задание

int Palidrom = 62326;
int x1 = Palidrom % 10;
int x2 = Palidrom / 10000;
Console.WriteLine(x1);
Console.WriteLine(x2);
Console.WriteLine((Palidrom/1000)-x1*10);
Console.WriteLine((Palidrom%100-x2)/10);