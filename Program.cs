using Lab1;

TNumber a = new(23);
a.Num = 45; // Using the Num property

TNumber b = new();
b.Input();
b.Print();

Console.WriteLine("The number of digits in your number = {0}", b.GetDigitCount());
Console.WriteLine("The sum of digits of your number = {0}", b.GetDigitSum());


