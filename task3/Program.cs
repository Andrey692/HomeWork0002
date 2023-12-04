// Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)

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
    System.Console.WriteLine("["+ string.Join(", ",collection)+"] ");
} 

int size = ReadInt("введите размер массива");
int[] array = GengerateArray(size, 100, 1000);

PrintArray(array);
int[] newArray = new int[size];

for (int i = 0; i < size; i++)
{
        newArray[i] = array[size - 1 - i];
}

System.Console.WriteLine("["+ string.Join(", ",newArray)+"]");

