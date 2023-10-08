using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;


class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;

        Menu menu = new Menu();
        menu.DisplayMenu();

        int answer = int.Parse(Console.ReadLine());

        List<string> MyList = new List<string>();

        do {
            if (answer == 1){
                Prompt random = new Prompt();
                random.PromptGenerator();
                Entry first = new Entry();
                first._current_Date = theCurrentTime.ToShortDateString();
                first._entry = Console.ReadLine();
                MyList.Add($"{first._current_Date} - Prompt: {random.PromptGenerator} \n >{first._entry}");
            }

            if (answer == 2){
                Display show = new Display();
                show._entries.AddRange(MyList);
                show.DisplayEntries();
            }
            if (answer == 3){
                MyList.Clear();
                Console.WriteLine("name of file you wish to load: ");
                Menu load = new Menu();
                load._file_Name = Console.ReadLine();
                string[] existing = System.IO.File.ReadAllLines(load._file_Name);
                MyList.AddRange(existing);


            }
            if (answer == 4){
                Console.WriteLine("Enter the file name you wish to save it as: ");
                Menu file = new Menu();
                file._file_Name = Console.ReadLine();
                file._saving_List.AddRange(MyList);
                file.SaveFile();
            }

            menu.DisplayMenu();
            answer = int.Parse(Console.ReadLine());
            
        } while(answer != 5);
    }
}