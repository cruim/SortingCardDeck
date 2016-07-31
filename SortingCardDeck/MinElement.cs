using System.Collections.Generic;

public class MinElement
{
    public int SortingCardDeck(List<int> array)
    {
        int minElement = array[0];
        for (int i = 0; i < array.Count; i++)
        {
            if (minElement > array[i])
            {
                minElement = array[i];
            }
        }

        return minElement;
    }
}

