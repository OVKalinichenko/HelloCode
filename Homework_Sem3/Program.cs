// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.


// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное
//                      False


// bool IsPalindrome(int number)
//     {
//       int un = number % 10;
//       int tth = number / 10000;
//       int th = number/ 1000 - tth * 10;
//       int ten = ((number - un ) / 10) % 10;
      
//       if( number >= 10000 && number < 100000)
//       {
//         if(un == tth && th == ten) return true;
//         else return false;
//       }
//       else
//       {
//         System.Console.WriteLine("Число не пятизначное");
//         return false;
//       }
//       }

// Console.Write("Enter five-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(IsPalindrome(num));


// Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход 
// координаты двух точек pointA и pointB в виде массива целых чисел, и возвращает расстояние 
// между ними в 3D пространстве.


// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double DistanceBetweenPoints(double[] pointA, double[] pointB)
//     {
//     return Math.Round(Math.Sqrt(Math.Pow(pointB[0] - pointA[0], 2) + Math.Pow(pointB[1] - pointA[1], 2) + Math.Pow(pointB[2] - pointA[2], 2)), 2, MidpointRounding.AwayFromZero);
//     }


// double DistanceBetweenPoints( double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
// }

// System.Console.Write(" Enter coordinate x of A: ");
// double xa = Convert.ToInt32(Console.ReadLine());
// System.Console.Write(" Enter coordinate y of A: ");
// double ya = Convert.ToInt32(Console.ReadLine());
// System.Console.Write(" Enter coordinate z of A: ");
// double za = Convert.ToInt32(Console.ReadLine());
// System.Console.Write(" Enter coordinate x of B: ");
// double xb = Convert.ToInt32(Console.ReadLine());
// System.Console.Write(" Enter coordinate y of B: ");
// double yb = Convert.ToInt32(Console.ReadLine());
// System.Console.Write(" Enter coordinate z of B: ");
// double zb = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Расстояние между точками А ({xa}, {ya}, {za}) и В ({xb}, {yb}, {zb}) -> {Math.Round(DistanceBetweenPoints(xa, ya, za, xb, yb, zb), 2, MidpointRounding.AwayFromZero)}");

// Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.


// N = 3 
// /*
// 1
// 8
// 27
// */

// N = 5
// /*
// 1
// 8
// 27
// 64
// 125
// */

// void QuadTable(int N)
// {
//     int current = 1;
//     while(current <= N)
//         {
//             System.Console.WriteLine(current * current * current);
//             current++;
//         }
// }
// System.Console.Write("Input N:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.Write($" -> ");
// QuadTable(n);