// Array in struct type
// Fixed size
// Cannot use LINQ for them (not implement IEnumerable)

var arr = new MyInlineArray();

for (int i = 0; i < 10; i++)
{
    arr[i] = new String(i.ToString() + "aa");
}

foreach (var item in arr)
{
    Console.WriteLine(item);
}

[System.Runtime.CompilerServices.InlineArray(10)]
public struct MyInlineArray
{
    private object _element;
}