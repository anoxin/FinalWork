using static System.Console;
Clear();
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = { "Hello", "2", "world", ":-)" };
string[] newArray = GetArrayWithShorterStringLength(array);
PrintArray(newArray);

string[] GetArrayWithShorterStringLength(string[] array)
{
  int length = 0;
  foreach (string item in array)
  {
    if (item.Length <= 3)
    {
      length++;
    }
  }
  string[] newArray = new string[length];
  int index = 0;
  foreach (string item in array)
  {
    if (item.Length <= 3)
    {
      newArray[index] = item;
      index++;
    }
  }
  return newArray;
}

void PrintArray(string[] newArray)
{
  Write("[");
  for (int i = 0; i < newArray.Length; i++)
  {
    if (i != newArray.Length - 1)
    {
      Write($"{newArray[i]}, ");
    }
    else
    {
      Write($"{newArray[i]}");
    }
  }
  Write("]");
};
