using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface Player
{
    void PlayMusic();
}

public class Student : Player
{
    public void PlayMusic() { }
    public void DoALittleDance() { }
}

public class MainClass
{
    static void Main()
    {
        Student st = new Student();
        Player musician = st; // downcast

        musician.PlayMusic();
        st.PlayMusic();
        st.DoALittleDance();
    }
}