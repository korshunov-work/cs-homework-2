Console.Clear();
bool check = false;
string userString = "";
int userNumber = 0;

while (check == false)
{
    Console.WriteLine("Введите число: ");
    userString = Console.ReadLine();
    check = int.TryParse(userString, out userNumber);
    userNumber = Math.Abs(userNumber);

}

if (userString.Length > 2)
{
    Console.WriteLine($"Третья цифра числа {userNumber} - {userString[2]}.");
}
else
{
    Console.WriteLine($"У числа {userNumber} нет третьей цифры.");
}