/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] sourceArray = new string[4] { "Hello", "2", "world", ":-)" };
string[] resultArray = GetArray(sourceArray);

PrintArray(resultArray);

//GetArray - функция создаёт массив на основе исходного 
string[] GetArray(string[] beginArray)
{
    string[] tempArray = new string[4];

    for (int counter = 0; counter < beginArray.Length; counter++)
    {
        if (beginArray[counter].Length <= 3)
        {
            tempArray[counter] = beginArray[counter];
        }
    }

    return tempArray;
}

//PrintArray - функция вывода на монитор одномерного массива в виде строки
void PrintArray(string[] userArray)
{
    string temp = "[";
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i] != null)
            temp += "\"" + userArray[i] + "\",";
    }

    if (temp.LastIndexOf(',') != -1)
    {
        temp = temp.Trim(',');
    }

    temp += "]";
    Console.WriteLine(temp);
}