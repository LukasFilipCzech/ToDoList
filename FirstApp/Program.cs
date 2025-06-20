/*

          this is a simple ToDoList 
             - allow us to exit 
             - allow us to add items to our ToDoList
             - allow us to remove items from our ToDoList 

*/


using System; 

public class Program
{

    public static void Main()
    {

        Console.WriteLine("Welcome to ToDoList!");


        while (true) {


            Console.WriteLine("Here are the options you can select:");

            Console.WriteLine("0 - exit:");
            Console.WriteLine("1 - view ToDo List");
            Console.WriteLine("2 - add to ToDo list");
            Console.WriteLine("3 - remove from ToDo list");



            string userInput = Console.ReadLine(); // wait for user input
            int optionId;
            bool option = int.TryParse(userInput, out optionId);


            if (option == false)
            {
                Console.WriteLine("Please type correct number. The range is (0-3).");

                continue; 
            }

            
            
            
            
            
            
            
            //break; 
        
        
        
        }


    }





}