/*

          this is a simple ToDoList 
             - allow us to exit 
             - allow us to add items to our ToDoList
             - allow us to remove items from our ToDoList 

*/


using System;
using System.Collections.Generic;
using System.Diagnostics;


public class Program
{

    public static void Main()
    {

        Console.WriteLine("Welcome to ToDoList!");


        
        
        List<string> todoListItems = new List<string>();

        while (true) {


            Console.WriteLine("Here are the options you can select:");

            Console.WriteLine("0 - exit:");
            Console.WriteLine("1 - view ToDo List");
            Console.WriteLine("2 - add to ToDo list");
            Console.WriteLine("3 - remove from ToDo list");
            Console.WriteLine("4 - mark task as complete");
            Console.WriteLine("5 - edit task");


            string userInput = Console.ReadLine(); // wait for user input
            int optionId;
            bool option = int.TryParse(userInput, out optionId);

            if (!option)
            {
                Console.WriteLine("Input was not an integer!");
                continue;

            }
          


            if (optionId < 0 || optionId > 5) // Updated the range check
            {
                Console.WriteLine("Please type correct number. The range is (0-5). \n");

                continue; 
            }

            
            if (optionId == 0)
            {
                Console.WriteLine("Program was successfully ended. \n" );
                break;

            }

            if (optionId == 1)
            {
                if (todoListItems.Count == 0)
                {
                    Console.WriteLine("ToDo list is empty.");
                }
                else
                {
                    for (int i = 0; i < todoListItems.Count; i++)
                    {
                        Console.WriteLine($"{i}: {todoListItems[i]}");
                    }
                }
            }

            if (optionId == 2)
            {
                Console.WriteLine("Enter new task:");
                string newToDoList = Console.ReadLine(); // wait for user input 
                
               if (!string.IsNullOrWhiteSpace(newToDoList))
                {

                    todoListItems.Add(newToDoList);
                    Console.WriteLine("New item was successfully added. \n");

                }
                else
                {

                    Console.WriteLine("Item was not added. Task cannot be empty. \n");
                     
                }
            }

            if (optionId == 3) // removing items 
            {
                if (todoListItems.Count == 0)
                {
                    Console.WriteLine("ToDo list is empty. Nothing to remove.");
                    continue;
                }
                Console.WriteLine("Please type the index of the item you want to remove:");
                 for (int i = 0; i < todoListItems.Count; i++)
                {
                    Console.WriteLine($"{i}: {todoListItems[i]}");
                }

                string userInputForRemoveIndex = Console.ReadLine();
                int removeIndex;
                bool removeIndexParseResult = int.TryParse(userInputForRemoveIndex, out removeIndex);
                
                if (removeIndexParseResult == false)
                {
                    Console.WriteLine("Input was not an integer!");
                    continue; 

                }

                if (removeIndex < 0 || removeIndex >= todoListItems.Count)
                {
                    Console.WriteLine("Input must be non-negative and less than the size of the collection!");
                    continue; 

                }

                todoListItems.RemoveAt(removeIndex);
                Console.WriteLine("Item was successfully removed. \n");

            }
            
            if (optionId == 4) // Mark task as complete
            {
                if (todoListItems.Count == 0)
                {
                    Console.WriteLine("ToDo list is empty. Nothing to mark as complete.");
                    continue;
                }
                Console.WriteLine("Please type the index of the item you want to mark as complete:");
                for (int i = 0; i < todoListItems.Count; i++)
                {
                    Console.WriteLine($"{i}: {todoListItems[i]}");
                }

                string userInputForCompleteIndex = Console.ReadLine();
                int completeIndex;
                bool completeIndexParseResult = int.TryParse(userInputForCompleteIndex, out completeIndex);

                if (completeIndexParseResult == false)
                {
                    Console.WriteLine("Input was not an integer!");
                    continue;
                }

                if (completeIndex < 0 || completeIndex >= todoListItems.Count)
                {
                    Console.WriteLine("Input must be non-negative and less than the size of the collection!");
                    continue;
                }

                if (todoListItems[completeIndex].EndsWith("[DONE]"))
                {
                    Console.WriteLine("Task is already marked as complete.");
                }
                else
                {
                    todoListItems[completeIndex] = todoListItems[completeIndex] + " [DONE]";
                    Console.WriteLine("Task marked as complete. \n");
                }
            }

            if (optionId == 5) // Edit task
            {
                if (todoListItems.Count == 0)
                {
                    Console.WriteLine("ToDo list is empty. Nothing to edit.");
                    continue;
                }
                Console.WriteLine("Please type the index of the item you want to edit:");
                for (int i = 0; i < todoListItems.Count; i++)
                {
                    Console.WriteLine($"{i}: {todoListItems[i]}");
                }

                string userInputForEditIndex = Console.ReadLine();
                int editIndex;
                bool editIndexParseResult = int.TryParse(userInputForEditIndex, out editIndex);

                if (editIndexParseResult == false)
                {
                    Console.WriteLine("Input was not an integer!");
                    continue;
                }

                if (editIndex < 0 || editIndex >= todoListItems.Count)
                {
                    Console.WriteLine("Input must be non-negative and less than the size of the collection!");
                    continue;
                }

                Console.WriteLine($"Editing task: {todoListItems[editIndex]}");
                Console.WriteLine("Enter the new task description:");
                string newTaskDescription = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newTaskDescription))
                {
                    todoListItems[editIndex] = newTaskDescription;
                    Console.WriteLine("Task successfully updated. \n");
                }
                else
                {
                    Console.WriteLine("Task not updated. New description cannot be empty. \n");
                }
            }
        }
    }
}