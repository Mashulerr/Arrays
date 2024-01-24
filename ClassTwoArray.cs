using System;

class TwoDimensionalArray
{
    private int[,] array;

    public TwoDimensionalArray(int rows, int columns, bool userFilled = false)
    {
        array = new int[rows, columns];
        if (userFilled)
        {
            FillByUser();
        }
        else
        {
            FillRandom();
        }
    }

    public void FillByUser()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"Введите числа с индексами [{i},{j}]: ");
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    public void FillRandom()
    {
        Random rnd = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rnd.Next(1, 100);
            }
        }
    }

    public void PrintArray()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public void RowsReversed()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = array.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            else
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }

    public double Average()
    {
        double sum = 0;
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
                count++;
            }
        }
        return sum / count;
    }

   
}

class Program
{
    static void Main(string[] args)
    {
        
        TwoDimensionalArray randomArray = new TwoDimensionalArray(3, 4);
        TwoDimensionalArray userArray = new TwoDimensionalArray(2, 2, true);

        
        Console.WriteLine("Рандомный массив:");
        randomArray.PrintArray();
        Console.WriteLine();

        Console.WriteLine("Массив пользователя:");
        userArray.PrintArray();
        Console.WriteLine();

        
        Console.WriteLine("Массив с обратными элементами четных строк:");
        userArray.RowsReversed();
        Console.WriteLine();

        
        double randomAverage = randomArray.Average();
        

        Console.WriteLine("Среднее арифметическое: " + randomArray );
        

        
    }
}

