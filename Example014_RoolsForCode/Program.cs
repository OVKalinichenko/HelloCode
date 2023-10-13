using System.Linq;
var a = 12;
// System.Console.WriteLine(a.GetType().Name);
var date = new int[] { 1, 2, 3, 4, }
        .Where(e => e > 0)
        .Select(e => new { q = e, w = e +1 });

System.Console.WriteLine(date.GetType().Name);