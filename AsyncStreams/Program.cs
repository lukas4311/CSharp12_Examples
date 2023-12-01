// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// Simulation of async stream
async IAsyncEnumerable<int> GenerateNumbersAsync()
{
    for (int i = 0; i < 10; i++)
    {
        await Task.Delay(100);
        yield return i;
    }
}

await foreach (var number in GenerateNumbersAsync())
{
    Console.WriteLine(number);
}


// Example of parallel for each, so each element is processed in parallel
await Parallel.ForEachAsync(GenerateNumbersAsync(), async (number, _) =>
{
    await ProcessNumberAsync(number);
});
Task ProcessNumberAsync(int number) => throw new NotImplementedException();
