/*******************************************************************
* Name: Angeline Ortiz
* Date: 5/30/2024
* Assignment: Week 3 Project
*
* Main application class.
*/
using System.Data.SQLite;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;

public class JuvenileTreatment
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nAngeline Ortiz de los Santos, Week 3 Project \n");
        //Treatment facilities
        TreatmentProgram treatmentProgram1 = new TreatmentProgram("Assault, Robbery, Drugs and Alcohol", 1, "Abraxas", "PA", 3472.00, true, true);
        TreatmentProgram treatmentProgram2 = new TreatmentProgram("Sexual Violence and Arson", 2, "Shaffner", "MD", 4585.08, false, true);
        Console.WriteLine("Available Treatment Program Facilities\n");
        Console.WriteLine("Program Facility #1");
        Console.WriteLine(treatmentProgram1);
        Console.WriteLine("Program Facility #2");
        Console.WriteLine(treatmentProgram2);
        Console.WriteLine("-----------------------------------------------------------------------------------------------\n");
        const string dbName = "Juvenile.db";
        SQLiteConnection conn = SQLiteDatabase.Connect(dbName);

         if (conn != null)
    {
        JuvenileDB.CreateTable(conn);
        //Create
        JuvenileDB.AddJuvenile(conn, new Juvenile ("Arson", 2, "Shaffner", "MD", 4585.08, true, false, 187, "Juana Marquez", 11));
    
        //Read
        Console.WriteLine("\nAll Juvenile in the Database");
        //PrintJuvenile(JuvenileDB.GetAllJuveniles(conn));
        Console.WriteLine("\nGet a Juvenile Using an Invalid ID");
        PrintJuvenile(JuvenileDB.GetJuvenile(conn, -5));
        //Update
        Juvenile JuvenileToUpdate = new Juvenile("Drugs", 2, "Shaffner", "MD", 4585.08, true, false, 187, "Juana Marquez", 11);
        JuvenileDB.UpdateJuvenile(conn, JuvenileToUpdate);
        Juvenile updatedJuvenile = JuvenileDB.GetJuvenile(conn, JuvenileToUpdate.JuvenileID);
        Console.WriteLine("\nUpdated Juvenile");
        PrintJuvenile(updatedJuvenile);
        //Delete
        JuvenileDB.DeleteJuvenile(conn, JuvenileToUpdate.JuvenileID);
        Console.WriteLine("\nAll People in the Database");
        //PrintJuvenile(JuvenileDB.GetAllJuveniles(conn));
    }

    }
    private static void PrintPeople(List<Juvenile> juveniles)
    {
    foreach (Juvenile p in juveniles)
    {
    PrintJuvenile(p);
    }
    }
    private static void PrintJuvenile(Juvenile p)
    {
    Console.WriteLine("Juvenile " + p.JuvenileID + ": ");
    Console.WriteLine(p.JuvenileName + " " + " is "
    + p.Age + " years old\n");
    }
}
