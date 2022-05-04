using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Item> todos = new List<Item>();
            bool quit = false;

            Console.WriteLine("Welcome to the To Do List");
            do
            {
                Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View/Remove/Quit)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "add")
                {
                    Console.WriteLine("Please enter the description for the new item.");
                    answer = Console.ReadLine();
                    Item newItem = new Item(todos.Count, answer);
                    todos.Add(newItem);
                    newItem.Id += 1;
                    Console.WriteLine($"'{answer}' has been added to your list.");

                }
                else if (answer == "view")
                {
                    foreach (Item todo in todos)
                    {
                        Console.WriteLine(todo.ToString());
                    }
                }
                else if (answer == "quit")
                {
                    Console.WriteLine("You are finished");
                    quit = true;

                }
                else if (answer == "remove")
                {
                    Console.WriteLine("Which item do you want to remove?");
                    
                    int i = int.Parse(Console.ReadLine()); 
                    int b = i-1;

                    Item removedItem = todos[b];
                    todos.Remove(removedItem);

                    for (int j = b; j < todos.Count; j++)
                    {
                        todos[j].Id -= 1;
                    }
                    Console.WriteLine($"'{removedItem}' has been removed from your list.");
                    

                }
                else
                {
                    Console.WriteLine("That is not a valid option. Please try again.");
                }
            } while (!quit);
        }
    }
}
