// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GengerateArray(int size, int leftRange, int rightRange)
{
    int[] TempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        TempArray[i] = rand.Next(leftRange, rightRange); 
    }
    return TempArray;
}


void PrintArray(int[] collection)
{
    System.Console.Write("["+ string.Join(", ",collection)+"] " + "=> ");
} 

int  IndexOf(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int scor = 0;   // подсчет попадающих элементов

    while (index<count)
    {
        if (collection[index] % 2 == 0)
        {
            scor = scor + 1;
        }
        index++;
    }
    return scor;
}

int size = ReadInt("введите размер массива");
int[] array = GengerateArray(size, 100, 1000);


PrintArray(array);

int pos = IndexOf(array);
System.Console.Write(pos);