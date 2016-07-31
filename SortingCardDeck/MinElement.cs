using System;
using System.Collections.Generic;
using System.Linq;

public class MinElement
{

    public int SortingCardDeck(List<int> array)
    {
        int minElement = array[0];

        foreach (int t in array)
        {

            if (minElement > t)
            {
                minElement = t;
            }
        }

        return minElement;
    }
}

