using System;

class JaggedArraySolver
{
    private int[][] jaggedArray;
    private bool userFilled;

    public JaggedArraySolver(int rows, int cols, bool userFilled = false)
    {
        jaggedArray = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            jaggedArray[i] = new int[cols];
        }

        this.userFilled = userFilled;
        if (!userFilled)
        {
            FillArrayRandom();
        }
        else
        {
            FillByUser();
        }
    }

    public void FillArrayRandom()
    {
        Random random = new Random();
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                jaggedArray[i][j] = random.Next(100);
            }
        }
    }

    public void FillByUser()
    {
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.WriteLine($"Введите {jaggedArray[i].Length} элемента для строки {i + 1}:");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                jaggedArray[i][j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void PrintArray()
    {
        Console.WriteLine("Зубчатый массив:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    public double Average()
    {
        int sum = 0;
        int count = 0;
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                sum += jaggedArray[i][j];
                count++;
            }
        }

        return (double)sum / count;
    }

    public double[] Average2()
    {
        double[] averages = new double[jaggedArray.Length];
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            int sum = 0;
            int count = 0;
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                sum += jaggedArray[i][j];
                count++;
            }

            averages[i] = (double)sum / count;
        }

        return averages;
    }

    public void MultiplyEvenElements()
    {
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                if (jaggedArray[i][j] % 2 == 0)
                {
                    jaggedArray[i][j] = i * j;
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        JaggedArraySolver random = new JaggedArraySolver(3, 4);
        random.PrintArray();
        Console.WriteLine("Среднее арифметическое: " + random.Average());
        Console.WriteLine();

        
        JaggedArraySolver user = new JaggedArraySolver(2, 3, true);
        user.PrintArray();
        double[] averages = user.Average2();
        Console.WriteLine("Среднее арифметическое вложенных массивов:");
        foreach (double average in averages)
        {
            Console.WriteLine(average);
        }
        Console.WriteLine();

        
        user.MultiplyEvenElements();
        user.PrintArray();
    }
}

