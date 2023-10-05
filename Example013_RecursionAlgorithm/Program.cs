// ========
// string[,] table = new string[2,5];

// String.Empty - инициализация для string (строк)
// table[0,0]   table[0,1]  .... table[0,4]  
// table[1,0]   table[1,1]  .... table[1,4]  

// table[1, 2] = "word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums++)
//     {
//         System.Console.WriteLine($"{table[rows, colums]} - ");   
//     }
// }


// ========
// void PrintArray(int[,] image)
// {
// for (int rows = 0; rows < image.GetLength(0); rows++)
// {
//     for (int colums = 0; colums < image.GetLength(1); colums++)
//     {
//         System.Console.Write($"{image[rows, colums]}  ");
//     }
//     System.Console.WriteLine();
// }
// }

// void FillArray(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//        for (int j = 0; j < image.GetLength(1); j++)
//        {
//             image[i,j] = new Random().Next(1,10);
//        } 
//     }
// }

// int [,] imageix = new int[3, 4];
// PrintArray(imageix);
// System.Console.WriteLine();
// FillArray(imageix);
// PrintArray(imageix);


// ======== Hаскрасить область

// int[,] pic = new int[,]
// {
//     {0,0,0,0,0,0,0,1,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,1,0,1,0,0,0,0,0,0},
//     {0,0,0,0,0,1,0,0,0,1,0,0,0,0,0},
//     {0,0,0,0,1,0,0,0,0,0,1,0,0,0,0},
//     {0,0,0,1,0,0,0,0,0,0,0,1,0,0,0},
//     {0,0,1,0,0,0,0,0,0,0,0,0,1,0,0},
//     {0,1,0,0,0,0,0,0,0,0,0,0,0,1,0},
//     {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
//     {0,1,0,0,0,0,0,0,0,0,0,0,0,1,0},
//     {0,0,1,0,0,0,0,0,0,0,0,0,1,0,0},
//     {0,0,0,1,1,1,1,1,1,1,1,1,0,0,0},
// };


// void PrintImage(int[,] image)
// {
//     for (int rows = 0; rows < image.GetLength(0); rows++)
//     {
//         for (int colums = 0; colums < image.GetLength(1); colums++)
//         {
//            // System.Console.Write($"{image[rows, colums]}  ");
//             if (image[rows, colums] == 0) Console.Write(" ");
//             else Console.Write("+");
//         }
//         System.Console.WriteLine();
//     }
// }
// void FillImage(int row, int col)
// {
//     if(pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col +1);
//     }
// }


// PrintImage(pic);
// FillImage(8,8);
// PrintImage(pic);


// ========= Вычисление факториала (5!=1*2*3*4*5)

// double Factorial(int n)
// {
//     // 1!=1
//     // 0!=1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     System.Console.WriteLine($" {i} ->  {Factorial(i)}");
// }

// ========= Числа Фибоначчи (1 1 2 3 5 8 13 21 ...)
// f(n) = f(n-1) + f(n-2)

// double Fibonacci(int n)
// {
//     if(n == 1 || n ==2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 1; i < 50; i++)
// {
//     System.Console.WriteLine($"f({i}) -> {Fibonacci(i)}");
// }


