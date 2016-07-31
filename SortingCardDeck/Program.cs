using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main()
    {
        Random rnd = new Random();

        int i = Convert.ToInt32(Console.ReadLine()); // начальное число элементов
        int[] array = new int[i];

        // экземпляр класса, отвечающий за поиск минимального элемента
        MinElement minEl = new MinElement();


        for (int j = 0; j < array.Length; j++)
        {
            array[j] = j + 1;
            Console.Write(array[j] + " ");

        }
        Console.Write("\n");

        array = array.OrderBy(n => rnd.Next()).ToArray(); // перешивание элементов массива

        foreach (int t in array)
        {
            Console.Write(t + " ");
        }

        // в первый лист копируем эдементы массива
        List<int> firstList = new List<int>(array);

        // во второй складываем элементы первого по возрастанию, 
        // удаляя каждый раз минимальный из первого листа
        List<int> secondList = new List<int>(); 
        

        for (var j = 0; j < i; j++)
        {
            var minElement = minEl.SortingCardDeck(firstList);

            secondList.Add(minElement);

            firstList.Remove(minElement);
        }

        Console.Write("\n");
        foreach (int t in secondList)
        {
            Console.Write(t + " ");
        }

        Console.ReadLine();

    }


}

