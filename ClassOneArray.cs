using System;


public class OneDimensionalArray
{
    private int[] array;

    public OneDimensionalArray(int length, bool userFilled = false)
    {
        array = new int[length];
        if (userFilled)
        {
            FillArrayByUser();
        }
        else
        {
            FillArrayRandom();
        }
    }
    public void FillArrayByUser()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public void FillArrayRandom()
    {
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next();
        }
    }

    public void PrintArray()
    {
        Console.WriteLine("Массив:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    public double Average()
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;
    }

    public void Remove100()
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i]) <= 100)
            {
                count++;
            }
        }

        int[] newArray = new int[count];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i]) <= 100)
            {
                newArray[index] = array[i];
                index++;
            }
        }

        array = newArray;
    }

    public void RemoveDuplicates()
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < i; j++)
            {
                if (array[j] == array[i])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                count++;
            }
        }

        int[] newArray = new int[count];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < i; j++)
            {
                if (array[j] == array[i])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                newArray[index] = array[i];
                index++;
            }
        }

        array = newArray;
    }
}

class Program {
  static void Main() {
   
    Console.WriteLine("Введите длину массива:");
    int length = Convert.ToInt32(Console.ReadLine()) ;
    bool userFilled = false;
    
    OneDimensionalArray arr = new OneDimensionalArray(length, userFilled);
    
    arr.RemoveDuplicates();
    Console.WriteLine($" Среднее арифметическое: {arr.Average()}");
  }
}
