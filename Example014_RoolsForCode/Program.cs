// using System.Linq;
// var a = 12;
// // System.Console.WriteLine(a.GetType().Name);
// var date = new int[] { 1, 2, 3, 4, }
//         .Where(e => e > 0)
//         .Select(e => new { q = e, w = e +1 });

// System.Console.WriteLine(date.GetType().Name);

// ====== Парсинг


using System.Linq;

string text = "(1,2) (2,4) (5,6) (7,8)"
                                .Replace("(", "")
                                .Replace(")", "")
                                ;
System.Console.WriteLine(text);

var data = text.Split(" ")
                                .Select(item => item.Split(","))
                                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                                .Where(e => e.x % 2 == 0)
                                .Select(point => (point.x *10, point.y * 10))
                                .ToArray();

for (int i = 0; i < data.Length; i++)
{
        System.Console.WriteLine(data[i]);
        System.Console.WriteLine();
}
