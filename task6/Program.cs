Console.Write ("Введите первое число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
if (userNumber % 2 == 0)
{
    Console.Write($"Число {userNumber} является четным");
}
else
{
    Console.Write($"Число {userNumber} является нечетным");
}