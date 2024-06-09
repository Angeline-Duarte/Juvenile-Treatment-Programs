/*******************************************************************
* Name: Angeline Ortiz
* Date: 5/30/2024
* Assignment: Week 3 Project
*
* TreatmentProgram Class delivering from Crime abstract Class. Class includes functions
* and to string to pass programs information.
*/
using System.Security.Cryptography.X509Certificates;

public class TreatmentProgram : Crime
{
    public int ProgramID {get; set;}
    public string ProgramName {get; set;}
    public double Cost {get; set;}
    public string Location {get; set;}
    public bool Shelter {get; set;}
    public bool SecureFacility {get; set;}



    public TreatmentProgram (string crimeType, int programID, string programName, string location, double cost,
    bool shelter, bool secureFacility): base (crimeType)
    {
        ProgramID = programID;
        ProgramName = programName;
        Location = location;
        Cost = cost;
        Shelter = shelter;
        SecureFacility = secureFacility;

    }

    public override string ToString()
    {
        return string.Format(
            "{0}\n   Crime Types: {1}\n   Program ID: {2}\n   Program Name: {3}\n   Location of Program: {4}\n   Cost of Program per month/juvenile: {5}\n   Shelter? {6}\n   Secure facility? {7}\n",
             base.ToString(), CrimeType, ProgramID, ProgramName, Location, Cost, Shelter, SecureFacility);
    }

}