using System.Linq;
{
    var d1 = new DateTime(2010, 10, 10);
    var d2 = new DateTime(2017, 11, 11);
    var answer = (d2 - d1).TotalSeconds;
    Console.WriteLine($"T1: {answer}");
}

{
    var l1 = Enumerable.Range(0, 100000).Where(x => x % 3 == 1).ToList();
    var answer = l1.Sum();
    Console.WriteLine($"T2: {answer}");
}

{
    var a1 = new[] { 0, 5, 7, 1, 4, 9, 8, 9, 11, 34, 13 };
    var answer = string.Join(", ", a1.OrderByDescending(x => x));
    Console.WriteLine($"T3: {answer}");
}

{
    var shops = new[] {
        new { Shop = "Shop A", Products = new [] { "Book", "Pencil", "Rubber" } },
        new { Shop = "Shop B", Products = new [] { "Shirt", "Shoe", "Skirt", "Sock" } },
        new { Shop = "Shop C", Products = new [] { "Apple", "Banana", "Orange", "Grape" } }
    };
    var answer = string.Join(", ", shops.SelectMany(x => x.Products).OrderBy(x => x));
    Console.WriteLine($"T4: {answer}");
}

{
    var d1 = Enumerable.Range(1, 100000).Where(x => x % 13 == 0);
    var answer = string.Join(", ", d1.Skip(1000).Take(20));
    Console.WriteLine($"T5: {answer}");
}