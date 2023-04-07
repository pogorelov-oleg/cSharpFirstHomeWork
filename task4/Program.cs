Console.Write ("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
Console.Write ("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
Console.Write ("Введите третье число: ");
string userInput3 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);
int userNumber2 = int.Parse(userInput2);
int userNumber3 = int.Parse(userInput3);
int maxNumber;
if (userNumber2 > userNumber1)
{
    maxNumber = userNumber2;
}
else 
{
    maxNumber = userNumber1;
}
if (userNumber3 > maxNumber)
{
    Console.Write ($"Максимальное число {userNumber3}");
}
else
{
    Console.Write ($"Максимальное число {maxNumber}");
}