// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Написать программу, 
// которая из имеющегося массива строк, 
// формирует массив из строк, 
// длина которых меньше либо равна 3 символа.


string[] FillStringArray(int arrayLength) // ввод массива
{
    string[] arrayToFill = new string[arrayLength];
    Console.WriteLine($"Поочередно введите {arrayLength} строковых элементов массива."); 
    Console.WriteLine("После ввода каждого элемента нажмите клавишу ENTER.");
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент: ");
        arrayToFill[i] = Console.ReadLine();
    }
    return arrayToFill;
}

string[] GetLenArray(string[] arrayToExtract) // метод сортировки массива
{
    int resultSize = 0;
    for (int i = 0; i < arrayToExtract.Length; i++)
    {
        if (arrayToExtract[i].Length <= 3)
        {
            resultSize ++;
        }
    }
    string[] resultArray = new string[resultSize];
    int j = 0;
    for (int i = 0; i < arrayToExtract.Length; i++)
    {
        if (arrayToExtract[i].Length <= 3)
        {
            resultArray[j] = arrayToExtract[i];
            j ++;
        }
    }
    return resultArray;
}

void PrintArray(string[] arrayToPrint) // метод вывода массива 
{
    if (arrayToPrint.Length > 0)
    {
        Console.Write("[");
        for (int i = 0; i < arrayToPrint.Length - 1; i++)
        {
            Console.Write($"\"{arrayToPrint[i]}\", ");
        }
        Console.WriteLine($"\"{arrayToPrint[arrayToPrint.Length - 1]}\"]");
    }
    else
    {
        Console.WriteLine("[]");
    }
}

Console.Write("Введите количество строковых элементов в массиве: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());    //длинна массива
string[] array = FillStringArray(lengthArray);            // основной массив
Console.WriteLine();
Console.Write("Заданный массив: ");
Console.WriteLine();
PrintArray(array);
string[] resultArray = GetLenArray(array);                // отсортированный массив
Console.WriteLine();
Console.Write("Массив с элементами менее либо равными 3 символам: ");
Console.WriteLine();
PrintArray(resultArray);


