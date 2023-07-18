using Humanizer;
using TestHumanizer;

foreach (var item in new List<int> { -2, -1, 0, 1, 2})
{
    var date = DateTime.Now.AddDays(item);
    Console.WriteLine($"date {date} - Humanizer : {date.Humanize()}");
}
Console.WriteLine("-----------------------------------------------------");

foreach (var item in new List<int> { -9012, 12345 })
{
    Console.WriteLine($"number {item} - Humanizer : {item.ToWords()}");
}
Console.WriteLine("-----------------------------------------------------");

foreach (MyEnum item in Enum.GetValues(typeof(MyEnum)))
{
    Console.WriteLine($"enum {item} - Humanizer : {item.Humanize()}");
}
Console.WriteLine("-----------------------------------------------------");

foreach (var item in new List<string> { "cat", "baby"})
{
    Console.WriteLine($"plural {item} - Humanizer : {item.Pluralize()}");
}
Console.WriteLine("-----------------------------------------------------");

foreach (var item in new List<string> { "dogs", "butterflies"})
{
    Console.WriteLine($"singular {item} - Humanizer : {item.Singularize()}");
}
Console.WriteLine("-----------------------------------------------------");

foreach (var item in new List<int> { 1, 3, 10 })
{
    Console.WriteLine($"ordinal {item} - Humanizer : {item.Ordinalize()}");
}
Console.WriteLine("-----------------------------------------------------");
