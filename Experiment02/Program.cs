

// Пузырьковая система сортировки массива


int []num = {6, 1, 7, 3, 4, 5, 9, 2, 8, 0, 11, 13, 10, 12};
void RandomNumberPlaceholder(int []num)
{   
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(1, 11);
    }
}
void PrintNum (int []num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write($"{num[i]} ");
    }
}
void SortingNum (int []num)
{
    for (int i = 0; i < num.Length - 1; i++)
    {
        int sort = 0;
        for (int j = i + 1; j < num.Length; j++)
        {
            // если число 1 больше числа 2, то число 1 = 2, а 2 = 1
            if (num[i] > num[j])
            {
                sort = num[j];
                num[j] = num[i];
                num[i] = sort;
            }
        }
    }
}
RandomNumberPlaceholder(num);
PrintNum(num);
SortingNum(num);
Console.WriteLine("");
PrintNum(num);