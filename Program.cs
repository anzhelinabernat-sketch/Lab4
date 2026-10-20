class Program
{
    static void Main()
    {
        Console.Write("Введіть рік: ");
        string inputYear = Console.ReadLine();
        if (!int.TryParse(inputYear, out int year) || year < 1)
        {
            Console.WriteLine("Помилка: введіть коректний рік!");
            return;
        }
        bool leapYear = (year % 400 == 0 || year % 4 == 0) && year % 100 != 0;
        int days = leapYear ? 366 : 365;
        int februaryDays = leapYear ? 29 : 28;
        if (leapYear)
        {
            Console.WriteLine("Рік високосний");
            Console.WriteLine($"Кількість днів у році: {days}");
            Console.WriteLine($"Кількість днів у лютому: {februaryDays}");
        }
        else
        {
            Console.WriteLine("Рік не високосний");
            Console.WriteLine($"Кількість днів у році: {days}");
            Console.WriteLine($"Кількість днів у лютому: {februaryDays}");
        }
        string category = year switch
        {
            < 1000 => "друге тисячоліття",
            >= 2000 and < 2100 => " третє тисячоліття",
            _ => "інше тисячоліття"
        };

        Console.WriteLine($"тисячоліття: {category}");
    }
}
