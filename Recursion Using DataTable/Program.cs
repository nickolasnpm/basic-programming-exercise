using System;
using System.Data;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    
    DataTable table = new DataTable();
    
    table.Columns.Add("ID", typeof(int));
    table.Columns.Add("Name", typeof(string));
    table.Columns.Add("ParentId", typeof(int));

    table.Rows.Add(1, "Mario", 0);
    table.Rows.Add(2, "Yoshi", 0);
    table.Rows.Add(3, "Sisha", 1);
    table.Rows.Add(4, "Ninja", 3);
    table.Rows.Add(5, "Yusof", 2);
    table.Rows.Add(6, "Amir", 4);
    table.Rows.Add(7, "Akmal", 6);
    table.Rows.Add(8, "Audrey", 5);
    table.Rows.Add(9, "Susan", 8);
    table.Rows.Add(10, "Albert", 7);

    int totalRows = table.Rows.Count;
    int totalColumns = table.Columns.Count;
    Console.WriteLine($"\nRow: {totalRows}, Column: {totalColumns} ");

    int idx = 0, amx = 0, parentID, grandparentID, position, pos;

    string name, childName, grandChildName;

    List<string> nameList = new List<string>();

    repeatOperation();

    void repeatOperation ()
    {
      while (idx < totalRows)
      {
        amx++;
        name = (string)table.Rows[idx][1];

        if (!(nameList.Contains(name)))
        {
            nameList.Add(name);
            Console.WriteLine($"\nParent : {name}");
        }
        
        for (int i = 0; i < totalRows; i++)
        {
            parentID = (int)table.Rows[i][2]; 

            if (parentID == amx) 
            {
                childName = (string)table.Rows[i][1]; 
                position = (int)table.Rows[i][0]; 

                if (!(nameList.Contains(childName)))
                {
                    nameList.Add(childName); 
                    Console.WriteLine($"Child: {childName}"); // yusof, 5
                }
                findingChild();
            }
        }
        idx++;
      }
    }
    
    void findingChild ()
    {
      pos = 0;

      while (pos < totalRows)
      {
        grandparentID = (int)table.Rows[pos][2]; 

        if (grandparentID == position) 
        {
            grandChildName = (string)table.Rows[pos][1]; 
            position = (int)table.Rows[pos][0];

            if (!(nameList.Contains(grandChildName)))
            {
                nameList.Add(grandChildName);
                Console.WriteLine($"Child: {grandChildName}");
            }

            findingChild();
        }
        pos++;
      }
    }
  }
}

// Output:
// Row: 10, Column: 3 

// Parent : Mario
// Child: Sisha
// Child: Ninja
// Child: Amir
// Child: Akmal
// Child: Albert

// Parent : Yoshi
// Child: Yusof
// Child: Audrey
// Child: Susan