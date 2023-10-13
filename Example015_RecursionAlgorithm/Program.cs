// ====== Показать все слова , состоящие из Т букв, которые можно построить из букв 
// предостваленного алфавита (к примеру "а и с в")

// int n = 1;
// void FindWord(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         System.Console.WriteLine(($"{n++} {new String(word)}")); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWord(alphabet, word, length + 1);
//     }
// }
// FindWord("аисв", new char[3]);


// ===== Как посмотреть содержание папки

string path = "/Users/george/Desktop/Hello_world_C#";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();
// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }

// void CatalogInfo(string path, string index = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);

//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         System.Console.WriteLine($"{index}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, index + " ");
//     }
//     FileInfo [] files = catalog.GetFiles();
//     for (int i = 0; i < files.Length; i++)
//     {
//         System.Console.WriteLine($"{index}{files[i].Name}");
//     }
// }
// CatalogInfo(path);

// ====== Игра в пирамидки

// void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
// {
//     if (count>1) Towers(with, some, on, count - 1);
//     System.Console.WriteLine($"{with} >> {on}");
//     if (count>1) Towers(some, on, with, count - 1);
// }

// Towers();

// ===== Решение  матиматических равенств. Бинарное дерево и его обход.

// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// //                 0    1   2    3     4    5    6     7    8   9   10    11

// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         if(left < tree.Length && !string.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         System.Console.WriteLine(tree[pos]);
//         if(right < tree.Length && !string.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }
// InOrderTraversal();