public class ComponentGroup
{

    Component[] objects;
    int objectCount;

    public ComponentGroup()
    {
        objects = new Component[10];
        objectCount = 0;
    }
    public void AddObject(Component obj)
    {
        if (objectCount < 10)
        {
            objects[objectCount] = obj; // bu noktada, nesne referansa atanıyor
            objectCount++;
        }
    }
    public void Render()
    {
        for (int i = 0; i < objectCount; i++)
        {
            objects[i].Render();
        }
    }

    
}
public class Component
{
    internal void Render() { }
}

class Test
{
    public static void Main()
    {
        ComponentGroup group = new ComponentGroup();
        group.AddObject(new Component());

        Component t1= new Component();
        group.AddObject(t1);
        t1.Render();
    }
}