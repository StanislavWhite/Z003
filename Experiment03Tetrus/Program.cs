

// Самопальный тетрис - Прототип
// Создание доски, создание объектов, поворот объектов, падение объектов
// Разрушение объектов, падение динамита, получение очков


// int[,] board = new int [,]
// {
//     {2,0,0,0,0,0,0,0,0,0,2},
//     {2,0,0,0,0,0,0,0,0,0,2},
//     {2,0,0,0,0,0,0,0,0,0,2},
//     {2,0,0,0,0,0,0,0,0,0,2},
//     {2,0,0,0,0,0,0,0,0,0,2},
//     {2,0,0,0,0,0,0,0,0,0,2},
//     {2,0,0,0,0,0,0,0,0,0,2},
//     {2,2,2,2,2,2,2,2,2,2,2}
// };

// void PrintBoard(int[,]matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i,j]} ");
//         }      
//     Console.WriteLine();
//     }
// }

// Console.Clear();

// void GravityObject(int yCord, int xCord)
// {
//     if (board[yCord, xCord] == 0)
//     {
//         board[yCord,xCord] = 1;
//         GravityObject(yCord + 1, xCord);
//     }
// }

// GravityObject(0, 4);
// Console.WriteLine();
// PrintBoard(board);


int TimeUpdate()
{
    int timeTick = 0;
    for (int i = 10000; i > 0; i--)
    {
        timeTick = timeTick + 1;
    }
    return timeTick;
    TimeUpdate();
}
