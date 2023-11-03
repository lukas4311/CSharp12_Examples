// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var isSameLength = (int lengthA, int lengthB = -1) => lengthA == lengthB;

Console.WriteLine(isSameLength(10, 10));
Console.WriteLine(isSameLength(10, 2));
Console.WriteLine(isSameLength(10));


// Real usefull usage Minimal API
// app.MapGet("getblogposts", async (MyService service, int? page = 1, int? pageSize = 50) => { }
