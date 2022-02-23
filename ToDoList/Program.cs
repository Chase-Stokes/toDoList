using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
  {
    public class Program {
      public static void Main()
      {
        List<Item> newList = new List<Item> {};
        string answer = "";
        int aCount = 0;
        // Item newTask = new Item();
        while (answer != "exit")
        {
          Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View) - (Exit to exit)");
          answer = Console.ReadLine().ToLower();
          if (answer == "add")
          {
            Console.WriteLine("Enter an task to add: ");
            string taskOne = Console.ReadLine();
            aCount++;
            Item newItem1 = new Item (aCount + ". " + taskOne);
            newList.Add(newItem1);
          }
          else if (answer == "view")
          {
          foreach (Item thisItem in newList)
            {
              Console.WriteLine(thisItem.Description);
            }
          }
          else if (answer == "exit")
          {
            Console.WriteLine("PEACE YO.");
          }
          else
          {
            Console.WriteLine("Should have typed Add or View or Exit sucka!!!");
          }
        }
      }
    }
  }