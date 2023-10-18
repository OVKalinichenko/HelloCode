// ====== Триугольник паскаля

// Console.Clear();
// //Console.SetCursorPosition(10, 4);
// //Console.WriteLine("+");

// int xa = 40, ya = 10, 
//     xb = 1, yb = 30, 
//     xc = 80, yc = 30; 

// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");

// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");

// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");

// int x = xa, y = yb;

// int count = 0;

// while(count < 10000)
// {
//     int what = new Random().Next(0, 3);//[0:3]
//     if (what == 0)
//     {
//         x = (x + xa) / 2;
//         y = (y + ya) / 2;
//     }
//     if (what == 1)
//     {
//         x = (x + xb) / 2;
//         y = (y + yb) / 2;
//     }
//     if (what == 2)
//     {
//         x = (x + xc) / 2;
//         y = (y + yc) / 2;
//     }
//     Console.SetCursorPosition(x, y);
//     Console.WriteLine("+");
//     count++;//= count + 1
// }

int row = 128;
int[,] triangle = new int[row, row];
const int cellWidth = 3;

void FillTriangle()
{
    for(int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j < row; j++)
        {
            triangle[i, j] = 
                triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        { 
            if (triangle[i,j] != 0)
                Console.Write($"{triangle[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
}

void Magic()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            // if (triangle[i,j]!= 0) Console.Write($"{triangle[i, j],cellWidth}");
            if (triangle[i,j] % 2 != 0) Console.WriteLine("*");
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i - 1);

        Console.WriteLine();
    }
}

FillTriangle();
// PrintTriangle();
Magic();

