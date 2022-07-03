/*Задача.Написать программу, которая из имеющегося массива трок формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
 При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
 */

string[] FillingArray(string message)
{
    Console.WriteLine(message);
    string[] array = Console.ReadLine().Split(",");
    return array;
}

void PrintArray(string[] num)
{
    Console.Write("[");
    for (int i = 0; i < num.Length; i++)
    {
        if (i < num.Length - 1)
            Console.Write(num[i] + ", ");
        else
            Console.Write(num[i] + "]");
    }
}


void ArrayFormation(string[] array)
{
    int length = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            length += 1;
        }

    }
    string[] array2 = new string[length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count += 1;
        }
    }
    PrintArray(array2);
}

string[] array = FillingArray("Введите элементы массива через запятую:");
Console.WriteLine("Массив ,сформированный из строк введенного массива, длина которых меньше либо равна 3 символа, имеет следующий вид:");
PrintArray(array);
Console.Write("=>");
ArrayFormation(array);

