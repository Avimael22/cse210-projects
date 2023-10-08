using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.IO;
public class Menu
{
    public string _file_Name = "";
    public List<string> _saving_List = new List<string>();
    
    
    public void DisplayMenu(){
        Console.WriteLine("Please select one of the following: \n 1. Write \n 2. Display \n 3.Load \n 4. Save \n 5. Quit");
        
    }

    public void SaveFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_file_Name)){
            foreach (string item in _saving_List){
                outputFile.WriteLine(item);
            }
        }
    }

    

}