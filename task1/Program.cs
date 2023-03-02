int InputInt(string message)
{
    System.Console.WriteLine(message);
    int value;
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);

    /// или  if (int.TryParse(Console.ReadLine(), out value))
    if (isCorrect)
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}


int[] InputArray(int size)
{
    int[] myArray = new int[size];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = InputInt($"Введите {i + 1} элемент массива ");
    }
    return myArray;
}

int PositiveCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }

    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
        System.Console.Write($"{array[i]} ");

    }
    System.Console.WriteLine();
    
}

int sizeArray = InputInt("Введите длину массива");
int [] array = InputArray(sizeArray);
System.Console.WriteLine("Введенный массив");
PrintArray(array);
System.Console.WriteLine($"Количество положительных чиссел в массиве равно {PositiveCount(array)}");

