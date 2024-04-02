using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Interfaces
{
    class TodoList : IDisplayable, IResetable
    {
        public string[] Todos
        {  get; private set; }

        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }

        public void Display()
        {
            Console.WriteLine("Hello world!");
            foreach (string todo in Todos)
            {
                Console.WriteLine(todo);
            }
        }

        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }
    }
}
