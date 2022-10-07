Console.WriteLine("Hello, World!");
Console.WriteLine("Введите число 1 :");
string number1 = Console.ReadLine();
Console.WriteLine("Введите число 2 :");
string number2 = Console.ReadLine();
Console.WriteLine("Введите число 3 :");
string number3 = Console.ReadLine();

int numberOne = int.Parse(number1);
int numberTwo = int.Parse(number2);
int numberThree = int.Parse(number3);

if(numberOne > numberTwo)
    if(numberOne > numberThree)
        Console.WriteLine($"max = {numberOne}");  
    else
        Console.WriteLine($"max = {numberThree}");
else
    if(numberTwo > numberThree)
        Console.WriteLine($"max = {numberTwo}");
    else
        Console.WriteLine($"max = {numberThree}");      