using System.Collections.Generic;
using System;
using ToDoList.Models;

namespace ToDoList.Models
{
  public class Program
  {

    public static void Main()
    {
      // Console.WriteLine("Do you want to create a new list? ['Yes' to add a new list, 'No' to close the program]");
      // string yesOrNo = Console.ReadLine();
      // if (yesOrNo == "Yes" || yesOrNo == "yes")
      // {
      // List<Item> newList = new List<Item> { };
      // }
      // else 
      // {
      //   Main();
      // }
      Console.WriteLine("Do you want to add something to your list or view your list? ['Add' for add, 'View' for view]");
      string answer = Console.ReadLine();
      if (answer == "Add" || answer == "add")
      {
        Console.WriteLine("What would you like to add?");
        string listItem = Console.ReadLine();
        Item newItem = new Item (listItem); 
        Main();
      }
      else if (answer == "View" || answer == "view")
      {
        List<Item> result = Item.GetAll();

        foreach (Item thisItem in result)
        {
        Console.WriteLine("View the items on your list: " + thisItem.Description);
        }
      }
    }
  }
}