using System.Collections.Generic;
using System;
using ToDoList.Models;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    private static List<Item> _instances = new List<Item> {};

    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
    }
  
    public static List<Item> GetAll()
    {
      return _instances;
    }  

    public static void ClearAll() 
    {
      _instances.Clear();
    }

    // static void AddItem()
    // {
    //   Console.WriteLine("NEW ITEM");
    //   Console.WriteLine("Enter a new list item");
    //   string item = Console.ReadLine();
    // }
  }
}