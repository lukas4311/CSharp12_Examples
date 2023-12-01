// See https://aka.ms/new-console-template for more information
using TimeProviderNspc;

// solving problem with unit testing logic using DateTime.Now 
// unit test are problem cause you dont have control over current time

Console.WriteLine("Hello, World!");

var discountService = new DiscountService(TimeProvider.System);

discountService.CalculateDiscount();

// TimeProvider is abstract class and can be mocked in unit tests