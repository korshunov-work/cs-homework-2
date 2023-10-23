Console.Clear();
int GetSecondDigit(int number)
{
    int secondDigit = ((number % 100) / 10);
        return secondDigit;
}

bool check = false;
int userNumber = 0;
while (check == false)
{
    Console.Write("Введите трехзначное число: ");
    string userInput = Console.ReadLine();
    check = int.TryParse(userInput, out userNumber);
    if ((userNumber / 1000 == 0) && (userNumber / 100 != 0))
    {
        check = true;
    }
    else
    {
        check = false;
    }
}

Console.WriteLine($"Вторая цифра числа {userNumber} - {GetSecondDigit(Math.Abs(userNumber))}");