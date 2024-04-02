using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Interfaces
{
    class TodoList : IDisplayable, IResetable
    {
        /// <summary>
        /// Gets or sets the arrays of todos.
        /// </summary>
        /// <remarks>
        /// This property represents the list of todos in the TodoList.
        /// </remarks>
        public string[] Todos
        {  get; // Allows reading the Todos array
           private set; // Allows setting the Todos array only within the TodoList class
        }

        /// <summary>
        /// Gets the header symbol used for displaying the todo list header.
        /// </summary>
        /// <remarks>
        /// This property represents the symbol used to create a visual header for the todo list.
        /// </remarks>
        public char HeaderSymbol { get { return '-'; } } // Returns a default header symbol

        /// <summary>
        /// Represents the index of the next open position in the Todos array.
        /// </summary>
        /// <remarks>
        /// This field tracks the next available index in the Todos array where a new todo can be added.
        /// </remarks>
        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        /// <summary>
        /// Adds a new todo to the list if there is space available.
        /// If the list is already full, prints a message indicating so.
        /// </summary>
        /// <param name="todo">The todo item to add to the list.</param>
        public void Add(string todo)
        {
            // Check if there is space available in the Todos array
            if (nextOpenIndex < 5)
            {
                // Add the todo to the next available index in the Todos array
                Todos[nextOpenIndex] = todo;

                // Increment the index for the next open position
                nextOpenIndex++;
            }
            else
            {
                // If the Todos list is full, print a message indicating so

                Console.WriteLine("Todos list is full. Cannot add more todos.");
            }
        }

        /// <summary>
        /// Displays the todo list, including the header and todos.
        /// Empty todos are represented by [].
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Todo:");
            Console.WriteLine(new string(HeaderSymbol, 10)); // Print a line of HeaderSymbols

            // Loop through each todo item in the Todos array
            foreach (string todo in Todos)
            {
                if (string.IsNullOrEmpty(todo))
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine(todo);
                }
            }
        }

        /// <summary>
        ///  Resets the todo list by clearing all todos and resetting the index.
        /// </summary>
        public void Reset()
        {
            // Set console foreground color to red for emphasis
            Console.ForegroundColor = ConsoleColor.Red;

            // Print a message indicating that todos are being reset
            Console.WriteLine("Resetting Todos.\n");

            // Reset console color back to default
            Console.ResetColor();

            // Create a new array of strings to reset the Todos list
            Todos = new string[5];

            // Reset the index to add todos from the beginning of the array
            nextOpenIndex = 0;
        }
    }
}
