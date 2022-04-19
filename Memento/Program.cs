using System;


namespace Memento
{
    public static class Program
    {
        public static void Main()
        {
            Text text = new Text();
            text.changeText("djdjjdjd");
            text.changeText("Lets go");
            text.Print();
        }
    }
}