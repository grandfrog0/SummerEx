namespace Task_11_04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsWeekend(Weekdays.Monday));
            Console.WriteLine(IsWeekend(Weekdays.Wednesday));
            Console.WriteLine(IsWeekend(Weekdays.Sunday));
            Console.WriteLine(IsWeekend(Weekdays.Saturday));
        }

        public static string IsWeekend(Weekdays day)
        {
            if (day == Weekdays.Sunday || day == Weekdays.Saturday)
                return "Выходной";

            return "Рабочий день";
        }
    }
}
