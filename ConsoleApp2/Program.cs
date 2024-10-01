class PwrOfTwo
{
    // Доступ до логічного масиву, що містить ступінь 2 від 0 до 15.
    public int this[int index]
    {
        get
        {
            // Обчислити та повернути ступінь числа 2.
            return index switch
            {
                >= 0 and < 16 => Pwr(index),
                _ => -1
            };
        }
    }

    static int Pwr(int p)
    {
        int result = 1;
        for (int i = 0; i < p; i++)
            result *= 2;
        return result;
    }
}

class UsePwrOfTwo
{
    static void Main()
    {
        PwrOfTwo pwr = new();
        Console.Write("Перші 8 ступенів числа 2: ");
        for (int i = 0; i < 8; i++)
        {
            Console.Write(pwr[i] + " ");
        }

        Console.WriteLine();
        Console.Write("А це деякі помилки: ");
        Console.Write(pwr[-1] + " " + pwr[17]);
        Console.WriteLine();
        Console.ReadKey();
    }
}
