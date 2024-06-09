/*******************************************************************
* Name: Angeline Ortiz
* Date: 5/30/2024
* Assignment: Week 3 Project
*
* Juvenile Class delivering from TreatmentProgram class. Class includes functions
* and to string to pass programs information.
*/
public class Juvenile: TreatmentProgram
{
    public int JuvenileID {get; set;}
    public string JuvenileName {get; set;}
    public int Age {get; set;}

    public Juvenile(string crimeType, int programID, string programName, string location, double cost,
    bool shelter, bool secureFacility, int juvenileID, string juvenileName, int age): 
            base(crimeType, programID, programName, location, cost, shelter, secureFacility)
    {
        JuvenileID = juvenileID;
        JuvenileName = juvenileName;
        Age = age;
    }

    public override string ToString()
    {
        return string.Format(
            "{0}   Juvenile ID: {1}\n   Juvenile Name: {2}\n   Age: {3}",
             base.ToString(), JuvenileID, JuvenileName, Age);
    }
}