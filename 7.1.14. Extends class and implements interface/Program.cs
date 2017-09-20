using System;
using System.Collections.Generic;
using System.Text;

interface Talkable
{
    string Table();
}


class Animal { }


class Cat : Animal, Talkable
{
    public string Table()
    {
        return "miao";
    }
   /* string Talkable.Table()
    {
        return "miao";
    }*/
}

class Dog : Animal, Talkable
{
    string Talkable.Table()
    {
        return "bulk";
    }
}

class Elephant : Animal
{

}

class MainClass
{
    static void Main()
    {
        Animal[] AnimalArray = new Animal[3];

        AnimalArray[0] = new Cat();
        AnimalArray[1] = new Elephant();
        AnimalArray[2] = new Dog();

        foreach (Animal a in AnimalArray)
        {
            Talkable b = a as Talkable;
            if (b != null)
                Console.WriteLine("Baby is called: {0}", b.Table());
        }

        //as :You can use the as operator to perform certain types of conversions between compatible reference types or nullable types.
        // seperate exercise...
        Derived d = new Derived();

        Base b_ = d as Base;
        if (b_ != null)
        {
            Console.WriteLine(b_.ToString());
        }
    }



    class Base
    {
        public override string ToString()
        {
            return "Base";
        }
    }

    class Derived : Base
    { }
}




  

