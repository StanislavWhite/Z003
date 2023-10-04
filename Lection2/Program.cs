// void Method1 (string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// //Method1(count: 2, msg: "Привет!");

// int Method2()
// {
//     return DateTime.Now.Year;
// }

// int year = Method2();
// //Console.WriteLine(year);

// // string Method3(int count, string text)
// // {
// //     int i = 0;
// //     string result = String.Empty;
// //     while (i < count)
// //     {
// //         result = result + text;
// //         i++;
// //     }
// //     return result;
// // }
// string Method3(int count, string text)
// {
//     string result = String.Empty;
//     for ( int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method3(10, "z");
// //Console.WriteLine(res);

// // for (int i = 2; i <= 10; i++)
// // {
// //     for (int j = 2; j <= 10; j++)
// //     {
// //         Console.WriteLine($"{i} x {j} = {i * j}");
// //     }
// //     Console.WriteLine();
// // }

// string history = "Наполню купальню я кровью, да окунусь в неё, дабы поглотить злодеяния ваши.";
// string Replace(string replaceText, char oldChar, char newChar)
// {
//     string result = String.Empty;
//     int length = replaceText.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (replaceText[i] == oldChar)
//         {
//             result = result + $"{newChar}";
//         }
//         else 
//         {
//             result = result + $"{replaceText[i]}";
//         }
//     }
//     return result;
// }
// string newText = Replace(history, ' ', '_');
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);


int[] arr = {7,8,2,4,5,1,6,9,3};

void PrintArray(int[] num)
{
    int length = num.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{num[i]} ");
    }
}
void SortingArray(int[] num)
{
    for (int i = 0; i < num.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < num.Length; j++)
        {
            if (num[j] < num[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = num[i];
        num[i] = num[minPosition];
        num[minPosition] = temporary;        
    }
}
PrintArray (arr);
Console.WriteLine();
SortingArray(arr);
PrintArray(arr);