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
    string Talkable.Table()
    {
        return "miao";
    }
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
    }
}