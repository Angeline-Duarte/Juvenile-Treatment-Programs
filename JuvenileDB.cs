/*******************************************************************
* Name: Angeline Ortiz
* Date: 6/2/2024
* Assignment: 4.6 project
*
* DB for Juviniels, with methods.
*/
using System.Data.SQLite;
public class JuvenileDB
{
    public static void CreateTable(SQLiteConnection conn)
    {
        // SQL statement for creating a new table
        string sql =
        "CREATE TABLE IF NOT EXISTS Juvenile (\n"
        +"   CrimeType varchar(60)\n"
        +"   ,ProgramID integer\n"
        +"   ,ProgramName varchar(60)\n"
        +"   ,Location varchar(60)\n"
        +"   ,Cost dual \n"
        +"   ,Shelter boolean\n"
        +"   ,SecureFacility boolean\n"
        +"   ,JuvenileID integer PRIMARY KEY\n"
        +"   ,JuvenileName varchar(60)\n"
        +"   ,Age integer);";
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    public static void AddJuvenile(SQLiteConnection conn, Juvenile p)
    {
        string sql = string.Format(
        "INSERT INTO Juvenile(crimeType, programID, programName, location, cost, shelter, secureFacility, JuvenileID, JuvenileName, Age) "
        + "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
        p.CrimeType, p.ProgramID, p.ProgramName, p.Location, p.Cost, p.Shelter, p.SecureFacility, p.JuvenileID, p.JuvenileName, p.Age);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    public static void UpdateJuvenile(SQLiteConnection conn, Juvenile p)
    {
        string sql = string.Format(
        "UPDATE Juvenile SET JuvenileName='{0}', Age='{1}'"
        + " WHERE JuvenileID={3}", p.JuvenileName, p.Age, p.JuvenileID);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    public static void DeleteJuvenile(SQLiteConnection conn, int id)
    {
        string sql = string.Format("DELETE from Juvenile WHERE JuvenileID = {0}", id);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    public static List<Juvenile> GetAllJuveniles(SQLiteConnection conn)
    {
        List<Juvenile> Juveniles = new List<Juvenile>();
        string sql = "SELECT * FROM Juvenile";
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        SQLiteDataReader rdr = cmd.ExecuteReader();
        while (rdr.Read())
        {
            Juveniles.Add(new Juvenile(
            rdr.GetString(0),
            rdr.GetInt32(1),
            rdr.GetString(2),
            rdr.GetString(3),
            rdr.GetDouble(4),
            rdr.GetBoolean(5),
            rdr.GetBoolean(6),
            rdr.GetInt32(7),
            rdr.GetString(8),
            rdr.GetInt32(9)
            ));
        }
        return Juveniles;
    }
    public static Juvenile GetJuvenile(SQLiteConnection conn, int id)
    {
        string sql = string.Format("SELECT * FROM Juvenile WHERE JuvenileID = {0}", id);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        SQLiteDataReader rdr = cmd.ExecuteReader();
        if (rdr.Read())
        {
            return new Juvenile(
            rdr.GetString(0),
            rdr.GetInt32(1),
            rdr.GetString(2),
            rdr.GetString(3),
            rdr.GetDouble(4),
            rdr.GetBoolean(5),
            rdr.GetBoolean(6),
            rdr.GetInt32(7),
            rdr.GetString(8),
            rdr.GetInt32(9)
            );
        }
        else
        {
            return new Juvenile(string.Empty, -1, string.Empty, string.Empty, -1, false, false, -1, string.Empty, -1);
        }
    }
}