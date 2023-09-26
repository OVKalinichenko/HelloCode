// ====Виды методов

// ====Вид 1

// void Method1()
// {
//     System.Console.WriteLine("Автор программы ...");
// }
// Вызов метода
// Method1();

// ====Вид 2

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Вызов метода
// Method2(msg: "Текст сообщения");

// void Method2_1(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }
// }
// Вызов метода
// Method2_1(msg: "Messege", count: 4);
// или
// Method2_1(count: 5, msg: "New messege");

// ==== Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// Вызов метода
// int year = Method3();
// System.Console.WriteLine(year);

// ==== Вид 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// // Вызов метода
// string res = Method4(10, "Ax");
// System.Console.WriteLine(res);

// ===== Примеры цикла for

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;  
//     }
//     return result;
// }

// string res = Method4(10, "Ax");
// System.Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for ( int j = 2; j<= 10; j++)
//     {
//         System.Console.WriteLine($"{i} * {j } = {i*j}");
//     } 
//     System.Console.WriteLine();
// }

// ==== Работа с текстом
// Дан текст. В тесте нужно все пробелы заменить черточками,
// маленькие буквы "к" заминить большими "К",
// а большие "С" заменить маленькими "с".

// string text = "- Я думал, - Сказал князь, улыбаясь, - что, "
//             + "ежели бы вас поСлали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие пруССкого короля."
//             + "Вы так краСноречивы. Вы дадите мне чай?";

// string s = "qwerty"
//             012345
// s[3] // r

// string Replace(string text, char oldValue, char newValuer)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for ( int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValuer}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '|');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();

// newText = Replace(newText, 'С', 'с');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();

// ==== Алгороитм сортировки методом выбора (min/max)

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     } 
//     System.Console.WriteLine();
// }

// ==== min
// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }

//         int temparory = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temparory;
//     }
// }


// ==== max
// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int maxPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] > array[maxPosition]) maxPosition = j;
//         }

//         int temparory = array[i];
//         array[i] = array[maxPosition];
//         array[maxPosition] = temparory;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);