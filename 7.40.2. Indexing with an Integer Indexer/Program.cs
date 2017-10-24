using System;
using System.Collections;


//It is possible to overload the[] operator for classes that you create with an indexer.
//An indexer allows an object to be indexed like an array.


class Pair
{

    string name;
    object data;

    public Pair(string _name, object _data)
    {
        this.name = _name;
        this.data = _data;
    }

    public string Name
    {
        get
        {
            return (name);
        }
        set
        {
            name = value;
        }
    }

    public object Data
    {
        get
        {
            return (data);
        }
        set
        {
            data = value;
        }
    }
   
}



class PairList
{
    ArrayList row;

    public PairList()
    {
        row = new ArrayList();
    }

    public void Load()
    {
        /* load code here */
        row.Add(new Pair("A", 5551212));
        row.Add(new Pair("B", "Fred"));
        row.Add(new Pair("C", 2355.23m));
    }

    // the indexer
    public Pair this[int column]
    {
        get
        {
            return ((Pair)row[column - 1]);
        }
        set
        {
            row[column - 1] = value;
        }
    }
    
}
class MainClass
{
    public static void Main()
    {
        PairList Row_ = new PairList();
        Row_.Load();
        Console.WriteLine("Column 0: {0}", Row_[1].Data);
        Row_[1].Data = 12;
    }
}