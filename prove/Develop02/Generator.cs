public class Prompt {
     List<string> prompts = new List<string>(){
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
     };
    
    public void PromptGenerator()
    {
        Random RandomGenerator = new Random();
        int index = RandomGenerator.Next(0, prompts.Count);
            Console.WriteLine(prompts[index]);
    }
}