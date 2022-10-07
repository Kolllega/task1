Console.WriteLine("Введите число :");
string num = Console.ReadLine();
int number = int.Parse(num);
Console.WriteLine("Все четные числа от 1 до введенного числа");
if(number % 2 == 0)
    
    for (int i = 2; i <= number; i++)
    {
        Console.WriteLine($"{i}");i++;
    }
else   
    
    for (int i = 2; i < number; i++)
    {
       Console.WriteLine($":{i}");i++;
    }
        
    