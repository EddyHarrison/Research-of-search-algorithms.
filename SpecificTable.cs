class SpecificTable
{
    protected string?[] _table;

    protected static uint strToUint(string element)
    {
        uint num = 0;

        foreach (char item in element)
        {
            num += (uint) item;
        }

        return num;
    }

    protected void Add(string element)
    {
        int index = (int) (SpecificTable.strToUint(element) % (uint) this._table.Length);

        while (true)
        {
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

    public SpecificTable(string[] array)
    {
        this._table = new string?[(int) (array.Length / (3.0F / 4.0F))];

        foreach (string item in array)
        {
            this.Add(item);
        }
    }

    public int IndexOf(string element)
    {
        int index = (int) (SpecificTable.strToUint(element) % (uint) this._table.Length);
        int counter = 0;

        while (counter < this._table.Length)
        {
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

    public override string ToString()
    {
        string result = "[";

        for (int index = 0; index < this._table.Length - 1; index++)
        {
            if (this._table[index] is null)
            {
                result += "null";
            }
            else
            {
                result += this._table[index];
            }
            
            result += ", ";
        }

        if (this._table[this._table.Length - 1] is null)
        {
            result += "null";
        }
        else
        {
            result += this._table[this._table.Length - 1];
        }

        result += "]";

        return result;
    }
} 

