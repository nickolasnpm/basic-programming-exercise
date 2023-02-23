using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    
    Person a = new Person() { Id = "1", Name = "Mario", ParentId = null };
    Person b = new Person() { Id = "2", Name = "Yoshi", ParentId = null };
    Person c = new Person() { Id = "3", Name = "Sisha", ParentId = "1" };
    Person d = new Person() { Id = "4", Name = "Ninja", ParentId = "3" };
    Person e = new Person() { Id = "5", Name = "Yusof", ParentId = "2" };
    Person f = new Person() { Id = "6", Name = "Josh", ParentId = "3" };
    Person g = new Person() { Id = "7", Name = "Alen", ParentId = "2" };

    List<Person> people = new() { a, b, c, d, e, f, g };

    List<Person> parent = people.Where(p => p.ParentId == null).ToList();

    foreach (var rootPerson in parent)
    {
      PrintPerson(rootPerson, people, 0);
    }

    void PrintPerson(Person person, List<Person> people, int indentLevel)
    {
      Console.WriteLine($"{new string(' ', indentLevel * 4)}Name: {person.Name}, Id: {person.Id}");
      var children = people.Where(p => p.ParentId == person.Id);
      
      foreach (var child in children)
      {
        PrintPerson(child, people, indentLevel + 1);
      }
      
    }
    
  }
  
  class Person
  {
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? ParentId { get; set; }
  }
  
}

// Output:
// Name: Mario, Id: 1
//     Name: Sisha, Id: 3
//         Name: Ninja, Id: 4
//         Name: Josh, Id: 6
// Name: Yoshi, Id: 2
//     Name: Yusof, Id: 5
//     Name: Alen, Id: 7
