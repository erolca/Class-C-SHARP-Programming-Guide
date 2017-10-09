using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;



//Defining a Class
class Employee
{
    //  Declaring Fields
    public string FirstName;
    public string LastName;
    public string Salary;

    public string GetName()
    {
        return $"{ FirstName } { LastName }";
    }

    //Using the this Keyword
    public void SetName(string newFirstName, string newLastName)
    {
        this.FirstName = newFirstName;
        this.LastName = newLastName;
        Console.WriteLine($"Name changed to ‘{ this.GetName() }’");
    }


    //Passing this in a Method Call
    public void Save()
    {
        DataStorage.Store(this);
    }

}


class DataStorage
{
    // Save an employee object to a file
    // named with the Employee name.
    // Error handling not shown.
    public static void Store(Employee employee)
    {
        // Instantiate a FileStream using FirstNameLastName.dat
        // for the filename. FileMode.Create will force
        // a new file to be created or override an
        // existing file.
        FileStream stream = new FileStream(employee.FirstName + employee.LastName + ".dat",FileMode.Create);
        // Create a StreamWriter object for writing text
        // into the FileStream.
        StreamWriter writer = new StreamWriter(stream);
        // Write all the data associated with the employee.
        writer.WriteLine(employee.FirstName);
        writer.WriteLine(employee.LastName);
        writer.WriteLine(employee.Salary);
        // Close the StreamWriter and its stream.
        writer.Close(); // Automatically closes the stream
    }
    
    public static Employee Load(string firstName, string lastName)
    {
        Employee employee = new Employee();
        // Instantiate a FileStream using FirstNameLastName.dat
        // for the filename. FileMode.Open will open
        // an existing file or else report an error.
        FileStream stream = new FileStream(firstName + lastName + ".dat", FileMode.Open);
        // Create a SteamReader for reading text from the file.
        StreamReader reader = new StreamReader(stream);
        // Read each line from the file and place it into
        // the associated property.
        employee.FirstName = reader.ReadLine();
        employee.LastName = reader.ReadLine();
        employee.Salary = reader.ReadLine();
        // Close the StreamReader and its stream.
        reader.Close(); // Automatically closes the stream
        return employee;
    }
}
public static class DirectoryInfoExtension
{
    public static void CopyTo( DirectoryInfo sourceDirectory, string target, SearchOption option, string searchPattern)
    {
        if (target[target.Length - 1] !=
        Path.DirectorySeparatorChar)
        {
            target += Path.DirectorySeparatorChar;
        }
        if (!Directory.Exists(target))
        {
            Directory.CreateDirectory(target);
        }
        for (int i = 0; i < searchPattern.Length; i++)
        {
            foreach (string file in
            Directory.GetFiles(
            sourceDirectory.FullName, searchPattern))
            {
                File.Copy(file,
                target + Path.GetFileName(file), true);
            }
        }
        //Copy subdirectories (recursively)
        if (option == SearchOption.AllDirectories)
        {
            foreach (string element in  Directory.GetDirectories(sourceDirectory.FullName))
            {
               // DirectoryInfo directory = new DirectoryInfo(".\\Source");
                CopyTo( new  DirectoryInfo (element), target + Path.GetFileName(element),SearchOption.AllDirectories, searchPattern);
                ;
            }
        }
    }
}



namespace Essential_Exm
{
    class Program
    {
        static void Main()
        {

         

            Employee employee1;
            Employee employee2 = new Employee();
            employee2.SetName("Inigo", "Montoya");
            employee2.Save();
            // Modify employee2 after saving.
            IncreaseSalary(employee2);
            // Load employee1 from the saved version of employee2
            employee1 = DataStorage.Load("Inigo", "Montoya");
            Console.WriteLine($"{ employee1.GetName() }: { employee1.Salary }");
            // ...


            // ...
            DirectoryInfo directory = new DirectoryInfo(".\\Source");
            directory.MoveTo(".\\Root");
            DirectoryInfoExtension.CopyTo(
            directory, ".\\Target",
            SearchOption.AllDirectories, "*");
            // ..

        }

        static void IncreaseSalary(Employee employee)
        {
            employee.Salary = "Enough to survive on";
        }

    }
}
