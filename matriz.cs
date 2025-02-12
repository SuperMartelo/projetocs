/*int[] inventory = [ 200, 450, 700, 175, 250 ];
int sum = 0;
int bin = 0;
foreach (var items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine(items);
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory");
*/

string [] Orders = [ "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" ];

foreach (var item in Orders)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine(item);
    }
}
Console.WriteLine(Orders[2]);