// Для ввода пользователем с клавиатуры

// Console.WriteLine("Введите количество элементов массива");  
// int count = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите текст элемента");
// string [] userCreatedArray = ArrayInput(count);

string[] ArrayInput (int count)
{
    string[] array = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] NewArray (string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count ++;
        }
    }
    string[] array2 = new string [count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            array2[j] = arr[i];
            j++;
        }  
    }
    return array2;
}

void Print (string[] array)
{
    Console.Write($"{String.Join(", ", array)}");
    Console.WriteLine();
}

string[] createdArray = {"1234", "1567", "-2", "computer science"};      
Console.WriteLine("Введеный массив");
Print (createdArray);
// Print (userCreatedArray);       // Если ввод был пользователем с клавиатуры
Console.WriteLine("Новый массив");
// Print(NewArray(userCreatedArray));      // Если ввод был пользователем с клавиатуры
Print(NewArray(createdArray));