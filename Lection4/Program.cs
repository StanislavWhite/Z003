// Лекция 4

                               ///Индекс от 0 до 4
// string [,] matrix = new string [2, 5];
// matrix[1,2] = "Привет !";
// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         Console.WriteLine($"-{matrix[i, j]}");
//     }
// }

// int[,] matrix = new int [3, 4];

// void PrintArray(int[,]matr)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i,j]} ");
//         }      
//     Console.WriteLine();
//     }
// }
// void FillArray(int[,]matr)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1,10);
//         }      
//     }
// }

// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// int [,] matrixImage = new int [,]
// {
//     {0,0,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,1,1,1,1,0,0,0,0},
//     {0,0,1,1,1,0,0,1,1,1,0,0},
//     {0,0,1,0,0,0,0,0,0,1,0,0},
//     {0,0,1,0,0,0,0,0,0,1,0,0},
//     {0,0,1,1,1,0,0,1,1,1,0,0},
//     {0,0,0,0,1,1,1,1,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,0,0}   
// };

// void PrintArray(int[,]matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             // Console.Write($"{matr[i,j]} ");
//             if (matr[i,j] == 0) Console.Write(" ");
//             else Console.Write(" + ");
//         }      
//     Console.WriteLine();
//     }
// }
// void FillArray(int row, int col)
// {
//     if (matrixImage[row, col] == 0)
//     {
//         matrixImage[row, col] = 1;
//         FillArray(row-1, col);
//         FillArray(row, col-1);
//         FillArray(row+1, col);
//         FillArray(row, col+1);
//     }
// }
// PrintArray(matrixImage);
// FillArray(5,5);
// PrintArray(matrixImage);

// int FactorialCalculator(int num)
// {
//     if (num == 1) return 1;
//     else return num * FactorialCalculator(num-1);
// }
// Console.WriteLine(FactorialCalculator(9));

// int Fibonacci (int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }
// Console.WriteLine(Fibonacci(11));