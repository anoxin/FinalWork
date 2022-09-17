using static System.Console;
Clear();
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = { "Hello", "2", "world", ":-)" };
string[] newArray = GetArrayWithShorterStringLength(array);
WriteLine($"[{String.Join(", ", newArray)}]");

string[] GetArrayWithShorterStringLength(string[] array)
{
  string strElem = "";
  foreach (string item in array)
  {
    if (item.Length <= 3)
    {
      strElem += item + " ";
    }
  }
  string[] newArray = strElem.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
  return newArray;
}

