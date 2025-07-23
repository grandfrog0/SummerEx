namespace Task_11_01
{
    internal class Program
    {
        /*  Создайте список целых чисел, заполните его 5 случайными числами от 1 до 10. Затем:
            - Выведите все элементы списка.
            - Найдите и выведите сумму всех чисел.
            - Удалите все четные числа и выведите измененный список.
        */
        static void Main(string[] args)
        {
            List<int> list = new();
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
                list.Add(rnd.Next(1, 11));

            foreach (int value in list)
                Console.Write(value + " ");
            Console.WriteLine();

            int sum = 0;
            foreach (int value in list)
                sum += value;

            Console.WriteLine($"Сумма: {sum}");

            List<int> list1 = new();
            list1.AddRange(list);

            foreach (int value in list)
            {
                if (value % 2 == 0)
                    list1.Remove(value);
            }

            foreach (int value in list1)
                Console.Write(value + " ");
            Console.WriteLine();
        }
    }
}
