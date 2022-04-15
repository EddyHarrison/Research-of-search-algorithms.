using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        // prepared
        int output = 0;
        int counter = 0;

        float[] arrayRo;
        int[] countsTry;

        // 1 step
        string[] sourceArray = new string[] { "Ты", "богат", "я", "очень", "беден", "прозаик", "поэт", "румян", "как", "маков", "цвет", "смерть", "тощ ", "бледен", "Не", "имея", "ввек", "забот", "живешь", "в", "огромном", "доме", "огромном", "ж", "средь", "горя", "хлопот", "Провожу", "дни ", "соломе", "Ешь", "сладко", "всякий", "день", "Тянешь", "вины", "на", "свободе", "вины", "тебе", "нередко", "лень", "Нужный", "долг", "отдать", "природе", "черствого", "куска", "От", "воды", "сырой", "пресной", "Сажен", "сто ", "чердака", "За", "нуждой ", "бегу", "известной", "Окружен", "рабов ", "толпой" };

        // 2 step
        Console.WriteLine("-----");
        Console.WriteLine("2 step");

        output = AlgSearch.LinearSearch(sourceArray, "я");
        Console.WriteLine(output);

        Console.WriteLine("-----");

        // 3 step
        Console.WriteLine("-----");
        Console.WriteLine("3 step");

        output = AlgSearch.LinearSearch(sourceArray, "оно");
        Console.WriteLine(output);

        Console.WriteLine("-----");

        // 4 step
        Console.WriteLine("-----");
        Console.WriteLine("4 step");

        countsTry = new int[sourceArray.Length];

        for (int index = 0; index < sourceArray.Length; index++)
        {
            output = AlgSearchDebug.LinearSearch(sourceArray, sourceArray[index], out counter);
            countsTry[index] = counter;
        }

        Console.Write("countsTry = ");
        Console.WriteLine(ArrayNumToString(countsTry));
        Console.Write("length = ");
        Console.WriteLine(countsTry.Length);
        Console.Write("average = ");
        Console.WriteLine(Enumerable.Sum(countsTry) / countsTry.Length);

        Console.WriteLine("-----");

        // 5 step
        string[] sortedArray = new string[sourceArray.Length];
        Array.Copy(sourceArray, sortedArray, sourceArray.Length);

        Array.Sort(sortedArray);

        // 6 step
        Console.WriteLine("-----");
        Console.WriteLine("6 step");

        output = AlgSearch.LinearSearch(sortedArray, "я");
        Console.WriteLine(output);

        Console.WriteLine("-----");

        // 7 step
        Console.WriteLine("-----");
        Console.WriteLine("7 step");

        output = AlgSearch.BinarySearch(sortedArray, "я");
        Console.WriteLine(output);

        Console.WriteLine("-----");

        // 8 step

        Console.WriteLine("-----");
        Console.WriteLine("8 step");

        SpecificTableDebug specTable = new SpecificTableDebug(sourceArray, out arrayRo, out countsTry);

        Console.Write("specTable = ");
        Console.WriteLine(specTable.ToString());
        Console.Write("arrayRo = ");
        Console.WriteLine(ArrayNumToString(arrayRo));

        Console.WriteLine("-----");

        // 9 step
        Console.WriteLine("-----");
        Console.WriteLine("9 step");

        Console.Write("countsTry = ");
        Console.WriteLine(ArrayNumToString(countsTry));
        Console.Write("sum = ");
        Console.WriteLine(Enumerable.Sum(countsTry));

        Console.WriteLine("-----");

        // 10 step
        Console.WriteLine("-----");
        Console.WriteLine("10 step");

        int[] t = new int[sourceArray.Length];

        for (int index = 0; index < sourceArray.Length; index++)
        {
            specTable.IndexOf(sourceArray[index], out counter);
            t[index] = counter;
        }

        Console.Write("t = ");
        Console.WriteLine(ArrayNumToString(t));
        Console.Write("sum = ");
        Console.WriteLine(Enumerable.Sum(t));
        Console.Write("avg = ");
        Console.WriteLine(Enumerable.Sum(t) / (float) t.Length);

        Console.WriteLine("-----");

        // 11 step
        Console.WriteLine("-----");
        Console.WriteLine("11 step");

        string[] someStrings = new string[] {"qwe", "rty", "uio", "asd", "fgh", "jkl", "zxc", "vbn"};

        t = new int[someStrings.Length];

        for (int index = 0; index < someStrings.Length; index++)
        {
            specTable.IndexOf(someStrings[index], out counter);
            t[index] = counter;
        }

        Console.Write("t = ");
        Console.WriteLine(ArrayNumToString(t));
        Console.Write("sum = ");
        Console.WriteLine(Enumerable.Sum(t));
        Console.Write("avg = ");
        Console.WriteLine(Enumerable.Sum(t) / (float) t.Length);

        Console.WriteLine("-----");
    }

    public static string ArrayNumToString<T>(T[] array)
    {
        string result = "[";

        for (int index = 0; index < array.Length - 1; index++)
        {
            if (array[index] is null)
            {
                result += "null";
            }
            else
            {
                result += array[index]!.ToString();
            }
            
            result += ", ";
        }

        if (array[array.Length - 1] is null)
        {
            result += "null";
        }
        else
        {
            result += array[array.Length - 1];
        }

        result += "]";

        return result;
    }
}
