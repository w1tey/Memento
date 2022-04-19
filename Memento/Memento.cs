using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class State
    {
        public string state { get; set; }
        public DateTime date { get; set; }

        public State(string _state)
        {
            state = _state;
            date = DateTime.Now;
        }

        public void Print()
        {
            Console.WriteLine($"{state} - {date}");
        }
    }


    public class Memento
    {
        public List<State> History =  new List<State>();

        public void Add(string _newState)
        {
            History.Append(new State(_newState));
        }

        public void Print()
        {
            foreach (var item in History)
            {
                item.Print();
            }
        }

         
    }

    public class Text 
    {
        public string currentText { get; set; }
        Memento memento { get; set; }

        public Text()
        {
            currentText = "";
            memento = new Memento();
        }

        public void Print()
        {
            memento.Print();
        }

        public void changeText(string newText)
        {
            currentText = newText;
            Backup();
        }
        public void Backup()
        {
            memento.Add(currentText);
        }

        public void Undo()
        {
            memento.History.RemoveAt(0);
            State temp = memento.History.First();
            currentText = temp.state;
        }


    }
}
