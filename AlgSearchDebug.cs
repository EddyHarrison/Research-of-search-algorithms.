using System;

class AlgSearchDebug
{
    public static int LinearSearch(string[] array, string element, out int countCompare)
    {
        countCompare = 0;

        for (int index = 0; index < array.Length; index++)
        {
            countCompare++;

            if (array[index].Equals(element))
            {
                return index;
            }
        }
        
        return -1;
    }

    public static int BinarySearch(string[] array, string element, out int countCompare)
    {
        int indexStart = 0;
        int indexEnd = array.Length - 1;
        int index = 0;
        countCompare = 0;

        while (indexEnd - indexStart > 0)
        {
            index = (indexEnd - indexStart) / 2 + indexStart;
            countCompare++;

            if (array[index].Equals(element))
            {
                return index;
            }
            else if (String.Compare(array[index], element) > 0)
            {
                indexEnd = index;
            }
            else
            {
                indexStart = index;
            }
        }
        
        return -1;
    }
}

