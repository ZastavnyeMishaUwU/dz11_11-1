namespace dz11_11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 14, 19, 21, 7, 18 };
            int target = 7;

            int index = Array.IndexOf(array, target);

            if (index != -1)
            {
                Console.WriteLine($"Індекс числа {target}: {index}");
            }
            else
            {
                Console.WriteLine($"Число {target} не знайдено .");
            }
        }
    }
}
