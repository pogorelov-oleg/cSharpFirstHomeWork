Console.Write ("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
Console.Write ("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);
int userNumber2 = int.Parse(userInput2);
if (userNumber1 > userNumber2)
{
    Console.WriteLine($"Число {userNumber1} больше {userNumber2}");
}
else 
{
    Console.WriteLine($"Число {userNumber1} меньше {userNumber2}");
}

