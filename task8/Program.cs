Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
if (userNumber < 2)
{
    Console.Write($"От 0 до {userNumber} нет четных чисел");
}
else
{
    for (int i = 2; i <= userNumber; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i} ");
            i++;
        }
    }
}