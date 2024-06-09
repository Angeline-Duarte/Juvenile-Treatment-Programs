/*******************************************************************
* Name: Angeline Ortiz
* Date: 5/30/2024
* Assignment: Week 3 Project
*
* Crime abstract class. 
*/
public abstract class Crime
{
    public string CrimeType {get; set; }

    public Crime (string crimeType) 
    {
        CrimeType = crimeType;
    }
}