// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array = [1, 2, 3, 4, 5, 6, 7];

int[] array2 = [8, 9, .. array];

for (int i = 0; i < array2.Length; i++)
    Console.WriteLine(array2[i]);
