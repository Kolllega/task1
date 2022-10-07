Console.WriteLine("Введите число 1 :");
string number1 = Console.ReadLine();
Console.WriteLine("Введите число 2 :");
string number2 = Console.ReadLine();

int numberOne = int.Parse(number1);
int numberTwo = int.Parse(number2);

if (numberOne > numberTwo)

        Console.WriteLine($"max = {numberOne}");

  else

        Console.WriteLine($"max = {numberTwo}");
