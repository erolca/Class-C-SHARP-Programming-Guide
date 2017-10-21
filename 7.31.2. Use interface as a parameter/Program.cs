interface Animal
{
}

class Dog : Animal
{
}

class Cat : Animal
{
}

class MainClass
{
    static void ListenToMe(Animal listener)
    {
    }

    static void Main()
    {
        Dog dog = new Dog();
        Cat cat = new Cat();

        ListenToMe(dog);
        ListenToMe(cat);
    }
}