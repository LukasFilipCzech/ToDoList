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



            string userInput = Console.ReadLine(); // wait for user input
            int optionId;
            bool option = int.TryParse(userInput, out optionId);

            if (!option)
            {
                Console.WriteLine("Input was not an integer!");
                continue;

            }
          


            if (option == false)
            {
                Console.WriteLine("Please type correct number. The range is (0-3). \n");

                continue; 
            }

            
            if (optionId == 0)
            {
                Console.WriteLine("Program was successfully ended. \n" );
                break;

            }

            if (optionId == 1)
            {
                foreach (string item in todoListItems) // write to console every part from ToDoList Items 
                {
                Console.WriteLine(item);
                }



                /* 
                   for (int i = 0; i < todoListItems.Count; i++)
                {
                    string item = todoListItems[i];
                    Console.WriteLine(item);

                }
                 
                */

            
            }

            if (optionId == 2)
            {

                string newToDoList = Console.ReadLine(); // wait for user input 
                
               if (newToDoList != "")
                {

                    todoListItems.Add(newToDoList);
                    Console.WriteLine("New item was successfully added. \n");

                }
                else
                {

                    Console.WriteLine("Item was not added. \n");
                     
                }
                    
            

            }

            if (optionId == 3) // removing items 
            {
                Console.WriteLine("Please type a item what you want to remove:");

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

            }
            


            


        }


    }





}