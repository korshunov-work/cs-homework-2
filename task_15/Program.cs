Console.Clear();
bool check = false;
int dayNumber = 0;
while (check == false)
{
    Console.WriteLine("Введите номер дня недели (1-7): ");
    check = int.TryParse(Console.ReadLine(), out dayNumber);
}

if (dayNumber > 0 && dayNumber < 8)
{
    switch (dayNumber)
    {
        case 1:
        {
            Console.WriteLine("Понедельник - будний день.");
            break;
        }
        case 2:
        {
            Console.WriteLine("Вторник - будний день.");
            break;
        }
        case 3:
        {
            Console.WriteLine("Среда - будний день.");
            break;
        }
        case 4:
        {
            Console.WriteLine("Четверг - будний день.");
            break;
        }
        case 5:
        {
            Console.WriteLine("Пятница - будний день.");
            break;
        }
        case 6:
        {
            Console.WriteLine("Суббота - выходной день.");
            break;
        }
        case 7:
        {
            Console.WriteLine("Воскресенье - выходной день.");
            break;
        }
    }
}
else
{
    Console.WriteLine("Дня с таким номером не существует.");
}