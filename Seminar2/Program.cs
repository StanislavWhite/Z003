// void HelloFunc (string name)
// {
//     Console.WriteLine($"Привет, {name} ");
// }
// Console.WriteLine("Привет, как тебя зовут ?");
// string username = Console.ReadLine();
// HelloFunc(username);

int QuaterFunc (int num)
{
    int res = num * num;
    return res;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int quat = QuaterFunc(number);
Console.WriteLine($"{quat} квадрат числа {number}");


















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