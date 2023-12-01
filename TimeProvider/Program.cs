// See https://aka.ms/new-console-template for more information
using TimeProviderNspc;

Console.WriteLine("Hello, World!");

var discountService = new DiscountService(TimeProvider.System);
discountService.CalculateDiscount();
