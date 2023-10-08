
public class Display {
    
    public List<string> _entries = new List<string>();
    
    public void  DisplayEntries(){
        foreach (string item in _entries){
            Console.WriteLine(item);
        }
    }
}