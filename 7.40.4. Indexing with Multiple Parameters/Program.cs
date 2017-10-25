using System;

public class Cell
{
    string name;

    public Cell(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return (name);
    }
}

public class Table
{
    Cell[,] table = new Cell[8, 8];

    int RowToIndex(string row)
    {
        string temp = row.ToUpper();
        return ((int)temp[0] - (int)'A');
    }

    int PositionToColumn(string pos)
    {
        return (pos[1] - '0' - 1);
    }

    public Cell this[string row, int column]
    {
        get
        {
            return (table[RowToIndex(row), column - 1]);
        }
        set
        {
            table[RowToIndex(row), column - 1] = value;
        }
    }

    public Cell this[string position]
    {
        get
        {
            return (table[RowToIndex(position),
            PositionToColumn(position)]);
        }
        set
        {
            table[RowToIndex(position),
            PositionToColumn(position)] = value;
        }
    }
}
class MainClass
{
    public static void Main()
    {
        Table table = new Table();

        table["A", 4] = new Cell("A4");
        table["H", 4] = new Cell("H4");

        Console.WriteLine("A4 = {0}", table["A", 4]);
        Console.WriteLine("H4 = {0}", table["H4"]);
    }
}