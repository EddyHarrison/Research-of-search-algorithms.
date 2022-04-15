class  SpecificTableDebug : SpecificTable
{
    private void Add(string element, out int countTry)
    {
        int index = (int) (SpecificTableDebug.strToUint(element) % (uint) this._table.Length);
        countTry = 0;

        while (true)
        {
            countTry++;

            if (this._table[index] == null)
            {
                this._table[index] = element;
                break;
            }

            if (++index == this._table.Length)
            {
                index = 0;
            }
        }
    }

    public SpecificTableDebug(string[] array, out float[] coefRo, out int[] countsTry): base(new string[] {})
    {
        this._table = new string?[(int) (array.Length / (3.0F / 4.0F))];

        coefRo = new float[array.Length];
        countsTry = new int[array.Length];
        int countTry = 0;

        for (int index = 0; index < array.Length; index++)
        {
            if (index != 0)
            {
                coefRo[index] = index / (float) this._table.Length;
            }
            else
            {
                coefRo[index] = 0;
            }

            this.Add(array[index], out countTry);

            countsTry[index] = countTry;
        }
    }

    public int IndexOf(string element, out int countCompare)
    {
        int index = (int) (SpecificTableDebug.strToUint(element) % (uint) this._table.Length);
        int counter = 0;
        countCompare = 0;

        while (counter < this._table.Length)
        {
            countCompare++;

            if (this._table[index] is null)
            {
                return -1;
            }
            else if (this._table[index]!.Equals(element))
            {
                return index;
            }

            if (++index == this._table.Length)
            {
                index = 0;
            }

            counter++;
        }

        return -1; 
    }
} 

