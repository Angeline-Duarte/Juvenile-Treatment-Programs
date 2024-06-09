/*******************************************************************
* Name: Angeline Ortiz
* Date: 5/30/2024
* Assignment: Week 3 Project
*
* SuccessRate Class delivering from Juvenile class. Class includes functions
* and to string to pass programs information.
*/
public class SuccessRate : Juvenile
{
    public string Grade {get; set;}
    public int Attendance {get; set;}
    public bool Graduate {get; set;}

    public SuccessRate(string crimeType, int programID, string programName, string location, double cost,
    bool shelter, bool secureFacility, int juvenileID, string juvenileName, int age, string grade, int attendance, bool graduate):
        base(crimeType, programID, programName, location, cost, shelter, secureFacility, juvenileID, juvenileName, age)
    {
        Grade = grade;
        Attendance = attendance;
        Graduate = graduate;
    }

    public override string ToString()
    {
        return string.Format(
            "{0}\n   Overall Grade: {1}\n   Overall Attendance: {2}\n   Did the juvenile graduate from the program? {3}",
             base.ToString(), Grade, Attendance, Graduate);
    }
}