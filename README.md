## Условие задачи

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

## Описание решения

1. Создаем строковый массив array → [“Hello”, “2”, “world”, “:-)”]
2. С помощью цикла начинаем перебирать данный массив.
3. Находим количество элементов, длина которых меньше или равна 3.
4. Записываем полученный результат в переменную lenght.
5. После завершения цикла создаем новый массив newArray длинной равной lenght.
6. Создаем переменную index = 0, с помощью которой мы будем добавлять элементы в массив newArray
7. С помощью цикла перебираем массив array.
8. Находим каждый элемент, длина которых меньше или равна 3.
9. Заносим каждый полученный элемент в newArray[index], увеличевая после каждого повторения index на 1.
10. После завершения цикла получаем нужный нам массив newArray.
