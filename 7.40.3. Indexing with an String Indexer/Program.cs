using System;
using System.Collections;
class Pair
{
    string name;//field
    object data;//field

    //const. method
    public Pair(string name, object data)
    {
        this.name = name;
        this.data = data;
    }

    //properties
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
        row.Add(new Pair("Q", 5551212));
        row.Add(new Pair("A", "text"));
        row.Add(new Pair("B", 2355.23m));
    }

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

    int FindPair(string name)
    {
        for (int index = 0; index < row.Count; index++)
        {
            Pair Pair = (Pair)row[index];
            if (Pair.Name == name)
                return (index);
        }
        return (-1);
    }
    public Pair this[string name]
    {
        get
        {
            return ((Pair)this[FindPair(name)]);
        }
        set
        {
            this[FindPair(name)] = value;
        }
    }
   
}


class Test
{
    public static void Main()
    {

        //ornek olması acısından->RawView
        ArrayList listarray = new ArrayList();

        PairList row = new PairList();
        row.Load();
        Pair val = row["A"];
        Console.WriteLine("A: {0}", val.Data);
        Console.WriteLine("B: {0}", row["B"].Data);
        row["Q"].Data = "new value";    // set the name
        Console.WriteLine("Q: {0}", row["Q"].Data);
    }
}

//PairList Row_ = new PairList();
//Row_.Load();
//        Console.WriteLine("Column 0: {0}", Row_[1].Data);
//        Row_[1].Data = 12;